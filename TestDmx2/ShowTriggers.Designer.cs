namespace DMXandArd
{
    partial class ShowTriggers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTriggers));
            treeViewShow = new System.Windows.Forms.TreeView();
            buttonRunShow = new System.Windows.Forms.Button();
            groupBoxMusic = new System.Windows.Forms.GroupBox();
            addSelectedSoundtoSelectedTrigger = new System.Windows.Forms.Button();
            buttonPlaySample = new System.Windows.Forms.Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            dataGridMusic = new System.Windows.Forms.DataGridView();
            buttonAddSelectedtoScene = new System.Windows.Forms.Button();
            groupBoxSceneSelector = new System.Windows.Forms.GroupBox();
            addsceneToQueue = new System.Windows.Forms.Button();
            ShowSceneButton = new System.Windows.Forms.Button();
            comboBoxScene = new System.Windows.Forms.ComboBox();
            buttonRunFromSelected = new System.Windows.Forms.Button();
            buttonStopShow = new System.Windows.Forms.Button();
            groupBoxTreeControls = new System.Windows.Forms.GroupBox();
            buttonEditTrigger = new System.Windows.Forms.Button();
            groupBoxArd = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBoxArdTriggerValue = new System.Windows.Forms.ComboBox();
            addArdtoSelectedTrigger = new System.Windows.Forms.Button();
            dataGridARD = new System.Windows.Forms.DataGridView();
            buttonMoveTriggerDown = new System.Windows.Forms.Button();
            buttonMoveTriggerUp = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            setStartMarker = new System.Windows.Forms.Button();
            setEndMarker = new System.Windows.Forms.Button();
            addSoundOnly = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textBoxStartSoundAt = new System.Windows.Forms.TextBox();
            textBoxEndSoundAt = new System.Windows.Forms.TextBox();
            groupBoxMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMusic).BeginInit();
            groupBoxSceneSelector.SuspendLayout();
            groupBoxTreeControls.SuspendLayout();
            groupBoxArd.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridARD).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewShow
            // 
            treeViewShow.FullRowSelect = true;
            treeViewShow.Location = new System.Drawing.Point(601, 114);
            treeViewShow.Name = "treeViewShow";
            treeViewShow.Size = new System.Drawing.Size(536, 503);
            treeViewShow.TabIndex = 0;
            // 
            // buttonRunShow
            // 
            buttonRunShow.Location = new System.Drawing.Point(790, 623);
            buttonRunShow.Name = "buttonRunShow";
            buttonRunShow.Size = new System.Drawing.Size(187, 43);
            buttonRunShow.TabIndex = 1;
            buttonRunShow.Text = "Run Entire Show";
            buttonRunShow.UseVisualStyleBackColor = true;
            // 
            // groupBoxMusic
            // 
            groupBoxMusic.Controls.Add(addSoundOnly);
            groupBoxMusic.Controls.Add(setEndMarker);
            groupBoxMusic.Controls.Add(setStartMarker);
            groupBoxMusic.Controls.Add(groupBox2);
            groupBoxMusic.Controls.Add(addSelectedSoundtoSelectedTrigger);
            groupBoxMusic.Controls.Add(buttonPlaySample);
            groupBoxMusic.Controls.Add(axWindowsMediaPlayer1);
            groupBoxMusic.Controls.Add(dataGridMusic);
            groupBoxMusic.Location = new System.Drawing.Point(13, 80);
            groupBoxMusic.Name = "groupBoxMusic";
            groupBoxMusic.Size = new System.Drawing.Size(582, 317);
            groupBoxMusic.TabIndex = 2;
            groupBoxMusic.TabStop = false;
            groupBoxMusic.Text = "Music";
            // 
            // addSelectedSoundtoSelectedTrigger
            // 
            addSelectedSoundtoSelectedTrigger.Location = new System.Drawing.Point(428, 225);
            addSelectedSoundtoSelectedTrigger.Name = "addSelectedSoundtoSelectedTrigger";
            addSelectedSoundtoSelectedTrigger.Size = new System.Drawing.Size(148, 45);
            addSelectedSoundtoSelectedTrigger.TabIndex = 5;
            addSelectedSoundtoSelectedTrigger.Text = "Add Sound to Selected Trigger";
            addSelectedSoundtoSelectedTrigger.UseVisualStyleBackColor = true;
            // 
            // buttonPlaySample
            // 
            buttonPlaySample.Location = new System.Drawing.Point(6, 148);
            buttonPlaySample.Name = "buttonPlaySample";
            buttonPlaySample.Size = new System.Drawing.Size(225, 29);
            buttonPlaySample.TabIndex = 2;
            buttonPlaySample.Text = "PlaySample";
            buttonPlaySample.UseVisualStyleBackColor = true;
            buttonPlaySample.Click += MusicButton_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 183);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(225, 45);
            axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // dataGridMusic
            // 
            dataGridMusic.AllowUserToAddRows = false;
            dataGridMusic.AllowUserToDeleteRows = false;
            dataGridMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMusic.Location = new System.Drawing.Point(6, 14);
            dataGridMusic.Name = "dataGridMusic";
            dataGridMusic.ReadOnly = true;
            dataGridMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridMusic.ShowCellErrors = false;
            dataGridMusic.ShowEditingIcon = false;
            dataGridMusic.ShowRowErrors = false;
            dataGridMusic.Size = new System.Drawing.Size(565, 128);
            dataGridMusic.TabIndex = 0;
            // 
            // buttonAddSelectedtoScene
            // 
            buttonAddSelectedtoScene.Location = new System.Drawing.Point(228, 22);
            buttonAddSelectedtoScene.Name = "buttonAddSelectedtoScene";
            buttonAddSelectedtoScene.Size = new System.Drawing.Size(148, 55);
            buttonAddSelectedtoScene.TabIndex = 3;
            buttonAddSelectedtoScene.Text = "Add Selected to New Trigger";
            buttonAddSelectedtoScene.UseVisualStyleBackColor = true;
            // 
            // groupBoxSceneSelector
            // 
            groupBoxSceneSelector.Controls.Add(addsceneToQueue);
            groupBoxSceneSelector.Controls.Add(ShowSceneButton);
            groupBoxSceneSelector.Controls.Add(comboBoxScene);
            groupBoxSceneSelector.Location = new System.Drawing.Point(12, 8);
            groupBoxSceneSelector.Name = "groupBoxSceneSelector";
            groupBoxSceneSelector.Size = new System.Drawing.Size(583, 66);
            groupBoxSceneSelector.TabIndex = 3;
            groupBoxSceneSelector.TabStop = false;
            groupBoxSceneSelector.Text = "Scene Selector";
            // 
            // addsceneToQueue
            // 
            addsceneToQueue.Location = new System.Drawing.Point(373, 21);
            addsceneToQueue.Name = "addsceneToQueue";
            addsceneToQueue.Size = new System.Drawing.Size(148, 24);
            addsceneToQueue.TabIndex = 4;
            addsceneToQueue.Text = "Add selected to Queue";
            addsceneToQueue.UseVisualStyleBackColor = true;
            addsceneToQueue.Click += addsceneToQueue_Click;
            // 
            // ShowSceneButton
            // 
            ShowSceneButton.Location = new System.Drawing.Point(260, 21);
            ShowSceneButton.Name = "ShowSceneButton";
            ShowSceneButton.Size = new System.Drawing.Size(107, 23);
            ShowSceneButton.TabIndex = 1;
            ShowSceneButton.Text = "Preview Scene";
            ShowSceneButton.UseVisualStyleBackColor = true;
            ShowSceneButton.Click += ShowScenebutton_Click;
            // 
            // comboBoxScene
            // 
            comboBoxScene.FormattingEnabled = true;
            comboBoxScene.Location = new System.Drawing.Point(6, 22);
            comboBoxScene.Name = "comboBoxScene";
            comboBoxScene.Size = new System.Drawing.Size(248, 23);
            comboBoxScene.TabIndex = 0;
            // 
            // buttonRunFromSelected
            // 
            buttonRunFromSelected.Location = new System.Drawing.Point(601, 623);
            buttonRunFromSelected.Name = "buttonRunFromSelected";
            buttonRunFromSelected.Size = new System.Drawing.Size(183, 43);
            buttonRunFromSelected.TabIndex = 4;
            buttonRunFromSelected.Text = "Run Show from Selected";
            buttonRunFromSelected.UseVisualStyleBackColor = true;
            buttonRunFromSelected.Click += button1_Click;
            // 
            // buttonStopShow
            // 
            buttonStopShow.Location = new System.Drawing.Point(983, 623);
            buttonStopShow.Name = "buttonStopShow";
            buttonStopShow.Size = new System.Drawing.Size(154, 43);
            buttonStopShow.TabIndex = 5;
            buttonStopShow.Text = "Stop Show";
            buttonStopShow.UseVisualStyleBackColor = true;
            // 
            // groupBoxTreeControls
            // 
            groupBoxTreeControls.Controls.Add(buttonEditTrigger);
            groupBoxTreeControls.Controls.Add(buttonAddSelectedtoScene);
            groupBoxTreeControls.Location = new System.Drawing.Point(601, 17);
            groupBoxTreeControls.Name = "groupBoxTreeControls";
            groupBoxTreeControls.Size = new System.Drawing.Size(600, 91);
            groupBoxTreeControls.TabIndex = 6;
            groupBoxTreeControls.TabStop = false;
            groupBoxTreeControls.Text = "Show Tree Controls";
            // 
            // buttonEditTrigger
            // 
            buttonEditTrigger.Location = new System.Drawing.Point(382, 22);
            buttonEditTrigger.Name = "buttonEditTrigger";
            buttonEditTrigger.Size = new System.Drawing.Size(153, 55);
            buttonEditTrigger.TabIndex = 4;
            buttonEditTrigger.Text = "Edit Selected Trigger";
            buttonEditTrigger.UseVisualStyleBackColor = true;
            // 
            // groupBoxArd
            // 
            groupBoxArd.Controls.Add(groupBox1);
            groupBoxArd.Controls.Add(addArdtoSelectedTrigger);
            groupBoxArd.Controls.Add(dataGridARD);
            groupBoxArd.Location = new System.Drawing.Point(13, 403);
            groupBoxArd.Name = "groupBoxArd";
            groupBoxArd.Size = new System.Drawing.Size(582, 214);
            groupBoxArd.TabIndex = 7;
            groupBoxArd.TabStop = false;
            groupBoxArd.Text = "ArdruinoControls";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxArdTriggerValue);
            groupBox1.Location = new System.Drawing.Point(310, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(112, 49);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ard Trigger Value";
            // 
            // comboBoxArdTriggerValue
            // 
            comboBoxArdTriggerValue.FormattingEnabled = true;
            comboBoxArdTriggerValue.Items.AddRange(new object[] { "1", "0" });
            comboBoxArdTriggerValue.Location = new System.Drawing.Point(6, 20);
            comboBoxArdTriggerValue.Name = "comboBoxArdTriggerValue";
            comboBoxArdTriggerValue.Size = new System.Drawing.Size(96, 23);
            comboBoxArdTriggerValue.TabIndex = 7;
            // 
            // addArdtoSelectedTrigger
            // 
            addArdtoSelectedTrigger.Location = new System.Drawing.Point(428, 159);
            addArdtoSelectedTrigger.Name = "addArdtoSelectedTrigger";
            addArdtoSelectedTrigger.Size = new System.Drawing.Size(148, 45);
            addArdtoSelectedTrigger.TabIndex = 6;
            addArdtoSelectedTrigger.Text = "Add to Selected Trigger";
            addArdtoSelectedTrigger.UseVisualStyleBackColor = true;
            // 
            // dataGridARD
            // 
            dataGridARD.AllowUserToAddRows = false;
            dataGridARD.AllowUserToDeleteRows = false;
            dataGridARD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridARD.Location = new System.Drawing.Point(5, 15);
            dataGridARD.Name = "dataGridARD";
            dataGridARD.ReadOnly = true;
            dataGridARD.Size = new System.Drawing.Size(560, 138);
            dataGridARD.TabIndex = 0;
            // 
            // buttonMoveTriggerDown
            // 
            buttonMoveTriggerDown.Location = new System.Drawing.Point(1143, 366);
            buttonMoveTriggerDown.Name = "buttonMoveTriggerDown";
            buttonMoveTriggerDown.Size = new System.Drawing.Size(58, 55);
            buttonMoveTriggerDown.TabIndex = 5;
            buttonMoveTriggerDown.Text = "Move Trigger Down";
            buttonMoveTriggerDown.UseVisualStyleBackColor = true;
            // 
            // buttonMoveTriggerUp
            // 
            buttonMoveTriggerUp.Location = new System.Drawing.Point(1143, 305);
            buttonMoveTriggerUp.Name = "buttonMoveTriggerUp";
            buttonMoveTriggerUp.Size = new System.Drawing.Size(58, 55);
            buttonMoveTriggerUp.TabIndex = 9;
            buttonMoveTriggerUp.Text = "Move Trigger Up";
            buttonMoveTriggerUp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new System.Drawing.Point(237, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(185, 163);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sound Info";
            // 
            // setStartMarker
            // 
            setStartMarker.Location = new System.Drawing.Point(6, 230);
            setStartMarker.Name = "setStartMarker";
            setStartMarker.Size = new System.Drawing.Size(107, 40);
            setStartMarker.TabIndex = 7;
            setStartMarker.Text = "Set Start Sound Time";
            setStartMarker.UseVisualStyleBackColor = true;
            // 
            // setEndMarker
            // 
            setEndMarker.Location = new System.Drawing.Point(119, 230);
            setEndMarker.Name = "setEndMarker";
            setEndMarker.Size = new System.Drawing.Size(112, 40);
            setEndMarker.TabIndex = 8;
            setEndMarker.Text = "Set End Sound Time";
            setEndMarker.UseVisualStyleBackColor = true;
            // 
            // addSoundOnly
            // 
            addSoundOnly.Location = new System.Drawing.Point(428, 157);
            addSoundOnly.Name = "addSoundOnly";
            addSoundOnly.Size = new System.Drawing.Size(148, 45);
            addSoundOnly.TabIndex = 9;
            addSoundOnly.Text = "Add as Sound No Trigger";
            addSoundOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStartSoundAt);
            groupBox3.Location = new System.Drawing.Point(5, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(174, 58);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Start";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxEndSoundAt);
            groupBox4.Location = new System.Drawing.Point(6, 89);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(174, 51);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "End";
            // 
            // textBoxStartSoundAt
            // 
            textBoxStartSoundAt.Location = new System.Drawing.Point(6, 22);
            textBoxStartSoundAt.Name = "textBoxStartSoundAt";
            textBoxStartSoundAt.ReadOnly = true;
            textBoxStartSoundAt.Size = new System.Drawing.Size(118, 23);
            textBoxStartSoundAt.TabIndex = 0;
            // 
            // textBoxEndSoundAt
            // 
            textBoxEndSoundAt.Location = new System.Drawing.Point(5, 20);
            textBoxEndSoundAt.Name = "textBoxEndSoundAt";
            textBoxEndSoundAt.ReadOnly = true;
            textBoxEndSoundAt.Size = new System.Drawing.Size(118, 23);
            textBoxEndSoundAt.TabIndex = 1;
            // 
            // ShowTriggers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1216, 684);
            Controls.Add(buttonMoveTriggerUp);
            Controls.Add(buttonMoveTriggerDown);
            Controls.Add(groupBoxArd);
            Controls.Add(groupBoxTreeControls);
            Controls.Add(buttonStopShow);
            Controls.Add(buttonRunFromSelected);
            Controls.Add(groupBoxSceneSelector);
            Controls.Add(groupBoxMusic);
            Controls.Add(buttonRunShow);
            Controls.Add(treeViewShow);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShowTriggers";
            Text = "ShowTriggers";
            groupBoxMusic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMusic).EndInit();
            groupBoxSceneSelector.ResumeLayout(false);
            groupBoxTreeControls.ResumeLayout(false);
            groupBoxArd.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridARD).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeViewShow;
        private System.Windows.Forms.Button buttonRunShow;
        private System.Windows.Forms.GroupBox groupBoxMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.DataGridView dataGridMusic;
        private System.Windows.Forms.Button buttonAddSelectedtoScene;
        private System.Windows.Forms.Button buttonPlaySample;
        private System.Windows.Forms.GroupBox groupBoxSceneSelector;
        private System.Windows.Forms.Button buttonRunFromSelected;
        private System.Windows.Forms.ComboBox comboBoxScene;
        private System.Windows.Forms.Button buttonStopShow;
        private System.Windows.Forms.GroupBox groupBoxTreeControls;
        private System.Windows.Forms.Button buttonEditTrigger;
        private System.Windows.Forms.GroupBox groupBoxArd;
        private System.Windows.Forms.DataGridView dataGridARD;
        private System.Windows.Forms.Button buttonMoveTriggerDown;
        private System.Windows.Forms.Button buttonMoveTriggerUp;
        private System.Windows.Forms.Button ShowSceneButton;
        private System.Windows.Forms.Button addsceneToQueue;
        private System.Windows.Forms.Button addSelectedSoundtoSelectedTrigger;
        private System.Windows.Forms.ComboBox comboBoxArdTriggerValue;
        private System.Windows.Forms.Button addArdtoSelectedTrigger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setEndMarker;
        private System.Windows.Forms.Button setStartMarker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addSoundOnly;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxEndSoundAt;
        private System.Windows.Forms.TextBox textBoxStartSoundAt;
    }
}