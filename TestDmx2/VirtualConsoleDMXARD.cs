using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDmx2.Models;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;
using System.Timers;

namespace TestDmx2
{
    public partial class DMXandARD : Form
    {
        private byte[] buffer = new byte[513];
        private int DeviceIndex;
        int dmxRange = 0;
        Thread InfoSendDmx;
        bool runThread = false;
        bool runThreadArd = false;
        string[] portsDMX = SerialPort.GetPortNames();
        string[] portsARD = SerialPort.GetPortNames();
        SerialPort COMPORT;
        SerialPort ARDCOMPORT;
        DMXFixtures dmxFixtures;
        const int DMX_MAX_FIXTURES=32;
        const int DMX_MAX_CHANNELS = 16;
        List<int> sliderValues;
        List<int> sliderValuesMaster;
        public SceneSaveDialog sceneSaveDialog { get; set; }
        DMXARDproject ActiveProject;
        StreamWriter streamAutoSave;
        System.Timers.Timer timer;
        bool sceneLoad = false;
        String OldMessage = "";
        DataSet ArdInfo=new DataSet();
        DataSet MusicFilesInfo = new DataSet();
        public DMXandARD()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string porter in portsDMX)
            {

                SerialDevices.Items.Add(porter);

            }
            SerialDevices.SelectedIndex = 0;
            foreach (string porter in portsARD)
            {

                SerialDevicesDMX.Items.Add(porter);

            }
            SerialDevicesDMX.SelectedIndex = 0;
            SerialDevices.SelectedIndex = 0;
            //FTDI_DeviceControl=new FTDI_Device();
            ProgressBarCycle.Maximum = 100;
            ProgressBarCycle.Step = 1;
            ProgressBarCycle.Value = 0;
            dmxFixtures = new DMXFixtures();
            sliderValues=new List<int>();
            sliderValuesMaster = new List<int>();
            for (int i = 0; i < DMX_MAX_CHANNELS; i++)
            {
                sliderValues.Add(0);
                sliderValuesMaster.Add(0);
            }
            ActiveProject=new DMXARDproject();
            FixtureComboBox.Items.Clear();
            FixtureComboBox.Items.Add("All Fixtures");
            FixtureComboBox.SelectedIndex = 0;
            autoSave(ActiveProject);
            DataTable configTable = new DataTable();
            configTable.TableName = "Config";
            configTable.Columns.Add(new DataColumn("PortNumber"));
            configTable.Columns.Add(new DataColumn("IO"));
            configTable.Columns.Add(new DataColumn("Triggered"));
            ArdInfo.Tables.Add(configTable);
            dataGridARD.AutoGenerateColumns = true;
            dataGridARD.DataSource = ArdInfo;
            dataGridARD.DataMember = "Config";
            dataGridARD.Refresh();
            configTable = new DataTable();
            configTable.TableName = "MusicConfig";
            configTable.Columns.Add(new DataColumn("Name"));
            configTable.Columns.Add(new DataColumn("Details"));
            configTable.Columns.Add(new DataColumn("Path"));
            MusicFilesInfo.Tables.Add(configTable);
            dataGridMusic.AutoGenerateColumns = true;
            dataGridMusic.DataSource = MusicFilesInfo;
            dataGridMusic.DataMember = "MusicConfig";
            dataGridMusic.Refresh();
        }
        private void refreshScenes()
        {
            int selectedIndex = SceneSelection.SelectedIndex;
            foreach(String ListItem in SceneSelection.Items)
            {
                if(!ActiveProject.Scenes.ContainsKey(ListItem))
                {
                    SceneSelection.Items.Remove(ListItem);
                }
            }
            foreach (String Key in ActiveProject.Scenes.Keys)
            {
                if (!SceneSelection.Items.Contains(Key))
                {
                    SceneSelection.Items.Add(Key);
                    SceneSelection.SelectedIndex = SceneSelection.Items.Count - 1;
                }
            }
            //bringUpScene(SceneSelection.Text);
        }
        private void autoSave(DMXARDproject activeProject)
        {
            streamAutoSave = new StreamWriter("autoSave.json",false);
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize<DMXARDproject>(activeProject, options);
            streamAutoSave.WriteLine(jsonString);
            streamAutoSave.Close();
            refreshScenes();
        }
        private void WriteToPort(SerialPort SerPort, String Data)
        {
            /*byte[] byData = System.Text.Encoding.ASCII.GetBytes(Data);
            foreach (byte BYT in byData)
            {
                SerPort.BaseStream.WriteByte(BYT);
            }*/
            try
            {
                SerPort.WriteLine(Data);
                //Messages.Items.Add("Sent " + Data);
            }
            catch (Exception Ex)
            {
                Messages.Items.Add(Ex.ToString());
            }

        }
        private SerialPort initialize_PORT(String port)
        {

            SerialPort ARDCOMPORT = new SerialPort();
            ARDCOMPORT.PortName = port;
            ARDCOMPORT.BaudRate = 115200;
            ARDCOMPORT.ReadTimeout = 500;
            ARDCOMPORT.WriteTimeout = 500;
            ARDCOMPORT.DtrEnable = true;
            //Thread.Sleep(100);
            ARDCOMPORT.Parity = Parity.None;
            ARDCOMPORT.DataBits = 8;
            ARDCOMPORT.StopBits = System.IO.Ports.StopBits.One;
            ARDCOMPORT.Handshake = Handshake.None;
            //currentFrame = 0;
            return ARDCOMPORT;
        }
        void addConfigListView(String config)
        {
            //string[] row = { PortNumber, IO, Triggered };
            //var listViewItem = new ListViewItem(row);
            //listView1.Items.Add(listViewItem);

            String[] tokens=config.Split('~');
            foreach (String token in tokens)
            {
                string[] items = token.Split(":");
                if (token.CompareTo("CONFIG") != 0 && token.CompareTo("END") != 0 && token.CompareTo("") != 0)
                {
                    //Messages.Items.Add(String.Format("Config For {0}: Token {1}",items[0],token));
                    //Messages.SelectedIndex = Messages.Items.Count - 1;
                    DataRow NewRow;
                    NewRow = ArdInfo.Tables[0].NewRow();
                    NewRow[0] = items[0];
                    NewRow[1] = items[1];
                    NewRow[2] = 0;
                    ArdInfo.Tables[0].Rows.Add(NewRow);
                    ArdInfo.Tables[0].AcceptChanges();
                    
                }

            }
            dataGridARD.Refresh();
        }
        void updateStatesListView(String states)
        {
            String[] tokens = states.Split('~');
            foreach (String token in tokens)
            {
                string[] items = token.Split(":");
                if (token.CompareTo("VALUES") != 0 && token.CompareTo("END") != 0 && token.CompareTo("") != 0 && tokens.Length>=3)
                {
                    //Messages.Items.Add(String.Format("Values For {0} {1}", items[0],token));
                    
                    DataRow[] ARDrows = ArdInfo.Tables[0].Select(String.Format("PortNumber='{0}'", items[0]));
                    if (ARDrows.Length > 0)
                    {
                        Messages.Items.Add(String.Format("Values For {0} {1}", items[0], token));
                        Messages.SelectedIndex = Messages.Items.Count - 1;
                        switch(items[1])
                        {
                            case "0":
                                ARDrows[0][2]=1;
                                break;
                            case "1":
                                ARDrows[0][2]=0;
                                break;
                        }
                        ARDrows[0].AcceptChanges();
                    }
                }
            }
            dataGridARD.Refresh();
        }
        private async void ReadFromPort(SerialPort SerPort)
        {
            try
            {
                if (true)//SerPort.BytesToRead > 0)
                {
                    String Test = SerPort.ReadLine();
                    //Thread.Sleep(4);
                    if (OldMessage.CompareTo(Test) != 0)
                    {
                        Messages.Items.Add("RECV: " + Test+" :EOT");
                        if(Test.Contains("CONFIG"))
                        {
                            addConfigListView(Test);
                        }
                        if(Test.Contains("VALUES"))
                        {
                            updateStatesListView(Test);
                        }
                        Messages.SelectedIndex = Messages.Items.Count - 1;
                        OldMessage = Test;

                    }
                    ARDCOMPORT.DiscardInBuffer();
                }
            }
            catch (Exception Ex)
            {
                //Messages.Items.Add(Ex.ToString());
                //Messages.SelectedIndex = Messages.Items.Count - 1;
            }

        }
        private void MusicButton_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            String SendButton = ((System.Windows.Forms.Button)sender).Name;
                    foreach (var path in dlg.FileNames)
                    {
                        DataRow NewRow;
                        NewRow = MusicFilesInfo.Tables[0].NewRow();
                        NewRow[0] = "";
                        NewRow[1] = "";
                        NewRow[2] = path;
                        MusicFilesInfo.Tables[0].Rows.Add(NewRow);
                        MusicFilesInfo.Tables[0].AcceptChanges();
                    }
            dataGridMusic.Refresh();
            }
        private void ARDConnectionButton_Click(object sender, EventArgs e)
        {
            if (SerialDevices.Text.CompareTo("") != 0)
            {
                try
                {
                    ARDCOMPORT = initialize_PORT(SerialDevices.Text);
                    ARDCOMPORT.Open();
                    Messages.Items.Add("Connected");
                    //Thread.Sleep(1);
                    //WriteToPort(ARDCOMPORT, "c");
                    //Thread.Sleep(1);
                    ReadFromPort(ARDCOMPORT);
                    // ReadFromPort(MotionPort);
                    //timer = new System.Timers.Timer(2000);
                    // Hook up the Elapsed event for the timer. 
                    //timer.Elapsed += sendArdDataSerial;
                    //timer.AutoReset = true;
                    //timer.Enabled = true;
                    SerialDevices.Enabled = false;
                }
                catch (Exception Ex)
                {
                    Messages.Items.Add(Ex.ToString());
                }
            }
            else
            {
                Messages.Items.Add("Please Select port");
            }
        }
        void sendDmxDataSerial()
        {
            while (runThread)
            {
                try
                {

                    if (ProgressBarCycle.Value == 100)
                    {
                        ProgressBarCycle.Value = 0;
                    }
                    else
                    {
                        ProgressBarCycle.Value++;
                    }
                    if (COMPORT != null && COMPORT.IsOpen)
                    {

                        Thread.Sleep(1);
                        COMPORT.BreakState = false;
                        
                        COMPORT.Write(buffer, 0, buffer.Length);
                    }
                    if (ARDCOMPORT != null && ARDCOMPORT.IsOpen)
                    {
                        //WriteToPort(ARDCOMPORT, "c");
                        
                        ReadFromPort(ARDCOMPORT);


                    }
                    //LogBox.Items.Add(String.Format("DMXRange {0}", dmxRange));

                    Thread.Sleep(1);
                    COMPORT.BreakState = true;
                    


                }
                catch
                {

                }
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (InfoSendDmx != null)
            {
                try
                {
                    runThread = false;
                    InfoSendDmx.Abort();
                }
                catch { }
            }
            if (COMPORT != null && COMPORT.IsOpen)
            {
                {
                    COMPORT.Close();
                }
            }
            if (ARDCOMPORT != null && COMPORT.IsOpen)
            {
                {
                    ARDCOMPORT.Close();
                }
            }
        }

        private void DMXConnection_Click(object sender, EventArgs e)
        {
            if (InfoSendDmx != null)
            {
                runThread = false;
                InfoSendDmx.Abort();
            }
            COMPORT = new SerialPort();
            //COMPORT.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            buffer[0] = 0;
            COMPORT.PortName = SerialDevicesDMX.Text;
            COMPORT.BaudRate = 250000;
            //COMPORT.BaudRate = 115200;
            COMPORT.ReadTimeout = 1;
            COMPORT.WriteTimeout = 2;
            COMPORT.DtrEnable = true;
            //Thread.Sleep(100);
            COMPORT.Parity = System.IO.Ports.Parity.None;
            COMPORT.DataBits = 8;
            COMPORT.StopBits = System.IO.Ports.StopBits.Two;
            COMPORT.Handshake = Handshake.None;
            COMPORT.Open();
            InfoSendDmx = new Thread(sendDmxDataSerial);
            runThread = true;
            InfoSendDmx.Start();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            SerialDevicesDMX.Enabled = false;
        }
        public void SetByte(int index, byte value)
        {
            if (index < 0 || index > 511)
                throw new IndexOutOfRangeException("Index is not between 0 and 511");

            lock (this)
            {
                buffer[index+1] = value;
            }
        }
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            sender.ToString();
            if (!sceneLoad)
            {
                int channel = Convert.ToInt32(((System.Windows.Forms.TrackBar)sender).Name.Replace("trackBar", ""));
                sliderValues[channel - 1] = Convert.ToInt32(((System.Windows.Forms.TrackBar)sender).Value);
                ((System.Windows.Forms.DomainUpDown)this.Controls.Find(string.Format("domainUpDown{0}", channel), true).FirstOrDefault()).Text = ((System.Windows.Forms.TrackBar)sender).Value.ToString();
                for (int i = 0; i < DMX_MAX_FIXTURES; i++)
                {
                    if (FixtureComboBox.Text.CompareTo("All Fixtures") ==0)
                    {
                        if (dmxFixtures.DMXfixtureList[i].fixture_enabled)
                        {
                            if (!dmxFixtures.DMXfixtureList[i].isIndividual)
                            {
                                dmxFixtures.DMXfixtureList[i].Channels[channel - 1] = Convert.ToInt32(((System.Windows.Forms.TrackBar)sender).Value);
                                SetByte((i * 16) + (channel - 1), Convert.ToByte(((System.Windows.Forms.TrackBar)sender).Value));
                                LogBox.Items.Add(String.Format("Channel: {0} Fixture:{1}", channel, i * 16 + 1));
                                sliderValuesMaster[channel - 1] = Convert.ToInt32(((System.Windows.Forms.TrackBar)sender).Value);
                            }
                        }
                    }
                    else
                    {
                        if (FixtureComboBox.Text.CompareTo((i + 1).ToString()) == 0)
                        {
                            if (dmxFixtures.DMXfixtureList[i].fixture_enabled)
                            {
                                dmxFixtures.DMXfixtureList[i].isIndividual = true;
                                dmxFixtures.DMXfixtureList[i].Channels[channel - 1] = Convert.ToInt32(((System.Windows.Forms.TrackBar)sender).Value);
                                SetByte((i * 16) + (channel - 1), Convert.ToByte(((System.Windows.Forms.TrackBar)sender).Value));
                                LogBox.Items.Add(String.Format("Channel: {0} Fixture:{1}", channel, i * 16 + 1));
                            }
                            break;
                        }
                    }
                }
            }
            LogBox.SelectedIndex = LogBox.Items.Count - 1;
            ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
            autoSave(ActiveProject);
        }
        private void bringUpScene(String Scene)
        {
            if (ActiveProject.Scenes.ContainsKey(Scene))
            {
                sceneLoad = true;
                dmxFixtures.DMXfixtureList = DMXandARDHelpers.Clone(ActiveProject.Scenes[Scene].DeepCopy().DMXfixtureList);
                int Fixtureindex = 1;
                FixtureComboBox.Items.Clear();
                FixtureComboBox.Items.Add("All Fixtures");
                FixtureComboBox.SelectedIndex = FixtureComboBox.Items.IndexOf("All Fixtures");
                bringUpFixture("All Fixtures");
                foreach (DMXfixture Fixture in ActiveProject.Scenes[Scene].DMXfixtureList)
                {
                    //LogBox.Items.Add(String.Format("Fixture Index {0}", Fixtureindex));
                    //LogBox.SelectedIndex = LogBox.Items.Count - 1;
                    
                    if (Fixture.fixture_enabled)
                    {
                        if (!FixtureComboBox.Items.Contains(Fixtureindex.ToString()))
                        {
                            FixtureComboBox.Items.Add(Fixtureindex.ToString());
                        }

                    }
                    ++Fixtureindex;
                }
            }
            ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
            sceneLoad = false;
            autoSave(ActiveProject);
        }
        private void bringUpFixture(String SelectedFixture)
        {
            if (SceneSelection.Text.CompareTo("") != 0)
            {
                sceneLoad = true;
                dmxFixtures.DMXfixtureList = DMXandARDHelpers.Clone(ActiveProject.Scenes[SceneSelection.Text].DeepCopy().DMXfixtureList);
                int Fixtureindex = 1;
                foreach (DMXfixture Fixture in ActiveProject.Scenes[SceneSelection.Text].DMXfixtureList)
                {
                    //LogBox.Items.Add(String.Format("Fixture Index {0}", Fixtureindex));
                    //LogBox.SelectedIndex = LogBox.Items.Count - 1;
                    if (SelectedFixture.CompareTo(Fixtureindex.ToString()) == 0)
                    {
                        if (!Fixture.fixture_enabled)
                        {

                            ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.Snow;

                            for (int i = 0; i < DMX_MAX_CHANNELS; i++)
                            {
                                SetByte(((Fixtureindex - 1) * 16) + (i), 0);
                            }
                        }
                        else
                        {
                            Fixture.isIndividual = true;
                            ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).Enabled = false;
                            ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.Green;
                                for (int i = 0; i < DMX_MAX_CHANNELS; i++)
                                {
                                    ((System.Windows.Forms.TrackBar)this.Controls.Find(string.Format("trackBar{0}", i + 1), true).FirstOrDefault()).Value = Fixture.Channels[i];
                                    SetByte(((Fixtureindex - 1) * 16) + (i), Convert.ToByte(Fixture.Channels[i]));
                                    if (Fixture.Channels[i] != 0)
                                    {
                                        LogBox.Items.Add(String.Format("Channel {0}:{1}", i, Fixture.Channels[i]));
                                        LogBox.SelectedIndex = LogBox.Items.Count - 1;

                                    }
                                }
                           
                        }
                    }
                    else
                    {
                        if (SelectedFixture.CompareTo("All Fixtures") == 0)
                        {
                            if (Fixture.isIndividual)
                            {
                                if (Fixture.fixture_enabled)
                                {
                                    ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.DarkGray;
                                }
                                else
                                {
                                    ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.Snow;
                                }
                            }
                            else
                            {
                                if (Fixture.fixture_enabled)
                                {
                                    ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.Green;
                                    for (int i = 0; i < DMX_MAX_CHANNELS; i++)
                                    {
                                        ((System.Windows.Forms.TrackBar)this.Controls.Find(string.Format("trackBar{0}", i + 1), true).FirstOrDefault()).Value = Fixture.Channels[i];
                                        SetByte(((Fixtureindex - 1) * 16) + (i), Convert.ToByte(Fixture.Channels[i]));
                                        if (Fixture.Channels[i] != 0)
                                        {
                                            LogBox.Items.Add(String.Format("Channel {0}:{1}", i, Fixture.Channels[i]));
                                            LogBox.SelectedIndex = LogBox.Items.Count - 1;

                                        }
                                    }
                                }
                                else
                                {
                                    ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.Snow;
                                }
                            }
                            ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).Enabled = true;
                        }
                        else
                        {
                            if (Fixture.fixture_enabled)
                            {
                                ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.DarkGray;
                            }
                            else
                            {
                                ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).BackColor = Color.Snow;
                            }
                            ((System.Windows.Forms.Button)this.Controls.Find(string.Format("fixtureButton{0}", Fixtureindex), true).FirstOrDefault()).Enabled = false;
                        }
                        for (int i = 0; i < DMX_MAX_CHANNELS; i++)
                        {
                            SetByte(((Fixtureindex - 1) * 16) + (i), Convert.ToByte(Fixture.Channels[i]));
                        }
                    }
                    ++Fixtureindex;
                }
                sceneLoad = false;
                ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
                autoSave(ActiveProject);
            }
        }
        private void Scene_ValueChanged(object sender, EventArgs e)
        {
            sceneLoad = true;
            String SendScene = ((System.Windows.Forms.ComboBox)sender).Text;
            LogBox.Items.Add(String.Format("Selected Scene {0}",SendScene));
            LogBox.SelectedIndex = LogBox.Items.Count - 1;
            bringUpScene(SendScene);
            sceneLoad = false;
        }
        private void Fixture_ValueChanged(object sender, EventArgs e)
        {
            if (!sceneLoad)
            {
                sceneLoad = true;
            String SendFixture = ((System.Windows.Forms.ComboBox)sender).Text;
            LogBox.Items.Add(String.Format("Selected Fixture {0}", SendFixture));
            LogBox.SelectedIndex = LogBox.Items.Count - 1;
            bringUpFixture(SendFixture);
                sceneLoad = false;
            }
        }
        private DMXARDproject getConfigFileDMX(String FileName)
        {
            DMXARDproject DMX = new DMXARDproject();
            return DMX;
        }
            private void SetAllButton_Click(object sender, EventArgs e)
        {
            String SendButton = ((System.Windows.Forms.Button)sender).Name;
            switch (SendButton)
            {
                case "SetMinButton":
                    for (int i = 1;i <= DMX_MAX_CHANNELS;++i)
                    {
                        ((System.Windows.Forms.TrackBar)this.Controls.Find(string.Format("trackBar{0}", i), true).FirstOrDefault()).Value = 0;
                    }
                    break;
                case "SetMaxButton":
                    for (int i = 1; i <= DMX_MAX_CHANNELS; ++i)
                    {
                        ((System.Windows.Forms.TrackBar)this.Controls.Find(string.Format("trackBar{0}", i), true).FirstOrDefault()).Value = 255;
                    }
                    break;
                case "SetAllRandom":
                    for (int i = 1; i <= DMX_MAX_CHANNELS; ++i)
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(0, 256);
                        ((System.Windows.Forms.TrackBar)this.Controls.Find(string.Format("trackBar{0}", i), true).FirstOrDefault()).Value= randomNumber;
                    }
                    break;
            }
            ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
            autoSave(ActiveProject);
        }
        private void SaveScene_Click(object sender, EventArgs e)
        {

            String SendButton = ((System.Windows.Forms.Button)sender).Name;
            switch (SendButton)
            {
                case "SaveMergeScene":
                    if(SceneSelection.Text.CompareTo("")==0)
                    {
                        using (Form ConfirmDialog = new ConfirmDialog())
                        {
                            ConfirmDialog.ShowDialog(this);
                        }
                    }
                    else
                    {
                        //Scene Merge
                        using (Form ConfirmDialog = new ConfirmDialog("Ok to Merge " + SceneSelection.Text + "?"))
                        {
                            var result = ConfirmDialog.ShowDialog(this);
                            if (result == DialogResult.OK)
                            {
                                //Perform Merge
                                if (ActiveProject.Scenes.ContainsKey(SceneSelection.Text) && SceneSelection.Text.CompareTo("(AutoSaveScene)") != 0)
                                {
                                    ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
                                    int index = 0;
                                    foreach (DMXfixture FixtureMerg in ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList)
                                    {
                                        if (FixtureMerg.fixture_enabled)
                                        {
                                            ActiveProject.Scenes[SceneSelection.Text].DMXfixtureList[index].fixture_enabled = true;
                                            ActiveProject.Scenes[SceneSelection.Text].DMXfixtureList[index].Channels = FixtureMerg.Channels;
                                        }
                                        ++index;
                                    }
                                    sceneLoad = true;
                                    LogBox.Items.Add(String.Format("Selected Scene {0}", SceneSelection.Text));
                                    LogBox.SelectedIndex = LogBox.Items.Count - 1;
                                    bringUpScene(SceneSelection.Text);
                                    sceneLoad = false;
                                }
                            }
                        }
                    }
                    break;
                case "OverwriteScene":
                    if (SceneSelection.Text.CompareTo("") == 0)
                    {
                        using (Form ConfirmDialog = new ConfirmDialog())
                        {
                            ConfirmDialog.ShowDialog(this);
                        }
                    }
                    else
                    {
                        using (Form ConfirmDialog = new ConfirmDialog("Ok to Overwrite "+ SceneSelection.Text+"?"))
                        {
                            var result = ConfirmDialog.ShowDialog(this);
                            if (result == DialogResult.OK)
                            {
                                //Perform Overwrite
                                if (ActiveProject.Scenes.ContainsKey(SceneSelection.Text) && SceneSelection.Text.CompareTo("(AutoSaveScene)") != 0)
                                {
                                    ActiveProject.Scenes[SceneSelection.Text].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
                                }
                                sceneLoad = true;
                                LogBox.Items.Add(String.Format("Selected Scene {0}", SceneSelection.Text));
                                LogBox.SelectedIndex = LogBox.Items.Count - 1;
                                bringUpScene(SceneSelection.Text);
                                sceneLoad = false;
                            }
                        }
                    }
                    break;
                case "SaveNewScene":
                    using (sceneSaveDialog = new SceneSaveDialog())
                    {
                        if (sceneSaveDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            //Perform Save

                            string Scene = sceneSaveDialog.SceneNameReturn;
                            if(ActiveProject.Scenes.ContainsKey(Scene))
                            {
                                String holder = DateTime.Now.ToFileTime().ToString();
                                ActiveProject.Scenes.Add(Scene+"~"+holder, new DMXFixtures());
                                ActiveProject.Scenes[Scene+"~"+holder].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
                            }
                            else
                            {
                                ActiveProject.Scenes.Add(Scene, new DMXFixtures());
                                ActiveProject.Scenes[Scene].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
                            }
                            
                        }
                    }
                    break;
                case "DeleteSelected":
                    if (SceneSelection.Text.CompareTo("") != 0)
                    {
                        using (Form ConfirmDialog = new ConfirmDialog("Ok to Delete " + SceneSelection.Text + "?"))
                        {
                            var result = ConfirmDialog.ShowDialog(this);
                            if (ActiveProject.Scenes.ContainsKey(SceneSelection.Text) && SceneSelection.Text.CompareTo("(AutoSaveScene)") !=0)
                            {
                                ActiveProject.Scenes.Remove(SceneSelection.Text);
                            }
                            sceneLoad = true;
                            LogBox.Items.Add(String.Format("Selected Scene {0}", "(AutoSaveScene)"));
                            LogBox.SelectedIndex = LogBox.Items.Count - 1;
                            bringUpScene("(AutoSaveScene)");
                            sceneLoad = false;
                        }
                    }
                    else
                    {
                        using (Form ConfirmDialog = new ConfirmDialog())
                        {
                            ConfirmDialog.ShowDialog(this);
                        }
                    }
                    break;
            }

            ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList = DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
            autoSave(ActiveProject);
        }

        private void FixtureButton_Click(object sender, EventArgs e)
        {
            int Fixtureindex = Convert.ToInt32(((System.Windows.Forms.Button)sender).Text);
            if (((System.Windows.Forms.Button)sender).BackColor == Color.Green)
            {
                ((System.Windows.Forms.Button)sender).BackColor =Color.Snow;

                dmxFixtures.DMXfixtureList[Fixtureindex-1].fixture_enabled = false;
                
                for (int i = 0; i < DMX_MAX_CHANNELS; i++)
                {
                    dmxFixtures.DMXfixtureList[Fixtureindex - 1].Channels[i]=0;
                    SetByte(((Fixtureindex-1) * 16) + (i ), 0);
                }
                if(FixtureComboBox.Items.Contains(Fixtureindex.ToString()))
                {
                    FixtureComboBox.Items.Remove(Fixtureindex.ToString());
                    if (FixtureComboBox.Text.CompareTo(Fixtureindex.ToString())==0)
                    {
                        FixtureComboBox.SelectedIndex = 0;
                    }
                }
                
            }
            else if (((System.Windows.Forms.Button)sender).BackColor == Color.DarkGray)
            {
                ((System.Windows.Forms.Button)sender).BackColor = Color.Green;
                dmxFixtures.DMXfixtureList[Fixtureindex - 1].fixture_enabled = true;
                for (int i = 0; i < DMX_MAX_CHANNELS; i++)
                {
                    dmxFixtures.DMXfixtureList[Fixtureindex - 1].isIndividual = false;
                    dmxFixtures.DMXfixtureList[Fixtureindex - 1].Channels[i] = sliderValuesMaster[i];
                    SetByte(((Fixtureindex - 1) * 16) + (i), Convert.ToByte(sliderValues[i]));
                }
                if (!FixtureComboBox.Items.Contains(Fixtureindex.ToString()))
                {
                    FixtureComboBox.Items.Add(Fixtureindex.ToString());
                }
            }
            else
            {
                ((System.Windows.Forms.Button)sender).BackColor = Color.Green;
                dmxFixtures.DMXfixtureList[Fixtureindex - 1].fixture_enabled = true;
                for (int i = 0; i < DMX_MAX_CHANNELS; i++)
                {
                    dmxFixtures.DMXfixtureList[Fixtureindex - 1].isIndividual = false;
                    dmxFixtures.DMXfixtureList[Fixtureindex - 1].Channels[i] = sliderValues[i];
                    SetByte(((Fixtureindex-1) * 16) + (i ), Convert.ToByte(sliderValues[i]));
                }
                if (!FixtureComboBox.Items.Contains(Fixtureindex.ToString()))
                {
                    FixtureComboBox.Items.Add(Fixtureindex.ToString());
                }
            }
            ActiveProject.Scenes["(AutoSaveScene)"].DMXfixtureList= DMXandARDHelpers.Clone(dmxFixtures.DeepCopy().DMXfixtureList);
            autoSave(ActiveProject);
        }
        private void LoadSave_Click(object sender, EventArgs e)
        {
            //buttonLoadConfig
            //buttonSaveConfig
            var dlg = new OpenFileDialog();
            dlg.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() != DialogResult.OK)
            return;
            String SendButton = ((System.Windows.Forms.Button)sender).Name;
            switch (SendButton)
            {
                case "buttonLoadConfig":
                    
                        foreach (var path in dlg.FileNames)
                        {
                            StreamReader sr = new StreamReader(path);
                            string jsonData = sr.ReadToEnd();
                            ActiveProject = new DMXARDproject();
                            ActiveProject = JsonSerializer.Deserialize<DMXARDproject>(jsonData);
                            bringUpScene("(AutoSaveScene)");
                            return;
                        }
                    break;
                case "buttonSaveConfig":
                        foreach (var path in dlg.FileNames)
                        {
                            streamAutoSave = new StreamWriter(path, false);
                            var options = new JsonSerializerOptions { WriteIndented = true };
                            string jsonString = JsonSerializer.Serialize<DMXARDproject>(ActiveProject, options);
                            streamAutoSave.WriteLine(jsonString);
                            streamAutoSave.Close();
                            return;
                        }
                    break;
            }
        }

    }
}
