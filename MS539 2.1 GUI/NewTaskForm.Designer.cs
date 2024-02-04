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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Tasks");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newTaskDialog));
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.cancelNewTaskButton = new System.Windows.Forms.Button();
            this.saveNewTaskButton = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.workspaceTree = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.deadlineCalendar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateCalendar = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            treeNode1.Name = "myTasksRootNode";
            treeNode1.Text = "My Tasks";
            treeNode1.ToolTipText = "Choose a workspace for your new task.";
            this.workspaceTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.workspaceTree.Size = new System.Drawing.Size(124, 68);
            this.workspaceTree.TabIndex = 8;
            this.workspaceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.workspaceTree_NodeSelected);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(292, -29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 285);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.priorityComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.workspaceTree);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Priority";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Workspace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.durationComboBox);
            this.groupBox2.Controls.Add(this.durationLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.startDateLabel);
            this.groupBox2.Controls.Add(this.deadlineCalendar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.startDateCalendar);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(3, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 148);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timeline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "End Time";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Start Time";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Deadline";
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.cancelNewTaskButton);
            this.flowLayoutPanel2.Controls.Add(this.saveNewTaskButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(293, 255);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(231, 28);
            this.flowLayoutPanel2.TabIndex = 10;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.TaskName);
            this.flowLayoutPanel3.Controls.Add(this.descriptionText);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 9);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(287, 281);
            this.flowLayoutPanel3.TabIndex = 11;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // newTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 285);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(543, 442);
            this.MinimumSize = new System.Drawing.Size(543, 310);
            this.Name = "newTaskDialog";
            this.ShowIcon = false;
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.newTaskForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelNewTaskButton;
        private System.Windows.Forms.Button saveNewTaskButton;
        internal System.Windows.Forms.TextBox TaskName;
        internal System.Windows.Forms.RichTextBox descriptionText;
        internal System.Windows.Forms.TreeView workspaceTree;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        internal System.Windows.Forms.ComboBox statusComboBox;
        internal System.Windows.Forms.DateTimePicker deadlineCalendar;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startDateLabel;
        internal System.Windows.Forms.DateTimePicker startDateCalendar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox priorityComboBox;
    }
}