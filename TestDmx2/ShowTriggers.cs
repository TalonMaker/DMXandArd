using DMXandArd.Models;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public ShowTriggers(DMXandARD activeProject)
        {
            InitializeComponent();
            _parent = activeProject;
            comboBoxArdTriggerValue.SelectedIndex = 0;
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
            String SceneText = comboBoxScene.Text;
            int index = 1;
            while (treeViewShow.Nodes.ContainsKey(SceneText))
            {
                SceneText = SceneText + "-" + index.ToString();
                ++index;
            }
            _showConfig.Add(SceneText, new showEvents());
            treeViewShow.Nodes.Add(_showConfig[SceneText].createTreeNew(SceneText));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
