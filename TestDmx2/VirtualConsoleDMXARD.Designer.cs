using AxWMPLib;
using System.Drawing;
using System.Windows.Forms;
using TestDmx2.Properties;
namespace TestDmx2
{
    partial class DMXandARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMXandARD));
            PlayerWindow = new AxWindowsMediaPlayer();
            SerialDevices = new ComboBox();
            DMXConnectionButton = new Button();
            LogBox = new ListBox();
            SerialDevicesDMX = new ComboBox();
            button1 = new Button();
            ProgressBarCycle = new ProgressBar();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar5 = new TrackBar();
            trackBar6 = new TrackBar();
            trackBar7 = new TrackBar();
            trackBar8 = new TrackBar();
            trackBar9 = new TrackBar();
            trackBar10 = new TrackBar();
            trackBar11 = new TrackBar();
            trackBar12 = new TrackBar();
            trackBar13 = new TrackBar();
            trackBar14 = new TrackBar();
            trackBar15 = new TrackBar();
            trackBar16 = new TrackBar();
            fixtureButton1 = new Button();
            groupBox1 = new GroupBox();
            fixtureButton32 = new Button();
            fixtureButton31 = new Button();
            fixtureButton30 = new Button();
            fixtureButton29 = new Button();
            fixtureButton28 = new Button();
            fixtureButton27 = new Button();
            fixtureButton26 = new Button();
            fixtureButton25 = new Button();
            fixtureButton24 = new Button();
            fixtureButton23 = new Button();
            fixtureButton22 = new Button();
            fixtureButton21 = new Button();
            fixtureButton20 = new Button();
            fixtureButton19 = new Button();
            fixtureButton18 = new Button();
            fixtureButton17 = new Button();
            fixtureButton16 = new Button();
            fixtureButton15 = new Button();
            fixtureButton14 = new Button();
            fixtureButton13 = new Button();
            fixtureButton12 = new Button();
            fixtureButton11 = new Button();
            fixtureButton10 = new Button();
            fixtureButton9 = new Button();
            fixtureButton8 = new Button();
            fixtureButton7 = new Button();
            fixtureButton6 = new Button();
            fixtureButton5 = new Button();
            fixtureButton4 = new Button();
            fixtureButton3 = new Button();
            fixtureButton2 = new Button();
            groupBox2 = new GroupBox();
            domainUpDown16 = new DomainUpDown();
            domainUpDown15 = new DomainUpDown();
            domainUpDown14 = new DomainUpDown();
            domainUpDown13 = new DomainUpDown();
            domainUpDown12 = new DomainUpDown();
            domainUpDown11 = new DomainUpDown();
            domainUpDown10 = new DomainUpDown();
            domainUpDown9 = new DomainUpDown();
            domainUpDown8 = new DomainUpDown();
            domainUpDown7 = new DomainUpDown();
            domainUpDown6 = new DomainUpDown();
            domainUpDown5 = new DomainUpDown();
            domainUpDown4 = new DomainUpDown();
            domainUpDown3 = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            domainUpDown1 = new DomainUpDown();
            SetAllRandom = new Button();
            SetMaxButton = new Button();
            SetMinButton = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SaveNewScene = new Button();
            groupBox3 = new GroupBox();
            DeleteSelected = new Button();
            OverwriteScene = new Button();
            SaveMergeScene = new Button();
            SceneSelection = new ComboBox();
            buttonLoadConfig = new Button();
            buttonSaveConfig = new Button();
            groupBox4 = new GroupBox();
            FixtureComboBox = new ComboBox();
            Messages = new ListBox();
            dataGridARD = new DataGridView();
            dataGridMusic = new DataGridView();
            MusicGroup = new GroupBox();
            axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
            PlayMusic = new Button();
            AddMusic = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerWindow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar16).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridARD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMusic).BeginInit();
            MusicGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // PlayerWindow
            // 
            PlayerWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PlayerWindow.Enabled = true;
            PlayerWindow.Location = new Point(376, 66);
            PlayerWindow.Name = "PlayerWindow";
            PlayerWindow.Size = new Size(867, 461);
            PlayerWindow.TabIndex = 40;
            PlayerWindow.Visible = false;
            PlayerWindow.PlayStateChange += PlayerWindow_PlayStateChange;
            // 
            // SerialDevices
            // 
            SerialDevices.FormattingEnabled = true;
            SerialDevices.Location = new Point(12, 12);
            SerialDevices.Name = "SerialDevices";
            SerialDevices.Size = new Size(121, 23);
            SerialDevices.TabIndex = 0;
            // 
            // DMXConnectionButton
            // 
            DMXConnectionButton.Location = new Point(139, 12);
            DMXConnectionButton.Name = "DMXConnectionButton";
            DMXConnectionButton.Size = new Size(109, 23);
            DMXConnectionButton.TabIndex = 1;
            DMXConnectionButton.Text = "Connect ARD";
            DMXConnectionButton.UseVisualStyleBackColor = true;
            DMXConnectionButton.Click += ARDConnectionButton_Click;
            // 
            // LogBox
            // 
            LogBox.FormattingEnabled = true;
            LogBox.ItemHeight = 15;
            LogBox.Location = new Point(12, 740);
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(1142, 49);
            LogBox.TabIndex = 2;
            // 
            // SerialDevicesDMX
            // 
            SerialDevicesDMX.FormattingEnabled = true;
            SerialDevicesDMX.Location = new Point(21, 325);
            SerialDevicesDMX.Name = "SerialDevicesDMX";
            SerialDevicesDMX.Size = new Size(121, 23);
            SerialDevicesDMX.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(148, 324);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 4;
            button1.Text = "Connect DMX";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DMXConnection_Click;
            // 
            // ProgressBarCycle
            // 
            ProgressBarCycle.Location = new Point(12, 711);
            ProgressBarCycle.Name = "ProgressBarCycle";
            ProgressBarCycle.Size = new Size(1142, 23);
            ProgressBarCycle.TabIndex = 5;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(13, 43);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 220);
            trackBar1.TabIndex = 6;
            trackBar1.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(64, 43);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(45, 220);
            trackBar2.TabIndex = 7;
            trackBar2.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(115, 43);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Orientation = Orientation.Vertical;
            trackBar3.Size = new Size(45, 220);
            trackBar3.TabIndex = 8;
            trackBar3.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(166, 43);
            trackBar4.Maximum = 255;
            trackBar4.Name = "trackBar4";
            trackBar4.Orientation = Orientation.Vertical;
            trackBar4.Size = new Size(45, 220);
            trackBar4.TabIndex = 9;
            trackBar4.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(208, 43);
            trackBar5.Maximum = 255;
            trackBar5.Name = "trackBar5";
            trackBar5.Orientation = Orientation.Vertical;
            trackBar5.Size = new Size(45, 220);
            trackBar5.TabIndex = 10;
            trackBar5.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar6
            // 
            trackBar6.Location = new Point(259, 43);
            trackBar6.Maximum = 255;
            trackBar6.Name = "trackBar6";
            trackBar6.Orientation = Orientation.Vertical;
            trackBar6.Size = new Size(45, 220);
            trackBar6.TabIndex = 11;
            trackBar6.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar7
            // 
            trackBar7.Location = new Point(306, 43);
            trackBar7.Maximum = 255;
            trackBar7.Name = "trackBar7";
            trackBar7.Orientation = Orientation.Vertical;
            trackBar7.Size = new Size(45, 220);
            trackBar7.TabIndex = 12;
            trackBar7.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar8
            // 
            trackBar8.Location = new Point(357, 43);
            trackBar8.Maximum = 255;
            trackBar8.Name = "trackBar8";
            trackBar8.Orientation = Orientation.Vertical;
            trackBar8.Size = new Size(45, 220);
            trackBar8.TabIndex = 13;
            trackBar8.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar9
            // 
            trackBar9.Location = new Point(408, 43);
            trackBar9.Maximum = 255;
            trackBar9.Name = "trackBar9";
            trackBar9.Orientation = Orientation.Vertical;
            trackBar9.Size = new Size(45, 220);
            trackBar9.TabIndex = 14;
            trackBar9.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar10
            // 
            trackBar10.Location = new Point(459, 43);
            trackBar10.Maximum = 255;
            trackBar10.Name = "trackBar10";
            trackBar10.Orientation = Orientation.Vertical;
            trackBar10.Size = new Size(45, 220);
            trackBar10.TabIndex = 15;
            trackBar10.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar11
            // 
            trackBar11.Location = new Point(510, 43);
            trackBar11.Maximum = 255;
            trackBar11.Name = "trackBar11";
            trackBar11.Orientation = Orientation.Vertical;
            trackBar11.Size = new Size(45, 220);
            trackBar11.TabIndex = 16;
            trackBar11.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar12
            // 
            trackBar12.Location = new Point(561, 43);
            trackBar12.Maximum = 255;
            trackBar12.Name = "trackBar12";
            trackBar12.Orientation = Orientation.Vertical;
            trackBar12.Size = new Size(45, 220);
            trackBar12.TabIndex = 17;
            trackBar12.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar13
            // 
            trackBar13.Location = new Point(612, 43);
            trackBar13.Maximum = 255;
            trackBar13.Name = "trackBar13";
            trackBar13.Orientation = Orientation.Vertical;
            trackBar13.Size = new Size(45, 220);
            trackBar13.TabIndex = 18;
            trackBar13.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar14
            // 
            trackBar14.Location = new Point(663, 43);
            trackBar14.Maximum = 255;
            trackBar14.Name = "trackBar14";
            trackBar14.Orientation = Orientation.Vertical;
            trackBar14.Size = new Size(45, 220);
            trackBar14.TabIndex = 19;
            trackBar14.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar15
            // 
            trackBar15.Location = new Point(714, 43);
            trackBar15.Maximum = 255;
            trackBar15.Name = "trackBar15";
            trackBar15.Orientation = Orientation.Vertical;
            trackBar15.Size = new Size(45, 220);
            trackBar15.TabIndex = 20;
            trackBar15.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBar16
            // 
            trackBar16.Location = new Point(765, 43);
            trackBar16.Maximum = 255;
            trackBar16.Name = "trackBar16";
            trackBar16.Orientation = Orientation.Vertical;
            trackBar16.Size = new Size(45, 220);
            trackBar16.TabIndex = 21;
            trackBar16.ValueChanged += trackBar_ValueChanged;
            // 
            // fixtureButton1
            // 
            fixtureButton1.BackColor = Color.Snow;
            fixtureButton1.FlatStyle = FlatStyle.Popup;
            fixtureButton1.Location = new Point(19, 22);
            fixtureButton1.Name = "fixtureButton1";
            fixtureButton1.Size = new Size(67, 28);
            fixtureButton1.TabIndex = 22;
            fixtureButton1.Text = "1";
            fixtureButton1.UseVisualStyleBackColor = false;
            fixtureButton1.Click += FixtureButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fixtureButton32);
            groupBox1.Controls.Add(fixtureButton31);
            groupBox1.Controls.Add(fixtureButton30);
            groupBox1.Controls.Add(fixtureButton29);
            groupBox1.Controls.Add(fixtureButton28);
            groupBox1.Controls.Add(fixtureButton27);
            groupBox1.Controls.Add(fixtureButton26);
            groupBox1.Controls.Add(fixtureButton25);
            groupBox1.Controls.Add(fixtureButton24);
            groupBox1.Controls.Add(fixtureButton23);
            groupBox1.Controls.Add(fixtureButton22);
            groupBox1.Controls.Add(fixtureButton21);
            groupBox1.Controls.Add(fixtureButton20);
            groupBox1.Controls.Add(fixtureButton19);
            groupBox1.Controls.Add(fixtureButton18);
            groupBox1.Controls.Add(fixtureButton17);
            groupBox1.Controls.Add(fixtureButton16);
            groupBox1.Controls.Add(fixtureButton15);
            groupBox1.Controls.Add(fixtureButton14);
            groupBox1.Controls.Add(fixtureButton13);
            groupBox1.Controls.Add(fixtureButton12);
            groupBox1.Controls.Add(fixtureButton11);
            groupBox1.Controls.Add(fixtureButton10);
            groupBox1.Controls.Add(fixtureButton9);
            groupBox1.Controls.Add(fixtureButton8);
            groupBox1.Controls.Add(fixtureButton7);
            groupBox1.Controls.Add(fixtureButton6);
            groupBox1.Controls.Add(fixtureButton5);
            groupBox1.Controls.Add(fixtureButton4);
            groupBox1.Controls.Add(fixtureButton3);
            groupBox1.Controls.Add(fixtureButton2);
            groupBox1.Controls.Add(fixtureButton1);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(2, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 302);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fixture(s)";
            // 
            // fixtureButton32
            // 
            fixtureButton32.BackColor = Color.Snow;
            fixtureButton32.FlatStyle = FlatStyle.Popup;
            fixtureButton32.Location = new Point(238, 260);
            fixtureButton32.Name = "fixtureButton32";
            fixtureButton32.Size = new Size(67, 28);
            fixtureButton32.TabIndex = 52;
            fixtureButton32.Text = "32";
            fixtureButton32.UseVisualStyleBackColor = false;
            fixtureButton32.Click += FixtureButton_Click;
            // 
            // fixtureButton31
            // 
            fixtureButton31.BackColor = Color.Snow;
            fixtureButton31.FlatStyle = FlatStyle.Popup;
            fixtureButton31.Location = new Point(238, 226);
            fixtureButton31.Name = "fixtureButton31";
            fixtureButton31.Size = new Size(67, 28);
            fixtureButton31.TabIndex = 51;
            fixtureButton31.Text = "31";
            fixtureButton31.UseVisualStyleBackColor = false;
            fixtureButton31.Click += FixtureButton_Click;
            // 
            // fixtureButton30
            // 
            fixtureButton30.BackColor = Color.Snow;
            fixtureButton30.FlatStyle = FlatStyle.Popup;
            fixtureButton30.Location = new Point(238, 192);
            fixtureButton30.Name = "fixtureButton30";
            fixtureButton30.Size = new Size(67, 28);
            fixtureButton30.TabIndex = 50;
            fixtureButton30.Text = "30";
            fixtureButton30.UseVisualStyleBackColor = false;
            fixtureButton30.Click += FixtureButton_Click;
            // 
            // fixtureButton29
            // 
            fixtureButton29.BackColor = Color.Snow;
            fixtureButton29.FlatStyle = FlatStyle.Popup;
            fixtureButton29.Location = new Point(238, 124);
            fixtureButton29.Name = "fixtureButton29";
            fixtureButton29.Size = new Size(67, 28);
            fixtureButton29.TabIndex = 49;
            fixtureButton29.Text = "29";
            fixtureButton29.UseVisualStyleBackColor = false;
            fixtureButton29.Click += FixtureButton_Click;
            // 
            // fixtureButton28
            // 
            fixtureButton28.BackColor = Color.Snow;
            fixtureButton28.FlatStyle = FlatStyle.Popup;
            fixtureButton28.Location = new Point(238, 90);
            fixtureButton28.Name = "fixtureButton28";
            fixtureButton28.Size = new Size(67, 28);
            fixtureButton28.TabIndex = 48;
            fixtureButton28.Text = "28";
            fixtureButton28.UseVisualStyleBackColor = false;
            fixtureButton28.Click += FixtureButton_Click;
            // 
            // fixtureButton27
            // 
            fixtureButton27.BackColor = Color.Snow;
            fixtureButton27.FlatStyle = FlatStyle.Popup;
            fixtureButton27.Location = new Point(238, 158);
            fixtureButton27.Name = "fixtureButton27";
            fixtureButton27.Size = new Size(67, 28);
            fixtureButton27.TabIndex = 48;
            fixtureButton27.Text = "27";
            fixtureButton27.UseVisualStyleBackColor = false;
            fixtureButton27.Click += FixtureButton_Click;
            // 
            // fixtureButton26
            // 
            fixtureButton26.BackColor = Color.Snow;
            fixtureButton26.FlatStyle = FlatStyle.Popup;
            fixtureButton26.Location = new Point(238, 56);
            fixtureButton26.Name = "fixtureButton26";
            fixtureButton26.Size = new Size(67, 28);
            fixtureButton26.TabIndex = 47;
            fixtureButton26.Text = "26";
            fixtureButton26.UseVisualStyleBackColor = false;
            fixtureButton26.Click += FixtureButton_Click;
            // 
            // fixtureButton25
            // 
            fixtureButton25.BackColor = Color.Snow;
            fixtureButton25.FlatStyle = FlatStyle.Popup;
            fixtureButton25.Location = new Point(238, 22);
            fixtureButton25.Name = "fixtureButton25";
            fixtureButton25.Size = new Size(67, 28);
            fixtureButton25.TabIndex = 46;
            fixtureButton25.Text = "25";
            fixtureButton25.UseVisualStyleBackColor = false;
            fixtureButton25.Click += FixtureButton_Click;
            // 
            // fixtureButton24
            // 
            fixtureButton24.BackColor = Color.Snow;
            fixtureButton24.FlatStyle = FlatStyle.Popup;
            fixtureButton24.Location = new Point(165, 260);
            fixtureButton24.Name = "fixtureButton24";
            fixtureButton24.Size = new Size(67, 28);
            fixtureButton24.TabIndex = 45;
            fixtureButton24.Text = "24";
            fixtureButton24.UseVisualStyleBackColor = false;
            fixtureButton24.Click += FixtureButton_Click;
            // 
            // fixtureButton23
            // 
            fixtureButton23.BackColor = Color.Snow;
            fixtureButton23.FlatStyle = FlatStyle.Popup;
            fixtureButton23.Location = new Point(165, 226);
            fixtureButton23.Name = "fixtureButton23";
            fixtureButton23.Size = new Size(67, 28);
            fixtureButton23.TabIndex = 44;
            fixtureButton23.Text = "23";
            fixtureButton23.UseVisualStyleBackColor = false;
            fixtureButton23.Click += FixtureButton_Click;
            // 
            // fixtureButton22
            // 
            fixtureButton22.BackColor = Color.Snow;
            fixtureButton22.FlatStyle = FlatStyle.Popup;
            fixtureButton22.Location = new Point(165, 192);
            fixtureButton22.Name = "fixtureButton22";
            fixtureButton22.Size = new Size(67, 28);
            fixtureButton22.TabIndex = 43;
            fixtureButton22.Text = "22";
            fixtureButton22.UseVisualStyleBackColor = false;
            fixtureButton22.Click += FixtureButton_Click;
            // 
            // fixtureButton21
            // 
            fixtureButton21.BackColor = Color.Snow;
            fixtureButton21.FlatStyle = FlatStyle.Popup;
            fixtureButton21.Location = new Point(165, 158);
            fixtureButton21.Name = "fixtureButton21";
            fixtureButton21.Size = new Size(67, 28);
            fixtureButton21.TabIndex = 42;
            fixtureButton21.Text = "21";
            fixtureButton21.UseVisualStyleBackColor = false;
            fixtureButton21.Click += FixtureButton_Click;
            // 
            // fixtureButton20
            // 
            fixtureButton20.BackColor = Color.Snow;
            fixtureButton20.FlatStyle = FlatStyle.Popup;
            fixtureButton20.Location = new Point(165, 124);
            fixtureButton20.Name = "fixtureButton20";
            fixtureButton20.Size = new Size(67, 28);
            fixtureButton20.TabIndex = 41;
            fixtureButton20.Text = "20";
            fixtureButton20.UseVisualStyleBackColor = false;
            fixtureButton20.Click += FixtureButton_Click;
            // 
            // fixtureButton19
            // 
            fixtureButton19.BackColor = Color.Snow;
            fixtureButton19.FlatStyle = FlatStyle.Popup;
            fixtureButton19.Location = new Point(165, 90);
            fixtureButton19.Name = "fixtureButton19";
            fixtureButton19.Size = new Size(67, 28);
            fixtureButton19.TabIndex = 40;
            fixtureButton19.Text = "19";
            fixtureButton19.UseVisualStyleBackColor = false;
            fixtureButton19.Click += FixtureButton_Click;
            // 
            // fixtureButton18
            // 
            fixtureButton18.BackColor = Color.Snow;
            fixtureButton18.FlatStyle = FlatStyle.Popup;
            fixtureButton18.Location = new Point(165, 56);
            fixtureButton18.Name = "fixtureButton18";
            fixtureButton18.Size = new Size(67, 28);
            fixtureButton18.TabIndex = 39;
            fixtureButton18.Text = "18";
            fixtureButton18.UseVisualStyleBackColor = false;
            fixtureButton18.Click += FixtureButton_Click;
            // 
            // fixtureButton17
            // 
            fixtureButton17.BackColor = Color.Snow;
            fixtureButton17.FlatStyle = FlatStyle.Popup;
            fixtureButton17.Location = new Point(165, 22);
            fixtureButton17.Name = "fixtureButton17";
            fixtureButton17.Size = new Size(67, 28);
            fixtureButton17.TabIndex = 38;
            fixtureButton17.Text = "17";
            fixtureButton17.UseVisualStyleBackColor = false;
            fixtureButton17.Click += FixtureButton_Click;
            // 
            // fixtureButton16
            // 
            fixtureButton16.BackColor = Color.Snow;
            fixtureButton16.FlatStyle = FlatStyle.Popup;
            fixtureButton16.Location = new Point(92, 260);
            fixtureButton16.Name = "fixtureButton16";
            fixtureButton16.Size = new Size(67, 28);
            fixtureButton16.TabIndex = 37;
            fixtureButton16.Text = "16";
            fixtureButton16.UseVisualStyleBackColor = false;
            fixtureButton16.Click += FixtureButton_Click;
            // 
            // fixtureButton15
            // 
            fixtureButton15.BackColor = Color.Snow;
            fixtureButton15.FlatStyle = FlatStyle.Popup;
            fixtureButton15.Location = new Point(92, 226);
            fixtureButton15.Name = "fixtureButton15";
            fixtureButton15.Size = new Size(67, 28);
            fixtureButton15.TabIndex = 36;
            fixtureButton15.Text = "15";
            fixtureButton15.UseVisualStyleBackColor = false;
            fixtureButton15.Click += FixtureButton_Click;
            // 
            // fixtureButton14
            // 
            fixtureButton14.BackColor = Color.Snow;
            fixtureButton14.FlatStyle = FlatStyle.Popup;
            fixtureButton14.Location = new Point(92, 192);
            fixtureButton14.Name = "fixtureButton14";
            fixtureButton14.Size = new Size(67, 28);
            fixtureButton14.TabIndex = 35;
            fixtureButton14.Text = "14";
            fixtureButton14.UseVisualStyleBackColor = false;
            fixtureButton14.Click += FixtureButton_Click;
            // 
            // fixtureButton13
            // 
            fixtureButton13.BackColor = Color.Snow;
            fixtureButton13.FlatStyle = FlatStyle.Popup;
            fixtureButton13.Location = new Point(92, 158);
            fixtureButton13.Name = "fixtureButton13";
            fixtureButton13.Size = new Size(67, 28);
            fixtureButton13.TabIndex = 34;
            fixtureButton13.Text = "13";
            fixtureButton13.UseVisualStyleBackColor = false;
            fixtureButton13.Click += FixtureButton_Click;
            // 
            // fixtureButton12
            // 
            fixtureButton12.BackColor = Color.Snow;
            fixtureButton12.FlatStyle = FlatStyle.Popup;
            fixtureButton12.Location = new Point(92, 124);
            fixtureButton12.Name = "fixtureButton12";
            fixtureButton12.Size = new Size(67, 28);
            fixtureButton12.TabIndex = 33;
            fixtureButton12.Text = "12";
            fixtureButton12.UseVisualStyleBackColor = false;
            fixtureButton12.Click += FixtureButton_Click;
            // 
            // fixtureButton11
            // 
            fixtureButton11.BackColor = Color.Snow;
            fixtureButton11.FlatStyle = FlatStyle.Popup;
            fixtureButton11.Location = new Point(92, 90);
            fixtureButton11.Name = "fixtureButton11";
            fixtureButton11.Size = new Size(67, 28);
            fixtureButton11.TabIndex = 32;
            fixtureButton11.Text = "11";
            fixtureButton11.UseVisualStyleBackColor = false;
            fixtureButton11.Click += FixtureButton_Click;
            // 
            // fixtureButton10
            // 
            fixtureButton10.BackColor = Color.Snow;
            fixtureButton10.FlatStyle = FlatStyle.Popup;
            fixtureButton10.Location = new Point(92, 56);
            fixtureButton10.Name = "fixtureButton10";
            fixtureButton10.Size = new Size(67, 28);
            fixtureButton10.TabIndex = 31;
            fixtureButton10.Text = "10";
            fixtureButton10.UseVisualStyleBackColor = false;
            fixtureButton10.Click += FixtureButton_Click;
            // 
            // fixtureButton9
            // 
            fixtureButton9.BackColor = Color.Snow;
            fixtureButton9.FlatStyle = FlatStyle.Popup;
            fixtureButton9.Location = new Point(92, 22);
            fixtureButton9.Name = "fixtureButton9";
            fixtureButton9.Size = new Size(67, 28);
            fixtureButton9.TabIndex = 30;
            fixtureButton9.Text = "9";
            fixtureButton9.UseVisualStyleBackColor = false;
            fixtureButton9.Click += FixtureButton_Click;
            // 
            // fixtureButton8
            // 
            fixtureButton8.BackColor = Color.Snow;
            fixtureButton8.FlatStyle = FlatStyle.Popup;
            fixtureButton8.Location = new Point(19, 260);
            fixtureButton8.Name = "fixtureButton8";
            fixtureButton8.Size = new Size(67, 28);
            fixtureButton8.TabIndex = 29;
            fixtureButton8.Text = "8";
            fixtureButton8.UseVisualStyleBackColor = false;
            fixtureButton8.Click += FixtureButton_Click;
            // 
            // fixtureButton7
            // 
            fixtureButton7.BackColor = Color.Snow;
            fixtureButton7.FlatStyle = FlatStyle.Popup;
            fixtureButton7.Location = new Point(19, 226);
            fixtureButton7.Name = "fixtureButton7";
            fixtureButton7.Size = new Size(67, 28);
            fixtureButton7.TabIndex = 28;
            fixtureButton7.Text = "7";
            fixtureButton7.UseVisualStyleBackColor = false;
            fixtureButton7.Click += FixtureButton_Click;
            // 
            // fixtureButton6
            // 
            fixtureButton6.BackColor = Color.Snow;
            fixtureButton6.FlatStyle = FlatStyle.Popup;
            fixtureButton6.Location = new Point(19, 192);
            fixtureButton6.Name = "fixtureButton6";
            fixtureButton6.Size = new Size(67, 28);
            fixtureButton6.TabIndex = 27;
            fixtureButton6.Text = "6";
            fixtureButton6.UseVisualStyleBackColor = false;
            fixtureButton6.Click += FixtureButton_Click;
            // 
            // fixtureButton5
            // 
            fixtureButton5.BackColor = Color.Snow;
            fixtureButton5.FlatStyle = FlatStyle.Popup;
            fixtureButton5.Location = new Point(19, 158);
            fixtureButton5.Name = "fixtureButton5";
            fixtureButton5.Size = new Size(67, 28);
            fixtureButton5.TabIndex = 26;
            fixtureButton5.Text = "5";
            fixtureButton5.UseVisualStyleBackColor = false;
            fixtureButton5.Click += FixtureButton_Click;
            // 
            // fixtureButton4
            // 
            fixtureButton4.BackColor = Color.Snow;
            fixtureButton4.FlatStyle = FlatStyle.Popup;
            fixtureButton4.Location = new Point(19, 124);
            fixtureButton4.Name = "fixtureButton4";
            fixtureButton4.Size = new Size(67, 28);
            fixtureButton4.TabIndex = 25;
            fixtureButton4.Text = "4";
            fixtureButton4.UseVisualStyleBackColor = false;
            fixtureButton4.Click += FixtureButton_Click;
            // 
            // fixtureButton3
            // 
            fixtureButton3.BackColor = Color.Snow;
            fixtureButton3.FlatStyle = FlatStyle.Popup;
            fixtureButton3.Location = new Point(19, 90);
            fixtureButton3.Name = "fixtureButton3";
            fixtureButton3.Size = new Size(67, 28);
            fixtureButton3.TabIndex = 24;
            fixtureButton3.Text = "3";
            fixtureButton3.UseVisualStyleBackColor = false;
            fixtureButton3.Click += FixtureButton_Click;
            // 
            // fixtureButton2
            // 
            fixtureButton2.BackColor = Color.Snow;
            fixtureButton2.FlatStyle = FlatStyle.Popup;
            fixtureButton2.Location = new Point(19, 56);
            fixtureButton2.Name = "fixtureButton2";
            fixtureButton2.Size = new Size(67, 28);
            fixtureButton2.TabIndex = 23;
            fixtureButton2.Text = "2";
            fixtureButton2.UseVisualStyleBackColor = false;
            fixtureButton2.Click += FixtureButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(domainUpDown16);
            groupBox2.Controls.Add(domainUpDown15);
            groupBox2.Controls.Add(domainUpDown14);
            groupBox2.Controls.Add(domainUpDown13);
            groupBox2.Controls.Add(domainUpDown12);
            groupBox2.Controls.Add(domainUpDown11);
            groupBox2.Controls.Add(domainUpDown10);
            groupBox2.Controls.Add(domainUpDown9);
            groupBox2.Controls.Add(domainUpDown8);
            groupBox2.Controls.Add(domainUpDown7);
            groupBox2.Controls.Add(domainUpDown6);
            groupBox2.Controls.Add(domainUpDown5);
            groupBox2.Controls.Add(domainUpDown4);
            groupBox2.Controls.Add(domainUpDown3);
            groupBox2.Controls.Add(domainUpDown2);
            groupBox2.Controls.Add(domainUpDown1);
            groupBox2.Controls.Add(SetAllRandom);
            groupBox2.Controls.Add(SetMaxButton);
            groupBox2.Controls.Add(SetMinButton);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(trackBar3);
            groupBox2.Controls.Add(trackBar1);
            groupBox2.Controls.Add(trackBar16);
            groupBox2.Controls.Add(trackBar2);
            groupBox2.Controls.Add(trackBar15);
            groupBox2.Controls.Add(trackBar4);
            groupBox2.Controls.Add(trackBar14);
            groupBox2.Controls.Add(trackBar5);
            groupBox2.Controls.Add(trackBar13);
            groupBox2.Controls.Add(trackBar6);
            groupBox2.Controls.Add(trackBar12);
            groupBox2.Controls.Add(trackBar7);
            groupBox2.Controls.Add(trackBar11);
            groupBox2.Controls.Add(trackBar8);
            groupBox2.Controls.Add(trackBar10);
            groupBox2.Controls.Add(trackBar9);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(339, 370);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(841, 335);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "DMX Channels";
            // 
            // domainUpDown16
            // 
            domainUpDown16.Enabled = false;
            domainUpDown16.Location = new Point(759, 265);
            domainUpDown16.Name = "domainUpDown16";
            domainUpDown16.Size = new Size(42, 23);
            domainUpDown16.TabIndex = 56;
            domainUpDown16.Text = "0";
            // 
            // domainUpDown15
            // 
            domainUpDown15.Enabled = false;
            domainUpDown15.Location = new Point(711, 265);
            domainUpDown15.Name = "domainUpDown15";
            domainUpDown15.Size = new Size(42, 23);
            domainUpDown15.TabIndex = 55;
            domainUpDown15.Text = "0";
            // 
            // domainUpDown14
            // 
            domainUpDown14.Enabled = false;
            domainUpDown14.Location = new Point(654, 265);
            domainUpDown14.Name = "domainUpDown14";
            domainUpDown14.Size = new Size(42, 23);
            domainUpDown14.TabIndex = 54;
            domainUpDown14.Text = "0";
            // 
            // domainUpDown13
            // 
            domainUpDown13.Enabled = false;
            domainUpDown13.Location = new Point(606, 265);
            domainUpDown13.Name = "domainUpDown13";
            domainUpDown13.Size = new Size(42, 23);
            domainUpDown13.TabIndex = 53;
            domainUpDown13.Text = "0";
            // 
            // domainUpDown12
            // 
            domainUpDown12.Enabled = false;
            domainUpDown12.Location = new Point(558, 265);
            domainUpDown12.Name = "domainUpDown12";
            domainUpDown12.Size = new Size(42, 23);
            domainUpDown12.TabIndex = 52;
            domainUpDown12.Text = "0";
            // 
            // domainUpDown11
            // 
            domainUpDown11.Enabled = false;
            domainUpDown11.Location = new Point(504, 265);
            domainUpDown11.Name = "domainUpDown11";
            domainUpDown11.Size = new Size(42, 23);
            domainUpDown11.TabIndex = 51;
            domainUpDown11.Text = "0";
            // 
            // domainUpDown10
            // 
            domainUpDown10.Enabled = false;
            domainUpDown10.Location = new Point(456, 265);
            domainUpDown10.Name = "domainUpDown10";
            domainUpDown10.Size = new Size(42, 23);
            domainUpDown10.TabIndex = 50;
            domainUpDown10.Text = "0";
            // 
            // domainUpDown9
            // 
            domainUpDown9.Enabled = false;
            domainUpDown9.Location = new Point(396, 265);
            domainUpDown9.Name = "domainUpDown9";
            domainUpDown9.Size = new Size(42, 23);
            domainUpDown9.TabIndex = 49;
            domainUpDown9.Text = "0";
            // 
            // domainUpDown8
            // 
            domainUpDown8.Enabled = false;
            domainUpDown8.Location = new Point(348, 265);
            domainUpDown8.Name = "domainUpDown8";
            domainUpDown8.Size = new Size(42, 23);
            domainUpDown8.TabIndex = 48;
            domainUpDown8.Text = "0";
            // 
            // domainUpDown7
            // 
            domainUpDown7.Enabled = false;
            domainUpDown7.Location = new Point(297, 265);
            domainUpDown7.Name = "domainUpDown7";
            domainUpDown7.Size = new Size(42, 23);
            domainUpDown7.TabIndex = 47;
            domainUpDown7.Text = "0";
            // 
            // domainUpDown6
            // 
            domainUpDown6.Enabled = false;
            domainUpDown6.Location = new Point(250, 265);
            domainUpDown6.Name = "domainUpDown6";
            domainUpDown6.Size = new Size(42, 23);
            domainUpDown6.TabIndex = 46;
            domainUpDown6.Text = "0";
            // 
            // domainUpDown5
            // 
            domainUpDown5.Enabled = false;
            domainUpDown5.Location = new Point(199, 265);
            domainUpDown5.Name = "domainUpDown5";
            domainUpDown5.Size = new Size(42, 23);
            domainUpDown5.TabIndex = 45;
            domainUpDown5.Text = "0";
            // 
            // domainUpDown4
            // 
            domainUpDown4.Enabled = false;
            domainUpDown4.Location = new Point(154, 265);
            domainUpDown4.Name = "domainUpDown4";
            domainUpDown4.Size = new Size(40, 23);
            domainUpDown4.TabIndex = 44;
            domainUpDown4.Text = "0";
            // 
            // domainUpDown3
            // 
            domainUpDown3.Enabled = false;
            domainUpDown3.Location = new Point(108, 265);
            domainUpDown3.Name = "domainUpDown3";
            domainUpDown3.Size = new Size(40, 23);
            domainUpDown3.TabIndex = 43;
            domainUpDown3.Text = "0";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Enabled = false;
            domainUpDown2.Location = new Point(57, 265);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(40, 23);
            domainUpDown2.TabIndex = 42;
            domainUpDown2.Text = "0";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Enabled = false;
            domainUpDown1.Location = new Point(6, 265);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(40, 23);
            domainUpDown1.TabIndex = 41;
            domainUpDown1.Text = "0";
            // 
            // SetAllRandom
            // 
            SetAllRandom.Location = new Point(199, 306);
            SetAllRandom.Name = "SetAllRandom";
            SetAllRandom.Size = new Size(122, 23);
            SetAllRandom.TabIndex = 40;
            SetAllRandom.Text = "Set All Random";
            SetAllRandom.UseVisualStyleBackColor = true;
            SetAllRandom.Click += SetAllButton_Click;
            // 
            // SetMaxButton
            // 
            SetMaxButton.Location = new Point(103, 306);
            SetMaxButton.Name = "SetMaxButton";
            SetMaxButton.Size = new Size(90, 23);
            SetMaxButton.TabIndex = 39;
            SetMaxButton.Text = "Set All to 255";
            SetMaxButton.UseVisualStyleBackColor = true;
            SetMaxButton.Click += SetAllButton_Click;
            // 
            // SetMinButton
            // 
            SetMinButton.Location = new Point(7, 306);
            SetMinButton.Name = "SetMinButton";
            SetMinButton.Size = new Size(90, 23);
            SetMinButton.TabIndex = 38;
            SetMinButton.Text = "Set All to 0";
            SetMinButton.UseVisualStyleBackColor = true;
            SetMinButton.Click += SetAllButton_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(765, 25);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 37;
            label16.Text = "CH 16";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(714, 25);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 36;
            label15.Text = "CH 15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(663, 25);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 35;
            label14.Text = "CH 14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(612, 25);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 34;
            label13.Text = "CH 13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(561, 25);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 33;
            label12.Text = "CH 12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(510, 25);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 32;
            label11.Text = "CH 11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(459, 25);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 31;
            label10.Text = "CH 10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 25);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 30;
            label9.Text = "CH 9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(357, 25);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 29;
            label8.Text = "CH 8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 25);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 28;
            label7.Text = "CH 7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 25);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 27;
            label6.Text = "CH 6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 25);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 26;
            label5.Text = "CH 5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 25);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 25;
            label4.Text = "CH 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 25);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 24;
            label3.Text = "CH 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 25);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 23;
            label2.Text = "CH 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 22;
            label1.Text = "CH 1";
            // 
            // SaveNewScene
            // 
            SaveNewScene.Location = new Point(506, 22);
            SaveNewScene.Name = "SaveNewScene";
            SaveNewScene.Size = new Size(142, 23);
            SaveNewScene.TabIndex = 25;
            SaveNewScene.Text = "Save New Scene";
            SaveNewScene.UseVisualStyleBackColor = true;
            SaveNewScene.Click += SaveScene_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DeleteSelected);
            groupBox3.Controls.Add(OverwriteScene);
            groupBox3.Controls.Add(SaveMergeScene);
            groupBox3.Controls.Add(SceneSelection);
            groupBox3.Controls.Add(SaveNewScene);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(499, 280);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(655, 84);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Scene Control";
            // 
            // DeleteSelected
            // 
            DeleteSelected.FlatStyle = FlatStyle.System;
            DeleteSelected.Location = new Point(506, 51);
            DeleteSelected.Name = "DeleteSelected";
            DeleteSelected.Size = new Size(142, 23);
            DeleteSelected.TabIndex = 29;
            DeleteSelected.Text = "Delete Selected Scene";
            DeleteSelected.UseVisualStyleBackColor = true;
            DeleteSelected.Click += SaveScene_Click;
            // 
            // OverwriteScene
            // 
            OverwriteScene.Location = new Point(327, 22);
            OverwriteScene.Name = "OverwriteScene";
            OverwriteScene.Size = new Size(173, 23);
            OverwriteScene.TabIndex = 28;
            OverwriteScene.Text = "Overwrite Selected Scene";
            OverwriteScene.UseVisualStyleBackColor = true;
            OverwriteScene.Click += SaveScene_Click;
            // 
            // SaveMergeScene
            // 
            SaveMergeScene.Location = new Point(327, 51);
            SaveMergeScene.Name = "SaveMergeScene";
            SaveMergeScene.Size = new Size(173, 23);
            SaveMergeScene.TabIndex = 27;
            SaveMergeScene.Text = "Merge to Selected Scene";
            SaveMergeScene.UseVisualStyleBackColor = true;
            SaveMergeScene.Click += SaveScene_Click;
            // 
            // SceneSelection
            // 
            SceneSelection.FormattingEnabled = true;
            SceneSelection.Location = new Point(7, 22);
            SceneSelection.Name = "SceneSelection";
            SceneSelection.Size = new Size(314, 23);
            SceneSelection.TabIndex = 26;
            SceneSelection.SelectedIndexChanged += Scene_ValueChanged;
            // 
            // buttonLoadConfig
            // 
            buttonLoadConfig.Location = new Point(906, 12);
            buttonLoadConfig.Name = "buttonLoadConfig";
            buttonLoadConfig.Size = new Size(97, 23);
            buttonLoadConfig.TabIndex = 27;
            buttonLoadConfig.Text = "Load Config";
            buttonLoadConfig.UseVisualStyleBackColor = true;
            buttonLoadConfig.Click += LoadSave_Click;
            // 
            // buttonSaveConfig
            // 
            buttonSaveConfig.Location = new Point(1009, 12);
            buttonSaveConfig.Name = "buttonSaveConfig";
            buttonSaveConfig.Size = new Size(145, 23);
            buttonSaveConfig.TabIndex = 28;
            buttonSaveConfig.Text = "Save Config";
            buttonSaveConfig.UseVisualStyleBackColor = true;
            buttonSaveConfig.Click += LoadSave_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(FixtureComboBox);
            groupBox4.Enabled = false;
            groupBox4.Location = new Point(313, 280);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(180, 84);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Indvidual Fixture Control";
            // 
            // FixtureComboBox
            // 
            FixtureComboBox.FormattingEnabled = true;
            FixtureComboBox.Location = new Point(13, 35);
            FixtureComboBox.Name = "FixtureComboBox";
            FixtureComboBox.Size = new Size(161, 23);
            FixtureComboBox.Sorted = true;
            FixtureComboBox.TabIndex = 0;
            FixtureComboBox.SelectedIndexChanged += Fixture_ValueChanged;
            // 
            // Messages
            // 
            Messages.FormattingEnabled = true;
            Messages.ItemHeight = 15;
            Messages.Location = new Point(313, 225);
            Messages.Name = "Messages";
            Messages.Size = new Size(841, 49);
            Messages.TabIndex = 30;
            // 
            // dataGridARD
            // 
            dataGridARD.AllowUserToAddRows = false;
            dataGridARD.AllowUserToDeleteRows = false;
            dataGridARD.AllowUserToOrderColumns = true;
            dataGridARD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridARD.Location = new Point(2, 46);
            dataGridARD.Name = "dataGridARD";
            dataGridARD.ReadOnly = true;
            dataGridARD.Size = new Size(305, 263);
            dataGridARD.TabIndex = 31;
            // 
            // dataGridMusic
            // 
            dataGridMusic.AllowUserToAddRows = false;
            dataGridMusic.AllowUserToOrderColumns = true;
            dataGridMusic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMusic.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridMusic.Location = new Point(11, 22);
            dataGridMusic.MultiSelect = false;
            dataGridMusic.Name = "dataGridMusic";
            dataGridMusic.ReadOnly = true;
            dataGridMusic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMusic.Size = new Size(821, 99);
            dataGridMusic.TabIndex = 32;
            // 
            // MusicGroup
            // 
            MusicGroup.Controls.Add(axWindowsMediaPlayer1);
            MusicGroup.Controls.Add(PlayMusic);
            MusicGroup.Controls.Add(AddMusic);
            MusicGroup.Controls.Add(dataGridMusic);
            MusicGroup.Location = new Point(313, 46);
            MusicGroup.Name = "MusicGroup";
            MusicGroup.Size = new Size(841, 173);
            MusicGroup.TabIndex = 32;
            MusicGroup.TabStop = false;
            MusicGroup.Text = "Music";
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(243, 127);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(587, 40);
            axWindowsMediaPlayer1.TabIndex = 35;
            // 
            // PlayMusic
            // 
            PlayMusic.Location = new Point(129, 127);
            PlayMusic.Name = "PlayMusic";
            PlayMusic.Size = new Size(108, 40);
            PlayMusic.TabIndex = 34;
            PlayMusic.Text = "Play Selected";
            PlayMusic.UseVisualStyleBackColor = true;
            PlayMusic.Click += MusicButton_Click;
            // 
            // AddMusic
            // 
            AddMusic.Location = new Point(11, 127);
            AddMusic.Name = "AddMusic";
            AddMusic.Size = new Size(112, 40);
            AddMusic.TabIndex = 33;
            AddMusic.Text = "Add Music";
            AddMusic.UseVisualStyleBackColor = true;
            AddMusic.Click += MusicButton_Click;
            // 
            // DMXandARD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 801);
            Controls.Add(MusicGroup);
            Controls.Add(dataGridARD);
            Controls.Add(Messages);
            Controls.Add(groupBox4);
            Controls.Add(buttonSaveConfig);
            Controls.Add(buttonLoadConfig);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ProgressBarCycle);
            Controls.Add(button1);
            Controls.Add(SerialDevicesDMX);
            Controls.Add(LogBox);
            Controls.Add(DMXConnectionButton);
            Controls.Add(SerialDevices);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DMXandARD";
            Text = "DMXARD";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)PlayerWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar7).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar8).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar9).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar10).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar11).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar12).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar13).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar14).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar15).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar16).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridARD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMusic).EndInit();
            MusicGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox SerialDevices;
        private System.Windows.Forms.Button DMXConnectionButton;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.ComboBox SerialDevicesDMX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar ProgressBarCycle;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.TrackBar trackBar10;
        private System.Windows.Forms.TrackBar trackBar11;
        private System.Windows.Forms.TrackBar trackBar12;
        private System.Windows.Forms.TrackBar trackBar13;
        private System.Windows.Forms.TrackBar trackBar14;
        private System.Windows.Forms.TrackBar trackBar15;
        private System.Windows.Forms.TrackBar trackBar16;
        private AxWMPLib.AxWindowsMediaPlayer PlayerWindow;
        private System.Windows.Forms.Button fixtureButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fixtureButton29;
        private System.Windows.Forms.Button fixtureButton28;
        private System.Windows.Forms.Button fixtureButton27;
        private System.Windows.Forms.Button fixtureButton26;
        private System.Windows.Forms.Button fixtureButton25;
        private System.Windows.Forms.Button fixtureButton24;
        private System.Windows.Forms.Button fixtureButton23;
        private System.Windows.Forms.Button fixtureButton22;
        private System.Windows.Forms.Button fixtureButton21;
        private System.Windows.Forms.Button fixtureButton20;
        private System.Windows.Forms.Button fixtureButton19;
        private System.Windows.Forms.Button fixtureButton18;
        private System.Windows.Forms.Button fixtureButton17;
        private System.Windows.Forms.Button fixtureButton16;
        private System.Windows.Forms.Button fixtureButton15;
        private System.Windows.Forms.Button fixtureButton14;
        private System.Windows.Forms.Button fixtureButton13;
        private System.Windows.Forms.Button fixtureButton12;
        private System.Windows.Forms.Button fixtureButton11;
        private System.Windows.Forms.Button fixtureButton10;
        private System.Windows.Forms.Button fixtureButton9;
        private System.Windows.Forms.Button fixtureButton8;
        private System.Windows.Forms.Button fixtureButton7;
        private System.Windows.Forms.Button fixtureButton6;
        private System.Windows.Forms.Button fixtureButton5;
        private System.Windows.Forms.Button fixtureButton4;
        private System.Windows.Forms.Button fixtureButton3;
        private System.Windows.Forms.Button fixtureButton2;
        private System.Windows.Forms.Button fixtureButton32;
        private System.Windows.Forms.Button fixtureButton31;
        private System.Windows.Forms.Button fixtureButton30;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SetAllRandom;
        private System.Windows.Forms.Button SetMaxButton;
        private System.Windows.Forms.Button SetMinButton;
        private System.Windows.Forms.DomainUpDown domainUpDown16;
        private System.Windows.Forms.DomainUpDown domainUpDown15;
        private System.Windows.Forms.DomainUpDown domainUpDown14;
        private System.Windows.Forms.DomainUpDown domainUpDown13;
        private System.Windows.Forms.DomainUpDown domainUpDown12;
        private System.Windows.Forms.DomainUpDown domainUpDown11;
        private System.Windows.Forms.DomainUpDown domainUpDown10;
        private System.Windows.Forms.DomainUpDown domainUpDown9;
        private System.Windows.Forms.DomainUpDown domainUpDown8;
        private System.Windows.Forms.DomainUpDown domainUpDown7;
        private System.Windows.Forms.DomainUpDown domainUpDown6;
        private System.Windows.Forms.DomainUpDown domainUpDown5;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button SaveNewScene;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveMergeScene;
        private System.Windows.Forms.ComboBox SceneSelection;
        private System.Windows.Forms.Button OverwriteScene;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox FixtureComboBox;
        private System.Windows.Forms.ListBox Messages;
        private System.Windows.Forms.DataGridView dataGridARD;
        private System.Windows.Forms.DataGridView dataGridMusic;
        private System.Windows.Forms.GroupBox MusicGroup;
        private System.Windows.Forms.Button AddMusic;
        private Button PlayMusic;
        private AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

