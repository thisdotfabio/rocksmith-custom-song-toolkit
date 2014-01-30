namespace RocksmithToolkitGUI.DLCPackageCreator
{
    partial class ArrangementForm
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
            this.songXmlBrowseButton = new System.Windows.Forms.Button();
            this.addArrangementButton = new System.Windows.Forms.Button();
            this.arrangementTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toneBaseCombo = new System.Windows.Forms.ComboBox();
            this.scrollSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scrollSpeedDisplay = new System.Windows.Forms.Label();
            this.Picked = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arrangementNameCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tuningComboBox = new System.Windows.Forms.ComboBox();
            this.gbTone = new System.Windows.Forms.GroupBox();
            this.disableTonesCheckbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toneDCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toneCCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toneBCombo = new System.Windows.Forms.ComboBox();
            this.lblToneA = new System.Windows.Forms.Label();
            this.gbDLCId = new System.Windows.Forms.GroupBox();
            this.PersistentId = new RocksmithToolkitGUI.CueTextBox();
            this.MasterId = new RocksmithToolkitGUI.CueTextBox();
            this.gbXmlDefinition = new System.Windows.Forms.GroupBox();
            this.XmlFilePath = new RocksmithToolkitGUI.CueTextBox();
            this.gbArrInfo = new System.Windows.Forms.GroupBox();
            this.tuningEditButton = new System.Windows.Forms.Button();
            this.BonusCheckBox = new System.Windows.Forms.CheckBox();
            this.gbTuningPitch = new System.Windows.Forms.GroupBox();
            this.noteDisplay = new System.Windows.Forms.Label();
            this.frequencyTB = new RocksmithToolkitGUI.CueTextBox();
            this.centOffsetDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbScrollSpeed = new System.Windows.Forms.GroupBox();
            this.gbGameplayPath = new System.Windows.Forms.GroupBox();
            this.routeMaskNoneRadio = new System.Windows.Forms.RadioButton();
            this.routeMaskBassRadio = new System.Windows.Forms.RadioButton();
            this.routeMaskRhythmRadio = new System.Windows.Forms.RadioButton();
            this.routeMaskLeadRadio = new System.Windows.Forms.RadioButton();
            this.lessonGBFiles = new System.Windows.Forms.GroupBox();
            this.customLUATB = new RocksmithToolkitGUI.CueTextBox();
            this.audioPathTB = new RocksmithToolkitGUI.CueTextBox();
            this.openAudioButton = new System.Windows.Forms.Button();
            this.customLUAButton = new System.Windows.Forms.Button();
            this.LessonGB = new System.Windows.Forms.GroupBox();
            this.EtudeNameTB = new RocksmithToolkitGUI.CueTextBox();
            this.GENameTB = new RocksmithToolkitGUI.CueTextBox();
            this.LessonSubHeader = new RocksmithToolkitGUI.CueTextBox();
            this.LessonDisplayName = new RocksmithToolkitGUI.CueTextBox();
            this.LessonNumberTB = new RocksmithToolkitGUI.CueTextBox();
            this.ArtistSortTB = new RocksmithToolkitGUI.CueTextBox();
            this.LessonCheckBox = new System.Windows.Forms.CheckBox();
            this.VideoCheckBox = new System.Windows.Forms.CheckBox();
            this.VideoFilePath = new RocksmithToolkitGUI.CueTextBox();
            this.VideoFolderButtom = new System.Windows.Forms.Button();
            this.LessonDescriptionTB = new RocksmithToolkitGUI.CueTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scrollSpeedTrackBar)).BeginInit();
            this.gbTone.SuspendLayout();
            this.gbDLCId.SuspendLayout();
            this.gbXmlDefinition.SuspendLayout();
            this.gbArrInfo.SuspendLayout();
            this.gbTuningPitch.SuspendLayout();
            this.gbScrollSpeed.SuspendLayout();
            this.gbGameplayPath.SuspendLayout();
            this.lessonGBFiles.SuspendLayout();
            this.LessonGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // songXmlBrowseButton
            // 
            this.songXmlBrowseButton.Location = new System.Drawing.Point(363, 16);
            this.songXmlBrowseButton.Name = "songXmlBrowseButton";
            this.songXmlBrowseButton.Size = new System.Drawing.Size(62, 23);
            this.songXmlBrowseButton.TabIndex = 1;
            this.songXmlBrowseButton.Text = "Browse";
            this.songXmlBrowseButton.UseVisualStyleBackColor = true;
            this.songXmlBrowseButton.Click += new System.EventHandler(this.songXmlBrowseButton_Click);
            // 
            // addArrangementButton
            // 
            this.addArrangementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addArrangementButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addArrangementButton.Location = new System.Drawing.Point(290, 575);
            this.addArrangementButton.Name = "addArrangementButton";
            this.addArrangementButton.Size = new System.Drawing.Size(72, 29);
            this.addArrangementButton.TabIndex = 20;
            this.addArrangementButton.Text = "Ok";
            this.addArrangementButton.UseVisualStyleBackColor = false;
            this.addArrangementButton.Click += new System.EventHandler(this.addArrangementButton_Click);
            // 
            // arrangementTypeCombo
            // 
            this.arrangementTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrangementTypeCombo.FormattingEnabled = true;
            this.arrangementTypeCombo.Location = new System.Drawing.Point(54, 18);
            this.arrangementTypeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.arrangementTypeCombo.Name = "arrangementTypeCombo";
            this.arrangementTypeCombo.Size = new System.Drawing.Size(152, 21);
            this.arrangementTypeCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Type:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cancelButton.Location = new System.Drawing.Point(368, 575);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 29);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // toneBaseCombo
            // 
            this.toneBaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneBaseCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneBaseCombo.FormattingEnabled = true;
            this.toneBaseCombo.Location = new System.Drawing.Point(70, 18);
            this.toneBaseCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneBaseCombo.Name = "toneBaseCombo";
            this.toneBaseCombo.Size = new System.Drawing.Size(134, 21);
            this.toneBaseCombo.TabIndex = 12;
            // 
            // scrollSpeedTrackBar
            // 
            this.scrollSpeedTrackBar.AutoSize = false;
            this.scrollSpeedTrackBar.Location = new System.Drawing.Point(40, 18);
            this.scrollSpeedTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.scrollSpeedTrackBar.Maximum = 45;
            this.scrollSpeedTrackBar.Minimum = 10;
            this.scrollSpeedTrackBar.Name = "scrollSpeedTrackBar";
            this.scrollSpeedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scrollSpeedTrackBar.Size = new System.Drawing.Size(130, 23);
            this.scrollSpeedTrackBar.TabIndex = 5;
            this.scrollSpeedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scrollSpeedTrackBar.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Slowest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(167, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fastest";
            // 
            // scrollSpeedDisplay
            // 
            this.scrollSpeedDisplay.AutoSize = true;
            this.scrollSpeedDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scrollSpeedDisplay.Location = new System.Drawing.Point(69, 39);
            this.scrollSpeedDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scrollSpeedDisplay.Name = "scrollSpeedDisplay";
            this.scrollSpeedDisplay.Size = new System.Drawing.Size(71, 13);
            this.scrollSpeedDisplay.TabIndex = 36;
            this.scrollSpeedDisplay.Text = "{Scroll Value}";
            // 
            // Picked
            // 
            this.Picked.AutoSize = true;
            this.Picked.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Picked.Location = new System.Drawing.Point(123, 99);
            this.Picked.Name = "Picked";
            this.Picked.Size = new System.Drawing.Size(85, 17);
            this.Picked.TabIndex = 7;
            this.Picked.Text = "Bass Picked";
            this.Picked.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Name:";
            // 
            // arrangementNameCombo
            // 
            this.arrangementNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrangementNameCombo.FormattingEnabled = true;
            this.arrangementNameCombo.Location = new System.Drawing.Point(54, 43);
            this.arrangementNameCombo.Margin = new System.Windows.Forms.Padding(2);
            this.arrangementNameCombo.Name = "arrangementNameCombo";
            this.arrangementNameCombo.Size = new System.Drawing.Size(152, 21);
            this.arrangementNameCombo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tuning:";
            // 
            // tuningComboBox
            // 
            this.tuningComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tuningComboBox.FormattingEnabled = true;
            this.tuningComboBox.Location = new System.Drawing.Point(54, 68);
            this.tuningComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tuningComboBox.Name = "tuningComboBox";
            this.tuningComboBox.Size = new System.Drawing.Size(119, 21);
            this.tuningComboBox.TabIndex = 4;
            // 
            // gbTone
            // 
            this.gbTone.Controls.Add(this.disableTonesCheckbox);
            this.gbTone.Controls.Add(this.label10);
            this.gbTone.Controls.Add(this.toneDCombo);
            this.gbTone.Controls.Add(this.label11);
            this.gbTone.Controls.Add(this.toneCCombo);
            this.gbTone.Controls.Add(this.label9);
            this.gbTone.Controls.Add(this.toneBCombo);
            this.gbTone.Controls.Add(this.lblToneA);
            this.gbTone.Controls.Add(this.toneBaseCombo);
            this.gbTone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbTone.Location = new System.Drawing.Point(8, 228);
            this.gbTone.Name = "gbTone";
            this.gbTone.Size = new System.Drawing.Size(435, 92);
            this.gbTone.TabIndex = 42;
            this.gbTone.TabStop = false;
            this.gbTone.Text = "Tone Selector";
            // 
            // disableTonesCheckbox
            // 
            this.disableTonesCheckbox.AutoSize = true;
            this.disableTonesCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.disableTonesCheckbox.Location = new System.Drawing.Point(72, 73);
            this.disableTonesCheckbox.Name = "disableTonesCheckbox";
            this.disableTonesCheckbox.Size = new System.Drawing.Size(266, 17);
            this.disableTonesCheckbox.TabIndex = 45;
            this.disableTonesCheckbox.Text = "Disable tone slot changes to prevent auto-tone fail.";
            this.disableTonesCheckbox.UseVisualStyleBackColor = true;
            this.disableTonesCheckbox.CheckedChanged += new System.EventHandler(this.disableTonesCheckbox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(215, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Tone D:";
            // 
            // toneDCombo
            // 
            this.toneDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneDCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneDCombo.FormattingEnabled = true;
            this.toneDCombo.Location = new System.Drawing.Point(289, 46);
            this.toneDCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneDCombo.Name = "toneDCombo";
            this.toneDCombo.Size = new System.Drawing.Size(134, 21);
            this.toneDCombo.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(215, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tone C:";
            // 
            // toneCCombo
            // 
            this.toneCCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneCCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneCCombo.FormattingEnabled = true;
            this.toneCCombo.Location = new System.Drawing.Point(289, 21);
            this.toneCCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneCCombo.Name = "toneCCombo";
            this.toneCCombo.Size = new System.Drawing.Size(134, 21);
            this.toneCCombo.TabIndex = 16;
            this.toneCCombo.SelectedIndexChanged += new System.EventHandler(this.toneCombo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(4, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Tone B:";
            // 
            // toneBCombo
            // 
            this.toneBCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneBCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneBCombo.FormattingEnabled = true;
            this.toneBCombo.Location = new System.Drawing.Point(70, 46);
            this.toneBCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneBCombo.Name = "toneBCombo";
            this.toneBCombo.Size = new System.Drawing.Size(134, 21);
            this.toneBCombo.TabIndex = 14;
            this.toneBCombo.SelectedIndexChanged += new System.EventHandler(this.toneCombo_SelectedIndexChanged);
            // 
            // lblToneA
            // 
            this.lblToneA.AutoSize = true;
            this.lblToneA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToneA.Location = new System.Drawing.Point(4, 21);
            this.lblToneA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToneA.Name = "lblToneA";
            this.lblToneA.Size = new System.Drawing.Size(34, 13);
            this.lblToneA.TabIndex = 45;
            this.lblToneA.Text = "Base:";
            // 
            // gbDLCId
            // 
            this.gbDLCId.Controls.Add(this.PersistentId);
            this.gbDLCId.Controls.Add(this.MasterId);
            this.gbDLCId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbDLCId.Location = new System.Drawing.Point(5, 522);
            this.gbDLCId.Name = "gbDLCId";
            this.gbDLCId.Size = new System.Drawing.Size(435, 47);
            this.gbDLCId.TabIndex = 33;
            this.gbDLCId.TabStop = false;
            this.gbDLCId.Text = "Arrangement Identification";
            this.gbDLCId.Enter += new System.EventHandler(this.GroupBox3Enter);
            // 
            // PersistentId
            // 
            this.PersistentId.Cue = "PersistentID";
            this.PersistentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PersistentId.ForeColor = System.Drawing.Color.Gray;
            this.PersistentId.Location = new System.Drawing.Point(156, 19);
            this.PersistentId.Name = "PersistentId";
            this.PersistentId.Size = new System.Drawing.Size(269, 20);
            this.PersistentId.TabIndex = 19;
            // 
            // MasterId
            // 
            this.MasterId.Cue = "MasterID";
            this.MasterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MasterId.ForeColor = System.Drawing.Color.Gray;
            this.MasterId.Location = new System.Drawing.Point(6, 19);
            this.MasterId.Name = "MasterId";
            this.MasterId.Size = new System.Drawing.Size(144, 20);
            this.MasterId.TabIndex = 18;
            // 
            // gbXmlDefinition
            // 
            this.gbXmlDefinition.Controls.Add(this.XmlFilePath);
            this.gbXmlDefinition.Controls.Add(this.songXmlBrowseButton);
            this.gbXmlDefinition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbXmlDefinition.Location = new System.Drawing.Point(6, 11);
            this.gbXmlDefinition.Name = "gbXmlDefinition";
            this.gbXmlDefinition.Size = new System.Drawing.Size(435, 46);
            this.gbXmlDefinition.TabIndex = 44;
            this.gbXmlDefinition.TabStop = false;
            this.gbXmlDefinition.Text = "Song XML File";
            // 
            // XmlFilePath
            // 
            this.XmlFilePath.Cue = "Song Xml File (*.xml)";
            this.XmlFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.XmlFilePath.ForeColor = System.Drawing.Color.Gray;
            this.XmlFilePath.Location = new System.Drawing.Point(10, 17);
            this.XmlFilePath.Name = "XmlFilePath";
            this.XmlFilePath.Size = new System.Drawing.Size(347, 20);
            this.XmlFilePath.TabIndex = 0;
            // 
            // gbArrInfo
            // 
            this.gbArrInfo.Controls.Add(this.tuningEditButton);
            this.gbArrInfo.Controls.Add(this.BonusCheckBox);
            this.gbArrInfo.Controls.Add(this.gbTuningPitch);
            this.gbArrInfo.Controls.Add(this.Picked);
            this.gbArrInfo.Controls.Add(this.gbScrollSpeed);
            this.gbArrInfo.Controls.Add(this.label4);
            this.gbArrInfo.Controls.Add(this.arrangementTypeCombo);
            this.gbArrInfo.Controls.Add(this.label1);
            this.gbArrInfo.Controls.Add(this.arrangementNameCombo);
            this.gbArrInfo.Controls.Add(this.label6);
            this.gbArrInfo.Controls.Add(this.tuningComboBox);
            this.gbArrInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbArrInfo.Location = new System.Drawing.Point(6, 64);
            this.gbArrInfo.Name = "gbArrInfo";
            this.gbArrInfo.Size = new System.Drawing.Size(435, 130);
            this.gbArrInfo.TabIndex = 45;
            this.gbArrInfo.TabStop = false;
            this.gbArrInfo.Text = "Arrangement Information";
            // 
            // tuningEditButton
            // 
            this.tuningEditButton.Location = new System.Drawing.Point(178, 67);
            this.tuningEditButton.Name = "tuningEditButton";
            this.tuningEditButton.Size = new System.Drawing.Size(28, 23);
            this.tuningEditButton.TabIndex = 2;
            this.tuningEditButton.Text = "...";
            this.tuningEditButton.UseVisualStyleBackColor = true;
            this.tuningEditButton.Click += new System.EventHandler(this.tuningEditButton_Click);
            // 
            // BonusCheckBox
            // 
            this.BonusCheckBox.AutoSize = true;
            this.BonusCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BonusCheckBox.Location = new System.Drawing.Point(2, 99);
            this.BonusCheckBox.Name = "BonusCheckBox";
            this.BonusCheckBox.Size = new System.Drawing.Size(119, 17);
            this.BonusCheckBox.TabIndex = 44;
            this.BonusCheckBox.Text = "Bonus Arrangement";
            this.BonusCheckBox.UseVisualStyleBackColor = true;
            // 
            // gbTuningPitch
            // 
            this.gbTuningPitch.Controls.Add(this.noteDisplay);
            this.gbTuningPitch.Controls.Add(this.frequencyTB);
            this.gbTuningPitch.Controls.Add(this.centOffsetDisplay);
            this.gbTuningPitch.Controls.Add(this.label2);
            this.gbTuningPitch.Controls.Add(this.label14);
            this.gbTuningPitch.Controls.Add(this.label7);
            this.gbTuningPitch.Controls.Add(this.label13);
            this.gbTuningPitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbTuningPitch.Location = new System.Drawing.Point(214, 70);
            this.gbTuningPitch.Name = "gbTuningPitch";
            this.gbTuningPitch.Size = new System.Drawing.Size(211, 55);
            this.gbTuningPitch.TabIndex = 43;
            this.gbTuningPitch.TabStop = false;
            this.gbTuningPitch.Text = "Tuning Pitch";
            // 
            // noteDisplay
            // 
            this.noteDisplay.AutoSize = true;
            this.noteDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.noteDisplay.Location = new System.Drawing.Point(168, 20);
            this.noteDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noteDisplay.Name = "noteDisplay";
            this.noteDisplay.Size = new System.Drawing.Size(36, 13);
            this.noteDisplay.TabIndex = 48;
            this.noteDisplay.Text = "{note}";
            // 
            // frequencyTB
            // 
            this.frequencyTB.Cue = "";
            this.frequencyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.frequencyTB.ForeColor = System.Drawing.Color.Black;
            this.frequencyTB.Location = new System.Drawing.Point(71, 17);
            this.frequencyTB.MaxLength = 5;
            this.frequencyTB.Name = "frequencyTB";
            this.frequencyTB.Size = new System.Drawing.Size(44, 20);
            this.frequencyTB.TabIndex = 20;
            this.frequencyTB.Text = "440";
            this.frequencyTB.TextChanged += new System.EventHandler(this.frequencyTB_TextChanged);
            // 
            // centOffsetDisplay
            // 
            this.centOffsetDisplay.AutoSize = true;
            this.centOffsetDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centOffsetDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.centOffsetDisplay.Location = new System.Drawing.Point(67, 41);
            this.centOffsetDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.centOffsetDisplay.Name = "centOffsetDisplay";
            this.centOffsetDisplay.Size = new System.Drawing.Size(64, 13);
            this.centOffsetDisplay.TabIndex = 46;
            this.centOffsetDisplay.Text = "{centOffset}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Frequency:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(138, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Offset:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(115, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "hz";
            // 
            // gbScrollSpeed
            // 
            this.gbScrollSpeed.Controls.Add(this.scrollSpeedTrackBar);
            this.gbScrollSpeed.Controls.Add(this.label5);
            this.gbScrollSpeed.Controls.Add(this.label3);
            this.gbScrollSpeed.Controls.Add(this.scrollSpeedDisplay);
            this.gbScrollSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbScrollSpeed.Location = new System.Drawing.Point(214, 12);
            this.gbScrollSpeed.Name = "gbScrollSpeed";
            this.gbScrollSpeed.Size = new System.Drawing.Size(211, 52);
            this.gbScrollSpeed.TabIndex = 42;
            this.gbScrollSpeed.TabStop = false;
            this.gbScrollSpeed.Text = "Scroll Speed";
            // 
            // gbGameplayPath
            // 
            this.gbGameplayPath.Controls.Add(this.routeMaskNoneRadio);
            this.gbGameplayPath.Controls.Add(this.routeMaskBassRadio);
            this.gbGameplayPath.Controls.Add(this.routeMaskRhythmRadio);
            this.gbGameplayPath.Controls.Add(this.routeMaskLeadRadio);
            this.gbGameplayPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbGameplayPath.Location = new System.Drawing.Point(6, 195);
            this.gbGameplayPath.Name = "gbGameplayPath";
            this.gbGameplayPath.Size = new System.Drawing.Size(435, 33);
            this.gbGameplayPath.TabIndex = 34;
            this.gbGameplayPath.TabStop = false;
            this.gbGameplayPath.Text = "Gameplay Path";
            // 
            // routeMaskNoneRadio
            // 
            this.routeMaskNoneRadio.AutoSize = true;
            this.routeMaskNoneRadio.Checked = true;
            this.routeMaskNoneRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.routeMaskNoneRadio.Location = new System.Drawing.Point(344, 10);
            this.routeMaskNoneRadio.Name = "routeMaskNoneRadio";
            this.routeMaskNoneRadio.Size = new System.Drawing.Size(51, 17);
            this.routeMaskNoneRadio.TabIndex = 11;
            this.routeMaskNoneRadio.TabStop = true;
            this.routeMaskNoneRadio.Text = "None";
            this.routeMaskNoneRadio.UseVisualStyleBackColor = true;
            // 
            // routeMaskBassRadio
            // 
            this.routeMaskBassRadio.AutoSize = true;
            this.routeMaskBassRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.routeMaskBassRadio.Location = new System.Drawing.Point(265, 10);
            this.routeMaskBassRadio.Name = "routeMaskBassRadio";
            this.routeMaskBassRadio.Size = new System.Drawing.Size(48, 17);
            this.routeMaskBassRadio.TabIndex = 10;
            this.routeMaskBassRadio.Text = "Bass";
            this.routeMaskBassRadio.UseVisualStyleBackColor = true;
            // 
            // routeMaskRhythmRadio
            // 
            this.routeMaskRhythmRadio.AutoSize = true;
            this.routeMaskRhythmRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.routeMaskRhythmRadio.Location = new System.Drawing.Point(178, 10);
            this.routeMaskRhythmRadio.Name = "routeMaskRhythmRadio";
            this.routeMaskRhythmRadio.Size = new System.Drawing.Size(61, 17);
            this.routeMaskRhythmRadio.TabIndex = 9;
            this.routeMaskRhythmRadio.Text = "Rhythm";
            this.routeMaskRhythmRadio.UseVisualStyleBackColor = true;
            // 
            // routeMaskLeadRadio
            // 
            this.routeMaskLeadRadio.AutoSize = true;
            this.routeMaskLeadRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.routeMaskLeadRadio.Location = new System.Drawing.Point(87, 10);
            this.routeMaskLeadRadio.Name = "routeMaskLeadRadio";
            this.routeMaskLeadRadio.Size = new System.Drawing.Size(49, 17);
            this.routeMaskLeadRadio.TabIndex = 8;
            this.routeMaskLeadRadio.Text = "Lead";
            this.routeMaskLeadRadio.UseVisualStyleBackColor = true;
            // 
            // lessonGBFiles
            // 
            this.lessonGBFiles.Controls.Add(this.VideoFilePath);
            this.lessonGBFiles.Controls.Add(this.VideoFolderButtom);
            this.lessonGBFiles.Controls.Add(this.customLUATB);
            this.lessonGBFiles.Controls.Add(this.audioPathTB);
            this.lessonGBFiles.Controls.Add(this.openAudioButton);
            this.lessonGBFiles.Controls.Add(this.customLUAButton);
            this.lessonGBFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lessonGBFiles.Location = new System.Drawing.Point(6, 428);
            this.lessonGBFiles.Name = "lessonGBFiles";
            this.lessonGBFiles.Size = new System.Drawing.Size(437, 94);
            this.lessonGBFiles.TabIndex = 79;
            this.lessonGBFiles.TabStop = false;
            this.lessonGBFiles.Text = "Lesson Files";
            // 
            // customLUATB
            // 
            this.customLUATB.BackColor = System.Drawing.SystemColors.Window;
            this.customLUATB.Cue = "Custom LUA (if not using default)";
            this.customLUATB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customLUATB.ForeColor = System.Drawing.Color.Gray;
            this.customLUATB.Location = new System.Drawing.Point(6, 19);
            this.customLUATB.Name = "customLUATB";
            this.customLUATB.Size = new System.Drawing.Size(366, 20);
            this.customLUATB.TabIndex = 23;
            // 
            // audioPathTB
            // 
            this.audioPathTB.Cue = "Converted audio on Wwise 2013 for Windows, Mac, XBox360 or PS3 (*.wem)";
            this.audioPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.audioPathTB.ForeColor = System.Drawing.Color.Gray;
            this.audioPathTB.Location = new System.Drawing.Point(6, 45);
            this.audioPathTB.Name = "audioPathTB";
            this.audioPathTB.Size = new System.Drawing.Size(366, 20);
            this.audioPathTB.TabIndex = 25;
            // 
            // openAudioButton
            // 
            this.openAudioButton.Location = new System.Drawing.Point(393, 44);
            this.openAudioButton.Name = "openAudioButton";
            this.openAudioButton.Size = new System.Drawing.Size(34, 23);
            this.openAudioButton.TabIndex = 26;
            this.openAudioButton.Text = "...";
            this.openAudioButton.UseVisualStyleBackColor = true;
            // 
            // customLUAButton
            // 
            this.customLUAButton.Location = new System.Drawing.Point(393, 19);
            this.customLUAButton.Name = "customLUAButton";
            this.customLUAButton.Size = new System.Drawing.Size(34, 23);
            this.customLUAButton.TabIndex = 24;
            this.customLUAButton.Text = "...";
            this.customLUAButton.UseVisualStyleBackColor = true;
            // 
            // LessonGB
            // 
            this.LessonGB.Controls.Add(this.LessonDescriptionTB);
            this.LessonGB.Controls.Add(this.VideoCheckBox);
            this.LessonGB.Controls.Add(this.LessonCheckBox);
            this.LessonGB.Controls.Add(this.EtudeNameTB);
            this.LessonGB.Controls.Add(this.GENameTB);
            this.LessonGB.Controls.Add(this.LessonSubHeader);
            this.LessonGB.Controls.Add(this.LessonDisplayName);
            this.LessonGB.Controls.Add(this.LessonNumberTB);
            this.LessonGB.Controls.Add(this.ArtistSortTB);
            this.LessonGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LessonGB.Location = new System.Drawing.Point(6, 324);
            this.LessonGB.Name = "LessonGB";
            this.LessonGB.Size = new System.Drawing.Size(437, 98);
            this.LessonGB.TabIndex = 82;
            this.LessonGB.TabStop = false;
            this.LessonGB.Text = "Lesson Information";
            // 
            // EtudeNameTB
            // 
            this.EtudeNameTB.Cue = "Etude Name";
            this.EtudeNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EtudeNameTB.ForeColor = System.Drawing.Color.Gray;
            this.EtudeNameTB.Location = new System.Drawing.Point(6, 19);
            this.EtudeNameTB.Name = "EtudeNameTB";
            this.EtudeNameTB.Size = new System.Drawing.Size(117, 20);
            this.EtudeNameTB.TabIndex = 7;
            // 
            // GENameTB
            // 
            this.GENameTB.Cue = "GE Name";
            this.GENameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GENameTB.ForeColor = System.Drawing.Color.Gray;
            this.GENameTB.Location = new System.Drawing.Point(129, 19);
            this.GENameTB.Name = "GENameTB";
            this.GENameTB.Size = new System.Drawing.Size(160, 20);
            this.GENameTB.TabIndex = 8;
            // 
            // LessonSubHeader
            // 
            this.LessonSubHeader.Cue = "Lesson Sub Header";
            this.LessonSubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LessonSubHeader.ForeColor = System.Drawing.Color.Gray;
            this.LessonSubHeader.Location = new System.Drawing.Point(129, 43);
            this.LessonSubHeader.Name = "LessonSubHeader";
            this.LessonSubHeader.Size = new System.Drawing.Size(160, 20);
            this.LessonSubHeader.TabIndex = 11;
            // 
            // LessonDisplayName
            // 
            this.LessonDisplayName.Cue = "Lesson Display Name";
            this.LessonDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LessonDisplayName.ForeColor = System.Drawing.Color.Gray;
            this.LessonDisplayName.Location = new System.Drawing.Point(6, 43);
            this.LessonDisplayName.Name = "LessonDisplayName";
            this.LessonDisplayName.Size = new System.Drawing.Size(117, 20);
            this.LessonDisplayName.TabIndex = 10;
            // 
            // LessonNumberTB
            // 
            this.LessonNumberTB.Cue = "Lesson Number";
            this.LessonNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LessonNumberTB.ForeColor = System.Drawing.Color.Gray;
            this.LessonNumberTB.Location = new System.Drawing.Point(295, 19);
            this.LessonNumberTB.Name = "LessonNumberTB";
            this.LessonNumberTB.Size = new System.Drawing.Size(132, 20);
            this.LessonNumberTB.TabIndex = 9;
            // 
            // ArtistSortTB
            // 
            this.ArtistSortTB.Cue = "Lesson Sort Number";
            this.ArtistSortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ArtistSortTB.ForeColor = System.Drawing.Color.Gray;
            this.ArtistSortTB.Location = new System.Drawing.Point(295, 43);
            this.ArtistSortTB.Name = "ArtistSortTB";
            this.ArtistSortTB.Size = new System.Drawing.Size(132, 20);
            this.ArtistSortTB.TabIndex = 12;
            // 
            // LessonCheckBox
            // 
            this.LessonCheckBox.AutoSize = true;
            this.LessonCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LessonCheckBox.Location = new System.Drawing.Point(6, 69);
            this.LessonCheckBox.Name = "LessonCheckBox";
            this.LessonCheckBox.Size = new System.Drawing.Size(60, 17);
            this.LessonCheckBox.TabIndex = 45;
            this.LessonCheckBox.Text = "Lesson";
            this.LessonCheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoCheckBox
            // 
            this.VideoCheckBox.AutoSize = true;
            this.VideoCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VideoCheckBox.Location = new System.Drawing.Point(72, 69);
            this.VideoCheckBox.Name = "VideoCheckBox";
            this.VideoCheckBox.Size = new System.Drawing.Size(53, 17);
            this.VideoCheckBox.TabIndex = 46;
            this.VideoCheckBox.Text = "Video";
            this.VideoCheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoFilePath
            // 
            this.VideoFilePath.Cue = "Converted Video Bink2";
            this.VideoFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VideoFilePath.ForeColor = System.Drawing.Color.Gray;
            this.VideoFilePath.Location = new System.Drawing.Point(5, 71);
            this.VideoFilePath.Name = "VideoFilePath";
            this.VideoFilePath.Size = new System.Drawing.Size(366, 20);
            this.VideoFilePath.TabIndex = 27;
            // 
            // VideoFolderButtom
            // 
            this.VideoFolderButtom.Location = new System.Drawing.Point(392, 70);
            this.VideoFolderButtom.Name = "VideoFolderButtom";
            this.VideoFolderButtom.Size = new System.Drawing.Size(34, 23);
            this.VideoFolderButtom.TabIndex = 28;
            this.VideoFolderButtom.Text = "...";
            this.VideoFolderButtom.UseVisualStyleBackColor = true;
            // 
            // LessonDescriptionTB
            // 
            this.LessonDescriptionTB.Cue = "Lesson Discription";
            this.LessonDescriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LessonDescriptionTB.ForeColor = System.Drawing.Color.Gray;
            this.LessonDescriptionTB.Location = new System.Drawing.Point(131, 66);
            this.LessonDescriptionTB.Name = "LessonDescriptionTB";
            this.LessonDescriptionTB.Size = new System.Drawing.Size(296, 20);
            this.LessonDescriptionTB.TabIndex = 47;
            // 
            // ArrangementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(449, 616);
            this.Controls.Add(this.LessonGB);
            this.Controls.Add(this.lessonGBFiles);
            this.Controls.Add(this.gbGameplayPath);
            this.Controls.Add(this.gbArrInfo);
            this.Controls.Add(this.gbXmlDefinition);
            this.Controls.Add(this.gbDLCId);
            this.Controls.Add(this.gbTone);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addArrangementButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrangementForm";
            this.Text = "Add Arrangement";
            ((System.ComponentModel.ISupportInitialize)(this.scrollSpeedTrackBar)).EndInit();
            this.gbTone.ResumeLayout(false);
            this.gbTone.PerformLayout();
            this.gbDLCId.ResumeLayout(false);
            this.gbDLCId.PerformLayout();
            this.gbXmlDefinition.ResumeLayout(false);
            this.gbXmlDefinition.PerformLayout();
            this.gbArrInfo.ResumeLayout(false);
            this.gbArrInfo.PerformLayout();
            this.gbTuningPitch.ResumeLayout(false);
            this.gbTuningPitch.PerformLayout();
            this.gbScrollSpeed.ResumeLayout(false);
            this.gbScrollSpeed.PerformLayout();
            this.gbGameplayPath.ResumeLayout(false);
            this.gbGameplayPath.PerformLayout();
            this.lessonGBFiles.ResumeLayout(false);
            this.lessonGBFiles.PerformLayout();
            this.LessonGB.ResumeLayout(false);
            this.LessonGB.PerformLayout();
            this.ResumeLayout(false);

        }
        private RocksmithToolkitGUI.CueTextBox PersistentId;
        private RocksmithToolkitGUI.CueTextBox MasterId;
        private System.Windows.Forms.GroupBox gbDLCId;

        #endregion

        private CueTextBox XmlFilePath;
        private System.Windows.Forms.Button songXmlBrowseButton;
        private System.Windows.Forms.Button addArrangementButton;
        private System.Windows.Forms.ComboBox arrangementTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox toneBaseCombo;
        private System.Windows.Forms.TrackBar scrollSpeedTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scrollSpeedDisplay;
        private System.Windows.Forms.CheckBox Picked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox arrangementNameCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tuningComboBox;
        private System.Windows.Forms.GroupBox gbTone;
        
        void GroupBox3Enter(object sender, System.EventArgs e)
        {
        	
        }

        private System.Windows.Forms.Label lblToneA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox toneDCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox toneCCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox toneBCombo;
        private System.Windows.Forms.GroupBox gbXmlDefinition;
        private System.Windows.Forms.GroupBox gbArrInfo;
        private System.Windows.Forms.GroupBox gbScrollSpeed;
        private System.Windows.Forms.GroupBox gbGameplayPath;
        private System.Windows.Forms.RadioButton routeMaskLeadRadio;
        private System.Windows.Forms.RadioButton routeMaskBassRadio;
        private System.Windows.Forms.RadioButton routeMaskRhythmRadio;
        private System.Windows.Forms.RadioButton routeMaskNoneRadio;
        private System.Windows.Forms.Label label7;
        private CueTextBox frequencyTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label centOffsetDisplay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbTuningPitch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label noteDisplay;
        private System.Windows.Forms.CheckBox BonusCheckBox;
        private System.Windows.Forms.CheckBox disableTonesCheckbox;
        private System.Windows.Forms.Button tuningEditButton;
        private System.Windows.Forms.GroupBox lessonGBFiles;
        private CueTextBox customLUATB;
        private CueTextBox audioPathTB;
        private System.Windows.Forms.Button openAudioButton;
        private System.Windows.Forms.Button customLUAButton;
        private System.Windows.Forms.GroupBox LessonGB;
        private CueTextBox EtudeNameTB;
        private CueTextBox GENameTB;
        private CueTextBox LessonSubHeader;
        private CueTextBox LessonDisplayName;
        private CueTextBox LessonNumberTB;
        private CueTextBox ArtistSortTB;
        private System.Windows.Forms.CheckBox LessonCheckBox;
        private System.Windows.Forms.CheckBox VideoCheckBox;
        private CueTextBox VideoFilePath;
        private System.Windows.Forms.Button VideoFolderButtom;
        private CueTextBox LessonDescriptionTB;
    }
}