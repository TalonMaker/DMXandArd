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
using System.Text;
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
        TreeNode active_node = new TreeNode();
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



        private void button1_Click(object sender, EventArgs e)
        {

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
            if (tempNode != null)
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
            if (tempNode != null)
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
            if (tempNode != null)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }
                foreach (DataGridViewRow RowData in dataGridMusic.SelectedRows)
                {
                    _showConfig[tempNode.Text].endTriggers.Add(new showTriggers { type = "SOUND", name = string.Format("{0} \r\n Start {1} End {2}", RowData.Cells[4].Value.ToString(), TimeSpan.FromSeconds(Convert.ToDouble(textBoxStartSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff"), TimeSpan.FromSeconds(Convert.ToDouble(textBoxEndSoundAt.Text)).ToString(@"hh\:mm\:ss\:fff")), value = textBoxEndSoundAt.Text, showInterupt = new List<string>() });
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
            if (tempNode != null)
            {
                while (tempNode.Level != 0)
                {
                    tempNode = tempNode.Parent;
                }
                foreach (DataGridViewRow RowData in dataGridARD.SelectedRows)
                {
                    if (comboBoxTriggerAtArd.Text.CompareTo("Start") == 0)
                    {
                        _showConfig[tempNode.Text].startTriggers.Add(new showTriggers { type = "ARD", name = string.Format("Port {0} \r\n Value {1}", RowData.Cells[0].Value.ToString(), comboBoxArdTriggerValue.Text), value = comboBoxArdTriggerValue.Text, showInterupt = new List<string>() });

                        _showConfig[tempNode.Text].addEventToTreeNode("Start Triggers", string.Format("Port {0} \r\n Value {1}", RowData.Cells[0].Value.ToString(), comboBoxArdTriggerValue.Text));
                    }
                    else
                    {
                        _showConfig[tempNode.Text].endTriggers.Add(new showTriggers { type = "ARD", name = string.Format("Port {0} \r\n Value {1}", RowData.Cells[0].Value.ToString(), comboBoxArdTriggerValue.Text), value = comboBoxArdTriggerValue.Text, showInterupt = new List<string>() });

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
        }

        private void trackBarRunTime_ValueChanged(object sender, EventArgs e)
        {
            textBoxRunTime.Text = TimeSpan.FromSeconds(Convert.ToDouble(trackBarRunTime.Value)).ToString(@"mm\:ss");
        }

        private void comboBoxScene_SelectedValueChanged(object sender, EventArgs e)
        {
            trackBarRunTime.Value = 0;
        }
    }
}
