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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTriggers));
            treeViewShow = new System.Windows.Forms.TreeView();
            buttonRunShow = new System.Windows.Forms.Button();
            groupBoxMusic = new System.Windows.Forms.GroupBox();
            addSoundOnly = new System.Windows.Forms.Button();
            setEndMarker = new System.Windows.Forms.Button();
            setStartMarker = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textBoxEndSoundAt = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            textBoxStartSoundAt = new System.Windows.Forms.TextBox();
            addSelectedSoundtoSelectedTrigger = new System.Windows.Forms.Button();
            buttonPlaySample = new System.Windows.Forms.Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            dataGridMusic = new System.Windows.Forms.DataGridView();
            buttonAddToNext = new System.Windows.Forms.Button();
            groupBoxSceneSelector = new System.Windows.Forms.GroupBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            textBoxRunTime = new System.Windows.Forms.TextBox();
            trackBarRunTime = new System.Windows.Forms.TrackBar();
            addsceneToQueue = new System.Windows.Forms.Button();
            ShowSceneButton = new System.Windows.Forms.Button();
            comboBoxScene = new System.Windows.Forms.ComboBox();
            buttonRunFromSelected = new System.Windows.Forms.Button();
            buttonStopShow = new System.Windows.Forms.Button();
            groupBoxTreeControls = new System.Windows.Forms.GroupBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            comboBoxEventsAddtoEvent = new System.Windows.Forms.ComboBox();
            buttonAddAsInterupt = new System.Windows.Forms.Button();
            buttonAddNewEvent = new System.Windows.Forms.Button();
            groupBoxArd = new System.Windows.Forms.GroupBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            comboBoxTriggerAtArd = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBoxArdTriggerValue = new System.Windows.Forms.ComboBox();
            addArdtoSelectedTrigger = new System.Windows.Forms.Button();
            dataGridARD = new System.Windows.Forms.DataGridView();
            buttonMoveEventDown = new System.Windows.Forms.Button();
            buttonMoveEventUp = new System.Windows.Forms.Button();
            buttonSaveShow = new System.Windows.Forms.Button();
            buttonLoadShow = new System.Windows.Forms.Button();
            timerShow = new System.Windows.Forms.Timer(components);
            timerPlayMediaEnd = new System.Windows.Forms.Timer(components);
            timerScene = new System.Windows.Forms.Timer(components);
            groupBoxMusic.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMusic).BeginInit();
            groupBoxSceneSelector.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarRunTime).BeginInit();
            groupBoxTreeControls.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBoxArd.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridARD).BeginInit();
            SuspendLayout();
            // 
            // treeViewShow
            // 
            treeViewShow.FullRowSelect = true;
            treeViewShow.HideSelection = false;
            treeViewShow.Location = new System.Drawing.Point(601, 150);
            treeViewShow.Name = "treeViewShow";
            treeViewShow.Size = new System.Drawing.Size(536, 467);
            treeViewShow.TabIndex = 0;
            treeViewShow.AfterSelect += treeViewShow_Click;
            // 
            // buttonRunShow
            // 
            buttonRunShow.Location = new System.Drawing.Point(720, 623);
            buttonRunShow.Name = "buttonRunShow";
            buttonRunShow.Size = new System.Drawing.Size(187, 43);
            buttonRunShow.TabIndex = 1;
            buttonRunShow.Text = "Run Entire Show";
            buttonRunShow.UseVisualStyleBackColor = true;
            buttonRunShow.Click += buttonRunShow_Click;
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
            groupBoxMusic.Location = new System.Drawing.Point(13, 128);
            groupBoxMusic.Name = "groupBoxMusic";
            groupBoxMusic.Size = new System.Drawing.Size(582, 269);
            groupBoxMusic.TabIndex = 2;
            groupBoxMusic.TabStop = false;
            groupBoxMusic.Text = "Music";
            // 
            // addSoundOnly
            // 
            addSoundOnly.Location = new System.Drawing.Point(429, 125);
            addSoundOnly.Name = "addSoundOnly";
            addSoundOnly.Size = new System.Drawing.Size(148, 45);
            addSoundOnly.TabIndex = 9;
            addSoundOnly.Text = "Add as Sound No Trigger";
            addSoundOnly.UseVisualStyleBackColor = true;
            addSoundOnly.Click += addSoundOnly_Click;
            // 
            // setEndMarker
            // 
            setEndMarker.Location = new System.Drawing.Point(120, 198);
            setEndMarker.Name = "setEndMarker";
            setEndMarker.Size = new System.Drawing.Size(112, 40);
            setEndMarker.TabIndex = 8;
            setEndMarker.Text = "Set End Sound Time";
            setEndMarker.UseVisualStyleBackColor = true;
            setEndMarker.Click += setEndMarker_Click;
            // 
            // setStartMarker
            // 
            setStartMarker.Location = new System.Drawing.Point(7, 198);
            setStartMarker.Name = "setStartMarker";
            setStartMarker.Size = new System.Drawing.Size(107, 40);
            setStartMarker.TabIndex = 7;
            setStartMarker.Text = "Set Start Sound Time";
            setStartMarker.UseVisualStyleBackColor = true;
            setStartMarker.Click += setStartMarker_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new System.Drawing.Point(238, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(185, 150);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sound Info";
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
            // textBoxEndSoundAt
            // 
            textBoxEndSoundAt.Location = new System.Drawing.Point(5, 20);
            textBoxEndSoundAt.Name = "textBoxEndSoundAt";
            textBoxEndSoundAt.ReadOnly = true;
            textBoxEndSoundAt.Size = new System.Drawing.Size(118, 23);
            textBoxEndSoundAt.TabIndex = 1;
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
            // textBoxStartSoundAt
            // 
            textBoxStartSoundAt.Location = new System.Drawing.Point(6, 22);
            textBoxStartSoundAt.Name = "textBoxStartSoundAt";
            textBoxStartSoundAt.ReadOnly = true;
            textBoxStartSoundAt.Size = new System.Drawing.Size(118, 23);
            textBoxStartSoundAt.TabIndex = 0;
            // 
            // addSelectedSoundtoSelectedTrigger
            // 
            addSelectedSoundtoSelectedTrigger.Location = new System.Drawing.Point(429, 193);
            addSelectedSoundtoSelectedTrigger.Name = "addSelectedSoundtoSelectedTrigger";
            addSelectedSoundtoSelectedTrigger.Size = new System.Drawing.Size(148, 45);
            addSelectedSoundtoSelectedTrigger.TabIndex = 5;
            addSelectedSoundtoSelectedTrigger.Text = "Add Sound to Selected Trigger";
            addSelectedSoundtoSelectedTrigger.UseVisualStyleBackColor = true;
            addSelectedSoundtoSelectedTrigger.Click += addSelectedSoundtoSelectedTrigger_Click;
            // 
            // buttonPlaySample
            // 
            buttonPlaySample.Location = new System.Drawing.Point(7, 116);
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
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(7, 151);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(225, 45);
            axWindowsMediaPlayer1.TabIndex = 1;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            // 
            // dataGridMusic
            // 
            dataGridMusic.AllowUserToAddRows = false;
            dataGridMusic.AllowUserToDeleteRows = false;
            dataGridMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMusic.Location = new System.Drawing.Point(6, 22);
            dataGridMusic.MultiSelect = false;
            dataGridMusic.Name = "dataGridMusic";
            dataGridMusic.ReadOnly = true;
            dataGridMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridMusic.ShowCellErrors = false;
            dataGridMusic.ShowEditingIcon = false;
            dataGridMusic.ShowRowErrors = false;
            dataGridMusic.Size = new System.Drawing.Size(565, 88);
            dataGridMusic.TabIndex = 0;
            dataGridMusic.SelectionChanged += dataGridMusic_SelectionChanged;
            // 
            // buttonAddToNext
            // 
            buttonAddToNext.Location = new System.Drawing.Point(193, 52);
            buttonAddToNext.Name = "buttonAddToNext";
            buttonAddToNext.Size = new System.Drawing.Size(235, 33);
            buttonAddToNext.TabIndex = 3;
            buttonAddToNext.Text = "Add Selected to Next of other event";
            buttonAddToNext.UseVisualStyleBackColor = true;
            buttonAddToNext.Click += buttonAddToNext_Click;
            // 
            // groupBoxSceneSelector
            // 
            groupBoxSceneSelector.Controls.Add(groupBox6);
            groupBoxSceneSelector.Controls.Add(addsceneToQueue);
            groupBoxSceneSelector.Controls.Add(ShowSceneButton);
            groupBoxSceneSelector.Controls.Add(comboBoxScene);
            groupBoxSceneSelector.Location = new System.Drawing.Point(11, 17);
            groupBoxSceneSelector.Name = "groupBoxSceneSelector";
            groupBoxSceneSelector.Size = new System.Drawing.Size(583, 112);
            groupBoxSceneSelector.TabIndex = 3;
            groupBoxSceneSelector.TabStop = false;
            groupBoxSceneSelector.Text = "Scene Selector";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBoxRunTime);
            groupBox6.Controls.Add(trackBarRunTime);
            groupBox6.Location = new System.Drawing.Point(6, 47);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(571, 59);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Runtime Scene";
            // 
            // textBoxRunTime
            // 
            textBoxRunTime.Location = new System.Drawing.Point(491, 21);
            textBoxRunTime.Name = "textBoxRunTime";
            textBoxRunTime.ReadOnly = true;
            textBoxRunTime.Size = new System.Drawing.Size(74, 23);
            textBoxRunTime.TabIndex = 1;
            textBoxRunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarRunTime
            // 
            trackBarRunTime.Location = new System.Drawing.Point(3, 14);
            trackBarRunTime.Maximum = 300;
            trackBarRunTime.Name = "trackBarRunTime";
            trackBarRunTime.Size = new System.Drawing.Size(482, 45);
            trackBarRunTime.TabIndex = 0;
            trackBarRunTime.ValueChanged += trackBarRunTime_ValueChanged;
            // 
            // addsceneToQueue
            // 
            addsceneToQueue.Location = new System.Drawing.Point(429, 18);
            addsceneToQueue.Name = "addsceneToQueue";
            addsceneToQueue.Size = new System.Drawing.Size(148, 24);
            addsceneToQueue.TabIndex = 4;
            addsceneToQueue.Text = "Add selected to Event";
            addsceneToQueue.UseVisualStyleBackColor = true;
            addsceneToQueue.Click += addsceneToQueue_Click;
            // 
            // ShowSceneButton
            // 
            ShowSceneButton.Location = new System.Drawing.Point(260, 18);
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
            comboBoxScene.Location = new System.Drawing.Point(6, 18);
            comboBoxScene.Name = "comboBoxScene";
            comboBoxScene.Size = new System.Drawing.Size(248, 23);
            comboBoxScene.TabIndex = 0;
            comboBoxScene.SelectedValueChanged += comboBoxScene_SelectedValueChanged;
            // 
            // buttonRunFromSelected
            // 
            buttonRunFromSelected.Location = new System.Drawing.Point(531, 623);
            buttonRunFromSelected.Name = "buttonRunFromSelected";
            buttonRunFromSelected.Size = new System.Drawing.Size(183, 43);
            buttonRunFromSelected.TabIndex = 4;
            buttonRunFromSelected.Text = "Run Show from Selected";
            buttonRunFromSelected.UseVisualStyleBackColor = true;
            buttonRunFromSelected.Click += buttonRunFromSelected_Click;
            // 
            // buttonStopShow
            // 
            buttonStopShow.Location = new System.Drawing.Point(913, 623);
            buttonStopShow.Name = "buttonStopShow";
            buttonStopShow.Size = new System.Drawing.Size(154, 43);
            buttonStopShow.TabIndex = 5;
            buttonStopShow.Text = "Stop Show";
            buttonStopShow.UseVisualStyleBackColor = true;
            buttonStopShow.Click += buttonStopShow_Click;
            // 
            // groupBoxTreeControls
            // 
            groupBoxTreeControls.Controls.Add(groupBox7);
            groupBoxTreeControls.Controls.Add(buttonAddNewEvent);
            groupBoxTreeControls.Location = new System.Drawing.Point(601, 17);
            groupBoxTreeControls.Name = "groupBoxTreeControls";
            groupBoxTreeControls.Size = new System.Drawing.Size(600, 127);
            groupBoxTreeControls.TabIndex = 6;
            groupBoxTreeControls.TabStop = false;
            groupBoxTreeControls.Text = "Show Tree Controls";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(comboBoxEventsAddtoEvent);
            groupBox7.Controls.Add(buttonAddAsInterupt);
            groupBox7.Controls.Add(buttonAddToNext);
            groupBox7.Location = new System.Drawing.Point(160, 21);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new System.Drawing.Size(434, 91);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            groupBox7.Text = "Add to Event to Selected Event";
            // 
            // comboBoxEventsAddtoEvent
            // 
            comboBoxEventsAddtoEvent.FormattingEnabled = true;
            comboBoxEventsAddtoEvent.Items.AddRange(new object[] { "[END]" });
            comboBoxEventsAddtoEvent.Location = new System.Drawing.Point(6, 22);
            comboBoxEventsAddtoEvent.Name = "comboBoxEventsAddtoEvent";
            comboBoxEventsAddtoEvent.Size = new System.Drawing.Size(171, 23);
            comboBoxEventsAddtoEvent.TabIndex = 6;
            // 
            // buttonAddAsInterupt
            // 
            buttonAddAsInterupt.Location = new System.Drawing.Point(193, 12);
            buttonAddAsInterupt.Name = "buttonAddAsInterupt";
            buttonAddAsInterupt.Size = new System.Drawing.Size(235, 33);
            buttonAddAsInterupt.TabIndex = 4;
            buttonAddAsInterupt.Text = "Add Selected as Interuptable";
            buttonAddAsInterupt.UseVisualStyleBackColor = true;
            buttonAddAsInterupt.Click += buttonAddAsInterupt_Click;
            // 
            // buttonAddNewEvent
            // 
            buttonAddNewEvent.Location = new System.Drawing.Point(6, 22);
            buttonAddNewEvent.Name = "buttonAddNewEvent";
            buttonAddNewEvent.Size = new System.Drawing.Size(148, 55);
            buttonAddNewEvent.TabIndex = 5;
            buttonAddNewEvent.Text = "Add New Event";
            buttonAddNewEvent.UseVisualStyleBackColor = true;
            buttonAddNewEvent.Click += buttonAddNewEvent_Click;
            // 
            // groupBoxArd
            // 
            groupBoxArd.Controls.Add(groupBox5);
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
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBoxTriggerAtArd);
            groupBox5.Location = new System.Drawing.Point(190, 159);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(113, 49);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ard Trigger At";
            // 
            // comboBoxTriggerAtArd
            // 
            comboBoxTriggerAtArd.FormattingEnabled = true;
            comboBoxTriggerAtArd.Items.AddRange(new object[] { "Start", "End" });
            comboBoxTriggerAtArd.Location = new System.Drawing.Point(6, 20);
            comboBoxTriggerAtArd.Name = "comboBoxTriggerAtArd";
            comboBoxTriggerAtArd.Size = new System.Drawing.Size(96, 23);
            comboBoxTriggerAtArd.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxArdTriggerValue);
            groupBox1.Location = new System.Drawing.Point(309, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(113, 49);
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
            addArdtoSelectedTrigger.Click += addArdtoSelectedTrigger_Click;
            // 
            // dataGridARD
            // 
            dataGridARD.AllowUserToAddRows = false;
            dataGridARD.AllowUserToDeleteRows = false;
            dataGridARD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridARD.Location = new System.Drawing.Point(5, 15);
            dataGridARD.MultiSelect = false;
            dataGridARD.Name = "dataGridARD";
            dataGridARD.ReadOnly = true;
            dataGridARD.Size = new System.Drawing.Size(560, 138);
            dataGridARD.TabIndex = 0;
            // 
            // buttonMoveEventDown
            // 
            buttonMoveEventDown.Location = new System.Drawing.Point(1143, 366);
            buttonMoveEventDown.Name = "buttonMoveEventDown";
            buttonMoveEventDown.Size = new System.Drawing.Size(58, 55);
            buttonMoveEventDown.TabIndex = 5;
            buttonMoveEventDown.Text = "Move Event Down";
            buttonMoveEventDown.UseVisualStyleBackColor = true;
            buttonMoveEventDown.Click += buttonMoveEventDown_Click;
            // 
            // buttonMoveEventUp
            // 
            buttonMoveEventUp.Location = new System.Drawing.Point(1143, 305);
            buttonMoveEventUp.Name = "buttonMoveEventUp";
            buttonMoveEventUp.Size = new System.Drawing.Size(58, 55);
            buttonMoveEventUp.TabIndex = 9;
            buttonMoveEventUp.Text = "Move Event Up";
            buttonMoveEventUp.UseVisualStyleBackColor = true;
            buttonMoveEventUp.Click += buttonMoveEventUp_Click;
            // 
            // buttonSaveShow
            // 
            buttonSaveShow.Location = new System.Drawing.Point(13, 629);
            buttonSaveShow.Name = "buttonSaveShow";
            buttonSaveShow.Size = new System.Drawing.Size(131, 43);
            buttonSaveShow.TabIndex = 10;
            buttonSaveShow.Text = "Save Show";
            buttonSaveShow.UseVisualStyleBackColor = true;
            buttonSaveShow.Click += buttonSaveShow_Click;
            // 
            // buttonLoadShow
            // 
            buttonLoadShow.Location = new System.Drawing.Point(150, 629);
            buttonLoadShow.Name = "buttonLoadShow";
            buttonLoadShow.Size = new System.Drawing.Size(131, 43);
            buttonLoadShow.TabIndex = 11;
            buttonLoadShow.Text = "Load Show";
            buttonLoadShow.UseVisualStyleBackColor = true;
            buttonLoadShow.Click += buttonLoadShow_Click;
            // 
            // timerShow
            // 
            timerShow.Interval = 50;
            timerShow.Tick += timerShow_Tick;
            // 
            // timerPlayMediaEnd
            // 
            timerPlayMediaEnd.Interval = 50;
            timerPlayMediaEnd.Tick += timerPlayMediaEnd_Tick;
            // 
            // timerScene
            // 
            timerScene.Interval = 50;
            timerScene.Tick += timerScene_Tick;
            // 
            // ShowTriggers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1216, 684);
            Controls.Add(buttonLoadShow);
            Controls.Add(buttonSaveShow);
            Controls.Add(buttonMoveEventUp);
            Controls.Add(buttonMoveEventDown);
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
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMusic).EndInit();
            groupBoxSceneSelector.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarRunTime).EndInit();
            groupBoxTreeControls.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBoxArd.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridARD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeViewShow;
        private System.Windows.Forms.Button buttonRunShow;
        private System.Windows.Forms.GroupBox groupBoxMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.DataGridView dataGridMusic;
        private System.Windows.Forms.Button buttonAddToNext;
        private System.Windows.Forms.Button buttonPlaySample;
        private System.Windows.Forms.GroupBox groupBoxSceneSelector;
        private System.Windows.Forms.Button buttonRunFromSelected;
        private System.Windows.Forms.ComboBox comboBoxScene;
        private System.Windows.Forms.Button buttonStopShow;
        private System.Windows.Forms.GroupBox groupBoxTreeControls;
        private System.Windows.Forms.Button buttonAddAsInterupt;
        private System.Windows.Forms.GroupBox groupBoxArd;
        private System.Windows.Forms.DataGridView dataGridARD;
        private System.Windows.Forms.Button buttonMoveEventDown;
        private System.Windows.Forms.Button buttonMoveEventUp;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxTriggerAtArd;
        private System.Windows.Forms.Button buttonAddNewEvent;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBarRunTime;
        private System.Windows.Forms.TextBox textBoxRunTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBoxEventsAddtoEvent;
        private System.Windows.Forms.Button buttonSaveShow;
        private System.Windows.Forms.Button buttonLoadShow;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Timer timerPlayMediaEnd;
        private System.Windows.Forms.Timer timerScene;
    }
}