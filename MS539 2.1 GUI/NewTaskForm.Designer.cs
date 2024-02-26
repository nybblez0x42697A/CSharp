namespace MS539_2._1_GUI
{
    partial class newTaskDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newTaskDialog));
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.cancelNewTaskButton = new System.Windows.Forms.Button();
            this.saveNewTaskButton = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.workspaceTree = new System.Windows.Forms.TreeView();
            this.taskInfoFLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.taskSettingsGB = new System.Windows.Forms.GroupBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.workspaceLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.timelineGB = new System.Windows.Forms.GroupBox();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.deadlineCalendar = new System.Windows.Forms.DateTimePicker();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.startDateCalendar = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.taskSettingsFLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.taskNameFLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.taskInfoFLPanel.SuspendLayout();
            this.taskSettingsGB.SuspendLayout();
            this.timelineGB.SuspendLayout();
            this.taskSettingsFLPanel.SuspendLayout();
            this.taskNameFLPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.descriptionText.Location = new System.Drawing.Point(3, 29);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(274, 235);
            this.descriptionText.TabIndex = 0;
            this.descriptionText.Text = "Description";
            this.descriptionText.Enter += new System.EventHandler(this.richTextBox1_EnterFocus);
            this.descriptionText.Leave += new System.EventHandler(this.richTextBox1_LeaveFocus);
            // 
            // cancelNewTaskButton
            // 
            this.cancelNewTaskButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelNewTaskButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelNewTaskButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelNewTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.cancelNewTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cancelNewTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelNewTaskButton.Location = new System.Drawing.Point(177, 3);
            this.cancelNewTaskButton.Name = "cancelNewTaskButton";
            this.cancelNewTaskButton.Size = new System.Drawing.Size(51, 23);
            this.cancelNewTaskButton.TabIndex = 1;
            this.cancelNewTaskButton.Text = "Cancel";
            this.cancelNewTaskButton.UseVisualStyleBackColor = false;
            // 
            // saveNewTaskButton
            // 
            this.saveNewTaskButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveNewTaskButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveNewTaskButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveNewTaskButton.Enabled = false;
            this.saveNewTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.saveNewTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.saveNewTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveNewTaskButton.Location = new System.Drawing.Point(120, 3);
            this.saveNewTaskButton.Name = "saveNewTaskButton";
            this.saveNewTaskButton.Size = new System.Drawing.Size(51, 23);
            this.saveNewTaskButton.TabIndex = 1;
            this.saveNewTaskButton.Text = "Save";
            this.saveNewTaskButton.UseVisualStyleBackColor = false;
            // 
            // TaskName
            // 
            this.TaskName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TaskName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TaskName.Dock = System.Windows.Forms.DockStyle.Left;
            this.TaskName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaskName.Location = new System.Drawing.Point(3, 3);
            this.TaskName.MaxLength = 200;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(274, 20);
            this.TaskName.TabIndex = 3;
            this.TaskName.Text = "Task Name";
            this.TaskName.Enter += new System.EventHandler(this.taskName_EnterFocus);
            this.TaskName.Leave += new System.EventHandler(this.taskName_LeaveFocus);
            // 
            // workspaceTree
            // 
            this.workspaceTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workspaceTree.HideSelection = false;
            this.workspaceTree.HotTracking = true;
            this.workspaceTree.Location = new System.Drawing.Point(96, 26);
            this.workspaceTree.Name = "workspaceTree";
            this.workspaceTree.Size = new System.Drawing.Size(124, 68);
            this.workspaceTree.TabIndex = 8;
            this.workspaceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.workspaceTree_NodeSelected);
            // 
            // taskInfoFLPanel
            // 
            this.taskInfoFLPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskInfoFLPanel.AutoSize = true;
            this.taskInfoFLPanel.Controls.Add(this.taskSettingsGB);
            this.taskInfoFLPanel.Controls.Add(this.timelineGB);
            this.taskInfoFLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskInfoFLPanel.Location = new System.Drawing.Point(292, -29);
            this.taskInfoFLPanel.Name = "taskInfoFLPanel";
            this.taskInfoFLPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.taskInfoFLPanel.Size = new System.Drawing.Size(232, 285);
            this.taskInfoFLPanel.TabIndex = 9;
            this.taskInfoFLPanel.WrapContents = false;
            // 
            // taskSettingsGB
            // 
            this.taskSettingsGB.Controls.Add(this.priorityLabel);
            this.taskSettingsGB.Controls.Add(this.priorityComboBox);
            this.taskSettingsGB.Controls.Add(this.workspaceLabel);
            this.taskSettingsGB.Controls.Add(this.statusLabel);
            this.taskSettingsGB.Controls.Add(this.statusComboBox);
            this.taskSettingsGB.Controls.Add(this.workspaceTree);
            this.taskSettingsGB.Location = new System.Drawing.Point(3, 28);
            this.taskSettingsGB.Name = "taskSettingsGB";
            this.taskSettingsGB.Size = new System.Drawing.Size(226, 100);
            this.taskSettingsGB.TabIndex = 20;
            this.taskSettingsGB.TabStop = false;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(4, 55);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(38, 13);
            this.priorityLabel.TabIndex = 16;
            this.priorityLabel.Text = "Priority";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.priorityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.priorityComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "ASAP",
            "High",
            "Medium",
            "Low",
            "+ Create New"});
            this.priorityComboBox.Location = new System.Drawing.Point(6, 73);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(84, 21);
            this.priorityComboBox.TabIndex = 15;
            // 
            // workspaceLabel
            // 
            this.workspaceLabel.AutoSize = true;
            this.workspaceLabel.Location = new System.Drawing.Point(93, 10);
            this.workspaceLabel.Name = "workspaceLabel";
            this.workspaceLabel.Size = new System.Drawing.Size(62, 13);
            this.workspaceLabel.TabIndex = 14;
            this.workspaceLabel.Text = "Workspace";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(4, 10);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Todo",
            "Not Started",
            "Completed",
            "Backlog",
            "+ Create New Status"});
            this.statusComboBox.Location = new System.Drawing.Point(6, 28);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(84, 21);
            this.statusComboBox.TabIndex = 2;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // timelineGB
            // 
            this.timelineGB.Controls.Add(this.endTimeLabel);
            this.timelineGB.Controls.Add(this.dateTimePicker2);
            this.timelineGB.Controls.Add(this.durationComboBox);
            this.timelineGB.Controls.Add(this.durationLabel);
            this.timelineGB.Controls.Add(this.startTimeLabel);
            this.timelineGB.Controls.Add(this.startDateLabel);
            this.timelineGB.Controls.Add(this.deadlineCalendar);
            this.timelineGB.Controls.Add(this.deadlineLabel);
            this.timelineGB.Controls.Add(this.startDateCalendar);
            this.timelineGB.Controls.Add(this.dateTimePicker1);
            this.timelineGB.Location = new System.Drawing.Point(3, 134);
            this.timelineGB.Name = "timelineGB";
            this.timelineGB.Size = new System.Drawing.Size(226, 148);
            this.timelineGB.TabIndex = 21;
            this.timelineGB.TabStop = false;
            this.timelineGB.Text = "Timeline";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(114, 67);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 20;
            this.endTimeLabel.Text = "End Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(115, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // durationComboBox
            // 
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "+ New Duration"});
            this.durationComboBox.Location = new System.Drawing.Point(86, 122);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(49, 21);
            this.durationComboBox.TabIndex = 11;
            this.durationComboBox.SelectionChangeCommitted += new System.EventHandler(this.durationComboBox_Selected);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(88, 106);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 14;
            this.durationLabel.Text = "Duration";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(114, 28);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 18;
            this.startTimeLabel.Text = "Start Time";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 28);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 16;
            this.startDateLabel.Text = "Start Date";
            // 
            // deadlineCalendar
            // 
            this.deadlineCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deadlineCalendar.Location = new System.Drawing.Point(6, 83);
            this.deadlineCalendar.Name = "deadlineCalendar";
            this.deadlineCalendar.Size = new System.Drawing.Size(103, 20);
            this.deadlineCalendar.TabIndex = 9;
            this.deadlineCalendar.ValueChanged += new System.EventHandler(this.deadlineCalendar_ValueChanged);
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.ForeColor = System.Drawing.Color.Red;
            this.deadlineLabel.Location = new System.Drawing.Point(6, 67);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(49, 13);
            this.deadlineLabel.TabIndex = 12;
            this.deadlineLabel.Text = "Deadline";
            // 
            // startDateCalendar
            // 
            this.startDateCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateCalendar.Location = new System.Drawing.Point(6, 44);
            this.startDateCalendar.Name = "startDateCalendar";
            this.startDateCalendar.Size = new System.Drawing.Size(103, 20);
            this.startDateCalendar.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // taskSettingsFLPanel
            // 
            this.taskSettingsFLPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.taskSettingsFLPanel.BackColor = System.Drawing.Color.Transparent;
            this.taskSettingsFLPanel.Controls.Add(this.cancelNewTaskButton);
            this.taskSettingsFLPanel.Controls.Add(this.saveNewTaskButton);
            this.taskSettingsFLPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.taskSettingsFLPanel.ForeColor = System.Drawing.Color.Transparent;
            this.taskSettingsFLPanel.Location = new System.Drawing.Point(293, 255);
            this.taskSettingsFLPanel.Name = "taskSettingsFLPanel";
            this.taskSettingsFLPanel.Size = new System.Drawing.Size(231, 28);
            this.taskSettingsFLPanel.TabIndex = 10;
            this.taskSettingsFLPanel.WrapContents = false;
            // 
            // taskNameFLPanel
            // 
            this.taskNameFLPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskNameFLPanel.Controls.Add(this.TaskName);
            this.taskNameFLPanel.Controls.Add(this.descriptionText);
            this.taskNameFLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskNameFLPanel.Location = new System.Drawing.Point(2, 9);
            this.taskNameFLPanel.Name = "taskNameFLPanel";
            this.taskNameFLPanel.Size = new System.Drawing.Size(287, 281);
            this.taskNameFLPanel.TabIndex = 11;
            this.taskNameFLPanel.WrapContents = false;
            // 
            // newTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 285);
            this.Controls.Add(this.taskInfoFLPanel);
            this.Controls.Add(this.taskNameFLPanel);
            this.Controls.Add(this.taskSettingsFLPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(543, 442);
            this.MinimumSize = new System.Drawing.Size(543, 310);
            this.Name = "newTaskDialog";
            this.ShowIcon = false;
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.newTaskForm_Load);
            this.taskInfoFLPanel.ResumeLayout(false);
            this.taskSettingsGB.ResumeLayout(false);
            this.taskSettingsGB.PerformLayout();
            this.timelineGB.ResumeLayout(false);
            this.timelineGB.PerformLayout();
            this.taskSettingsFLPanel.ResumeLayout(false);
            this.taskNameFLPanel.ResumeLayout(false);
            this.taskNameFLPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelNewTaskButton;
        private System.Windows.Forms.Button saveNewTaskButton;
        internal System.Windows.Forms.TextBox TaskName;
        internal System.Windows.Forms.RichTextBox descriptionText;
        internal System.Windows.Forms.TreeView workspaceTree;
        private System.Windows.Forms.FlowLayoutPanel taskInfoFLPanel;
        private System.Windows.Forms.FlowLayoutPanel taskSettingsFLPanel;
        private System.Windows.Forms.FlowLayoutPanel taskNameFLPanel;
        internal System.Windows.Forms.ComboBox statusComboBox;
        internal System.Windows.Forms.DateTimePicker deadlineCalendar;
        internal System.Windows.Forms.Label deadlineLabel;
        internal System.Windows.Forms.Label durationLabel;
        internal System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label startDateLabel;
        internal System.Windows.Forms.DateTimePicker startDateCalendar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox taskSettingsGB;
        private System.Windows.Forms.GroupBox timelineGB;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label workspaceLabel;
        private System.Windows.Forms.Label priorityLabel;
        internal System.Windows.Forms.ComboBox priorityComboBox;
        internal System.Windows.Forms.ComboBox durationComboBox;
    }
}