using DMXandArd.Models;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDmx2;
using TestDmx2.Models;

namespace DMXandArd
{
    public partial class ShowTriggers : Form
    {
        public DMXARDproject ActiveProject;
        bool _isAlreadyPlaying;
        bool _loopPlaying;
        DMXandARD _parent;
        Dictionary<string, showEvents> _showConfig = new Dictionary<string, showEvents>();
        showEvents _currentEvent = new showEvents();
        TreeNode active_node = new TreeNode();
        bool musicEnd;
        bool sceneEnd;
        double runTimeMusic = 0;
        double runTimeScene = 0;
        bool eventStarted;
        bool firstStart = true;
        int startMusicIndex = 0;
        int startSceneIndex = 0;
        public ShowTriggers(DMXandARD activeProject)
        {
            InitializeComponent();
            _parent = activeProject;
            comboBoxArdTriggerValue.SelectedIndex = 0;
            comboBoxTriggerAtArd.SelectedIndex = 0;
            dataGridARD.AutoGenerateColumns = true;
            dataGridARD.DataSource = _parent.ArdInfo;
            dataGridARD.DataMember = "Config";
            dataGridARD.Refresh();
            dataGridMusic.AutoGenerateColumns = true;
            dataGridMusic.DataSource = _parent.MusicFilesInfo;
            dataGridMusic.DataMember = "MusicConfig";
            dataGridMusic.Refresh();
            foreach (String Key in _parent.ActiveProject.Scenes.Keys)
            {
                if (!comboBoxScene.Items.Contains(Key))
                {
                    comboBoxScene.Items.Add(Key);
                    comboBoxScene.SelectedIndex = comboBoxScene.Items.Count - 1;
                }
            }
            textBoxStartSoundAt.Text = "0";
            textBoxEndSoundAt.Text = "0";
            comboBoxEventsAddtoEvent.SelectedIndex = 0;
            //  public SerialPort COMPORT;
            //public SerialPort ARDCOMPORT;
            if (_parent.ARDCOMPORT == null)
            {
                _parent.initiateArdConnection();
            }
            if (_parent.COMPORT == null)
            {
                _parent.initiateDmxConnection();
            }

        }




        private void ShowScenebutton_Click(object sender, EventArgs e)
        {
            _parent.bringUpSceneAndSet(comboBoxScene.Text);
        }
        private void MusicButton_Click(object sender, EventArgs e)
        {

            String SendButton = ((System.Windows.Forms.Button)sender).Name;
            switch (SendButton)
            {
                case "buttonPlaySample":
                    foreach (DataGridViewRow RowData in dataGridMusic.SelectedRows)
                    {
                        //Messages.Items.Add(RowData.Cells[4].Value.ToString());
                        _isAlreadyPlaying = true;
                        //PlayerWindow.uiMode = "None";
                        axWindowsMediaPlayer1.URL = RowData.Cells[4].Value.ToString();
                        //Messages.SelectedIndex = Messages.Items.Count - 1;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        //axWindowsMediaPlayer1.Ctlcontrols.currentPosition

                    }
                    break;
            }

        }
        private void addsceneToQueue_Click(object sender, EventArgs e)
        {

            TreeNode tempNode = active_node;
            if (tempNode != null && tempNode.Text.CompareTo("") != 0)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }

                _showConfig[tempNode.Text].scenes.Add(new showScenes { Title = comboBoxScene.Text, runTimeMs = trackBarRunTime.Value * 1000 });
                _showConfig[tempNode.Text].addEventToTreeNode("Scenes", string.Format("{0} runtime ms {1}", comboBoxScene.Text, TimeSpan.FromSeconds(Convert.ToDouble(trackBarRunTime.Value)).ToString(@"mm\:ss")));
            }
        }
        private void addSoundOnly_Click(object sender, EventArgs e)
        {
            TreeNode tempNode = active_node;
            if (tempNode != null && tempNode.Text.CompareTo("") != 0)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }
                foreach (DataGridViewRow RowData in dataGridMusic.SelectedRows)
                {
                    _showConfig[tempNode.Text].sounds.Add(new showSounds { FilePath = RowData.Cells[4].Value.ToString(), Title = RowData.Cells[4].Value.ToString(), soundEnd = Convert.ToDouble(textBoxEndSoundAt.Text), soundStart = Convert.ToDouble(textBoxStartSoundAt.Text) });
                    _showConfig[tempNode.Text].addEventToTreeNode("Sounds", string.Format("{0} \r\n Start {1} End {2}", RowData.Cells[4].Value.ToString(), TimeSpan.FromSeconds(Convert.ToDouble(textBoxStartSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff"), TimeSpan.FromSeconds(Convert.ToDouble(textBoxEndSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff")));

                }
            }
        }

        private void dataGridMusic_SelectionChanged(object sender, EventArgs e)
        {
            textBoxStartSoundAt.Text = "0";
            textBoxEndSoundAt.Text = "0";
        }

        private void setStartMarker_Click(object sender, EventArgs e)
        {
            textBoxStartSoundAt.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
        }

        private void setEndMarker_Click(object sender, EventArgs e)
        {
            textBoxEndSoundAt.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
        }

        private void addSelectedSoundtoSelectedTrigger_Click(object sender, EventArgs e)
        {
            TreeNode tempNode = active_node;
            if (tempNode != null && tempNode.Text.CompareTo("") != 0)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }
                foreach (DataGridViewRow RowData in dataGridMusic.SelectedRows)
                {
                    _showConfig[tempNode.Text].endTriggers.Add(new showTriggers { type = "SOUND", name = string.Format("{0}", RowData.Cells[4].Value.ToString()), value = textBoxEndSoundAt.Text, showInterupt = new List<string>() });
                    _showConfig[tempNode.Text].sounds.Add(new showSounds { FilePath = RowData.Cells[4].Value.ToString(), Title = RowData.Cells[4].Value.ToString(), soundEnd = Convert.ToDouble(textBoxEndSoundAt.Text), soundStart = Convert.ToDouble(textBoxStartSoundAt.Text) });
                    _showConfig[tempNode.Text].addEventToTreeNode("Sounds", string.Format("{0} \r\n Start {1} End {2}", RowData.Cells[4].Value.ToString(), TimeSpan.FromSeconds(Convert.ToDouble(textBoxStartSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff"), TimeSpan.FromSeconds(Convert.ToDouble(textBoxEndSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff")));
                    //_showConfig[tempNode.Text].addEventToTreeNode("startTriggers", string.Format("{0} \r\n Start {1} End {2}", RowData.Cells[4].Value.ToString(), TimeSpan.FromSeconds(Convert.ToDouble(textBoxStartSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff"), TimeSpan.FromSeconds(Convert.ToDouble(textBoxEndSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff")));
                    _showConfig[tempNode.Text].addEventToTreeNode("End Triggers", string.Format("{0} \r\n Start {1} End {2}", RowData.Cells[4].Value.ToString(), TimeSpan.FromSeconds(Convert.ToDouble(textBoxStartSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff"), TimeSpan.FromSeconds(Convert.ToDouble(textBoxEndSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff")));
                }
            }
        }



        private void treeViewShow_Click(object sender, TreeViewEventArgs e)
        {
            TreeNode tempNode = e.Node;
            if (tempNode != null)
            {
                active_node = tempNode;

            }
        }

        private void addArdtoSelectedTrigger_Click(object sender, EventArgs e)
        {
            TreeNode tempNode = active_node;
            if (tempNode != null && tempNode.Text.CompareTo("") != 0)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }
                foreach (DataGridViewRow RowData in dataGridARD.SelectedRows)
                {
                    if (comboBoxTriggerAtArd.Text.CompareTo("Start") == 0)
                    {
                        _showConfig[tempNode.Text].startTriggers.Add(new showTriggers { type = "ARD", name = RowData.Cells[0].Value.ToString(), value = comboBoxArdTriggerValue.Text, showInterupt = new List<string>() });

                        _showConfig[tempNode.Text].addEventToTreeNode("Start Triggers", string.Format("Port {0} \r\n Value {1}", RowData.Cells[0].Value.ToString(), comboBoxArdTriggerValue.Text));
                    }
                    else
                    {
                        _showConfig[tempNode.Text].endTriggers.Add(new showTriggers { type = "ARD", name = RowData.Cells[0].Value.ToString(), value = comboBoxArdTriggerValue.Text, showInterupt = new List<string>() });

                        _showConfig[tempNode.Text].addEventToTreeNode("End Triggers", string.Format("Port {0} \r\n Value {1}", RowData.Cells[0].Value.ToString(), comboBoxArdTriggerValue.Text));
                    }
                }
            }
        }

        private void buttonAddNewEvent_Click(object sender, EventArgs e)
        {
            String SceneText = "Event";
            int index = 1;
            while (_showConfig.ContainsKey(SceneText))
            {
                SceneText = SceneText + "-" + index.ToString();
                ++index;
            }
            _showConfig.Add(SceneText, new showEvents());
            treeViewShow.Nodes.Add(_showConfig[SceneText].createTreeNew(SceneText));
            comboBoxEventsAddtoEvent.Items.Add(SceneText);
        }

        private void trackBarRunTime_ValueChanged(object sender, EventArgs e)
        {
            textBoxRunTime.Text = TimeSpan.FromSeconds(Convert.ToDouble(trackBarRunTime.Value)).ToString(@"mm\:ss");
        }

        private void comboBoxScene_SelectedValueChanged(object sender, EventArgs e)
        {
            trackBarRunTime.Value = 0;
        }

        private void buttonMoveEventUp_Click(object sender, EventArgs e)
        {
            TreeNode parent = active_node;
            TreeView view = active_node.TreeView;
            if (parent != null)
            {
                int index = parent.Nodes.IndexOf(active_node);
                if (index > 0)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index - 1, active_node);
                }
            }
            else if (active_node.TreeView.Nodes.Contains(active_node)) //root node
            {
                int index = view.Nodes.IndexOf(active_node);
                if (index > 0)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index - 1, active_node);
                }
            }
        }

        private void buttonMoveEventDown_Click(object sender, EventArgs e)
        {
            TreeNode parent = active_node;
            TreeView view = active_node.TreeView;
            if (parent != null)
            {
                int index = parent.Nodes.IndexOf(active_node);
                if (index < parent.Nodes.Count - 1)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index + 1, active_node);
                }
            }
            else if (view != null && view.Nodes.Contains(active_node)) //root node
            {
                int index = view.Nodes.IndexOf(active_node);
                if (index < view.Nodes.Count - 1)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index + 1, active_node);
                }
            }
        }

        private void buttonAddToNext_Click(object sender, EventArgs e)
        {
            //comboBoxEventsAddtoEvent.Text;
            TreeNode tempNode = active_node;
            if (tempNode != null && tempNode.Text.CompareTo("") != 0)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }

                _showConfig[tempNode.Text].nextEvent = new showScenes { Title = comboBoxEventsAddtoEvent.Text, runTimeMs = 0 };
                _showConfig[tempNode.Text].addEventToTreeNode("Next Event", string.Format("{0} runtime ms {1}", comboBoxEventsAddtoEvent.Text, TimeSpan.FromSeconds(Convert.ToDouble(0)).ToString(@"mm\:ss")));
            }
        }

        private void buttonAddAsInterupt_Click(object sender, EventArgs e)
        {
            TreeNode tempNode = active_node;
            if (tempNode != null && tempNode.Text.CompareTo("") != 0)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }

                _showConfig[tempNode.Text].interuptsEvents.Add(new showScenes { Title = comboBoxEventsAddtoEvent.Text, runTimeMs = 0 });
                _showConfig[tempNode.Text].addEventToTreeNode("Interupts Event if running", string.Format("{0} runtime ms {1}", comboBoxEventsAddtoEvent.Text, TimeSpan.FromSeconds(Convert.ToDouble(0)).ToString(@"mm\:ss")));
            }
        }

        private void buttonRunShow_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            groupBoxArd.Enabled = false;
            groupBoxMusic.Enabled = false;
            groupBoxSceneSelector.Enabled = false;
            groupBoxTreeControls.Enabled = false;
            buttonMoveEventDown.Enabled = false;
            buttonMoveEventUp.Enabled = false;
            buttonRunFromSelected.Enabled = false;
            buttonRunShow.Enabled = false;
            firstStart = true;
            _currentEvent = _showConfig.First().Value;
            _currentEvent.setRunning(true);
            timerShow.Enabled = true;
            timerShow.Start();
        }

        private void buttonStopShow_Click(object sender, EventArgs e)
        {
            timerShow.Stop();
            timerShow.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            groupBox6.Enabled = true;
            groupBox7.Enabled = true;
            groupBoxArd.Enabled = true;
            groupBoxMusic.Enabled = true;
            groupBoxSceneSelector.Enabled = true;
            groupBoxTreeControls.Enabled = true;
            buttonMoveEventDown.Enabled = true;
            buttonMoveEventUp.Enabled = true;
            buttonRunFromSelected.Enabled = true;
            buttonRunShow.Enabled = true;
            firstStart = true;
            foreach (KeyValuePair<string, showEvents> kvp in _showConfig)
            {
                kvp.Value.setRunning(false);
            }
            if (timerPlayMediaEnd.Enabled)
            {
                timerPlayMediaEnd.Stop();
                timerPlayMediaEnd.Enabled = false;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            if (timerScene.Enabled)
            {
                timerScene.Stop();
                timerScene.Enabled = false;
            }
        }

        private void buttonSaveShow_Click(object sender, EventArgs e)
        {
            StreamWriter streamAutoSave;
            var dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
            if (dlgSave.ShowDialog() != DialogResult.OK)
                return;
            foreach (var path in dlgSave.FileNames)
            {
                streamAutoSave = new StreamWriter(path, false);
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize<Dictionary<string, showEvents>>(_showConfig, options);
                streamAutoSave.WriteLine(jsonString);
                streamAutoSave.Close();
                return;
            }
        }

        private void buttonLoadShow_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
            dlg.Multiselect = false;
            comboBoxEventsAddtoEvent.Items.Clear();
            comboBoxEventsAddtoEvent.Items.Add("[END]");
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            treeViewShow.Nodes.Clear();
            foreach (var path in dlg.FileNames)
            {
                StreamReader sr = new StreamReader(path);
                string jsonData = sr.ReadToEnd();
                _showConfig = new Dictionary<string, showEvents>();
                _showConfig = JsonSerializer.Deserialize<Dictionary<string, showEvents>>(jsonData);
                foreach (KeyValuePair<string, showEvents> events in _showConfig)
                {
                    _showConfig[events.Key].createTreeNewNoDict(events.Key);
                    _showConfig[events.Key].rebuildTreeNodes();
                    
                    treeViewShow.Nodes.Add(_showConfig[events.Key].treeNodeEvents);
                    comboBoxEventsAddtoEvent.Items.Add(events.Key);
                }
                sr.Close();
            }
        }

        private void buttonRunFromSelected_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            groupBoxArd.Enabled = false;
            groupBoxMusic.Enabled = false;
            groupBoxSceneSelector.Enabled = false;
            groupBoxTreeControls.Enabled = false;
            buttonMoveEventDown.Enabled = false;
            buttonMoveEventUp.Enabled = false;
            buttonRunFromSelected.Enabled = false;
            buttonRunShow.Enabled = false;
            firstStart = true;
            _currentEvent = _showConfig[active_node.Name];
            _currentEvent.setRunning(true);
            timerShow.Enabled = true;
            timerShow.Start();

        }
        bool changeStateEvalEnd()
        {
            if (_currentEvent.endTriggers.Count == 0)
            {
                return true;
            }
            foreach (showTriggers TriggersEnd in _currentEvent.endTriggers)
            {
                switch (TriggersEnd.type)
                {
                    case "ARD":
                        DataRow[] tempRows = _parent.ActiveProject.getArdData().Select(string.Format("PortNumber={0}", TriggersEnd.name));
                        if (tempRows.Length > 0)
                        {
                            if (tempRows[0][2].ToString().CompareTo(TriggersEnd.value) == 0)
                            {
                                return true;
                            }
                        }
                        //dataGridARD
                        //if (TriggersEnd.value==)
                        //{

                        //}
                        break;
                    case "SOUND":
                        if (TriggersEnd.name == axWindowsMediaPlayer1.URL && musicEnd)
                        {
                            return true;
                        }
                        break;
                    default:
                        break;
                }
            }
            return false;
        }
        bool changeStateEvalStart()
        {
            if (_currentEvent.startTriggers.Count == 0)
            {
                return true;
            }
            foreach (showTriggers TriggersStart in _currentEvent.startTriggers)
            {
                switch (TriggersStart.type)
                {
                    case "ARD":
                        DataRow[] tempRows = _parent.ActiveProject.getArdData().Select(string.Format("PortNumber={0}", TriggersStart.name));
                        if (tempRows.Length > 0)
                        {
                            if (tempRows[0][2].ToString().CompareTo(TriggersStart.value) == 0)
                            {
                                return true;
                            }
                        }
                        //dataGridARD
                        //if (TriggersEnd.value==)
                        //{

                        //}
                        break;
                    // case "SOUND":
                    // if (TriggersEnd.name == axWindowsMediaPlayer1.URL && musicEnd)
                    //{
                    //return true;
                    //}
                    //break;
                    default:
                        break;
                }
            }
            return false;
        }
        private void timerShow_Tick(object sender, EventArgs e)
        {
            if (changeStateEvalStart() || eventStarted)
            {
                eventStarted = true;
                if (changeStateEvalEnd())
                {
                    eventStarted = false;
                    startMusicIndex = 0;
                    startSceneIndex = 0;
                    if (_currentEvent.nextEvent == null)
                    {
                        _currentEvent.setRunning(false);
                        List<string> KeyList;
                        KeyList = _showConfig.Keys.ToList();
                        int index;
                        index = KeyList.IndexOf(_currentEvent.name);
                        if (index + 1 == _showConfig.Count())
                        {
                            _currentEvent = _showConfig.First().Value;
                            _currentEvent.setRunning(true);

                        }
                        else
                        {
                            _currentEvent = _showConfig[KeyList[index + 1]];
                            _currentEvent.setRunning(true);
                        }
                    }
                    else
                    {
                        _currentEvent.setRunning(false);
                        _currentEvent = _showConfig[_currentEvent.nextEvent.Title];
                        _currentEvent.setRunning(true);
                    }
                    if (timerPlayMediaEnd.Enabled)
                    {
                        timerPlayMediaEnd.Stop();
                        timerPlayMediaEnd.Enabled = false;
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                    }
                    if (timerScene.Enabled)
                    {
                        timerScene.Stop();
                        timerScene.Enabled = false;
                    }
                    if (_currentEvent.sounds.Count > 0)
                    {
                        musicEnd = false;
                        _isAlreadyPlaying = false;
                        timerPlayMediaEnd.Enabled = true;
                        timerPlayMediaEnd.Start();


                    }
                    if (_currentEvent.scenes.Count > 0)
                    {
                        sceneEnd = false;
                        timerScene.Enabled = true;
                        timerScene.Start();
                    }
                }
                //In a running event
                if(firstStart)
                {
                    startMusicIndex = 0;
                    startSceneIndex = 0;
                    firstStart = false;
                    if (timerPlayMediaEnd.Enabled)
                    {
                        timerPlayMediaEnd.Stop();
                        timerPlayMediaEnd.Enabled = false;
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                    }
                    if (timerScene.Enabled)
                    {
                        timerScene.Stop();
                        timerScene.Enabled = false;
                    }
                    if (_currentEvent.sounds.Count > 0)
                    {
                        musicEnd = false;
                        _isAlreadyPlaying = false;
                        timerPlayMediaEnd.Enabled = true;
                        timerPlayMediaEnd.Start();


                    }
                    if (_currentEvent.scenes.Count > 0)
                    {
                        sceneEnd = false;
                        timerScene.Enabled = true;
                        timerScene.Start();
                    }
                }
            }

        }

        private void timerPlayMediaEnd_Tick(object sender, EventArgs e)
        {
            //musicEnd;
            //double runTimeMusic = 0;
            //_isAlreadyPlaying = true;
            //axWindowsMediaPlayer1.URL = RowData.Cells[4].Value.ToString();
            //Messages.SelectedIndex = Messages.Items.Count - 1;
            //axWindowsMediaPlayer1timerPlayMediaEnd;
            //axWindowsMediaPlayer1.Ctlcontrols.currentPosition

            if(!_isAlreadyPlaying)
            {
                axWindowsMediaPlayer1.URL = _currentEvent.sounds[0].FilePath;
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = _currentEvent.sounds[startMusicIndex].soundStart;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                musicEnd = false;
            }
            else
            {
                if( _currentEvent.sounds[startMusicIndex].soundEnd>0.0)
                {
                    if(axWindowsMediaPlayer1.Ctlcontrols.currentPosition>= _currentEvent.sounds[startMusicIndex].soundEnd)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        musicEnd = true;
                        _isAlreadyPlaying = false;
                        if(changeStateEvalEnd())
                        {
                            timerPlayMediaEnd.Stop();
                            timerPlayMediaEnd.Enabled = false;
                        }
                    }

                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
                }
            }
        }
        
        private void timerScene_Tick(object sender, EventArgs e)
        {
            //sceneEnd;
            if (!sceneEnd)
            {
                _parent.bringUpSceneAndSet(_currentEvent.scenes[startSceneIndex].Title);
                sceneEnd = false;
            }
            else
            {
                if (_currentEvent.scenes[startSceneIndex].runTimeMs > 0.0)
                {
                    //add in future
                }
                sceneEnd = true;
            }
            //double runTimeScene = 0;
            //_parent.bringUpSceneAndSet(
            //_currentEvent.scenes[startMusicIndex].Title
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3 || e.newState == 9)
            {
                _isAlreadyPlaying = true;
            }
            else
            {
                _isAlreadyPlaying = false;
            }
        }
    }
}
