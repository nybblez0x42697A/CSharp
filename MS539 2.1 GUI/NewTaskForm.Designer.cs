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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Workspaces", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.cancelNewTaskButton = new System.Windows.Forms.Button();
            this.saveNewTaskButton = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.deadlineCalendar = new System.Windows.Forms.MonthCalendar();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.workspaceTree = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.descriptionText.Size = new System.Drawing.Size(277, 172);
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
            this.TaskName.Size = new System.Drawing.Size(277, 20);
            this.TaskName.TabIndex = 3;
            this.TaskName.Text = "Task Name";
            this.TaskName.Enter += new System.EventHandler(this.taskName_EnterFocus);
            this.TaskName.Leave += new System.EventHandler(this.taskName_LeaveFocus);
            // 
            // deadlineCalendar
            // 
            this.deadlineCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deadlineCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel3.SetFlowBreak(this.deadlineCalendar, true);
            this.deadlineCalendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deadlineCalendar.Location = new System.Drawing.Point(9, 226);
            this.deadlineCalendar.MaxSelectionCount = 1;
            this.deadlineCalendar.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.deadlineCalendar.Name = "deadlineCalendar";
            this.deadlineCalendar.ShowWeekNumbers = true;
            this.deadlineCalendar.TabIndex = 4;
            this.deadlineCalendar.TrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.deadlineLabel.ForeColor = System.Drawing.Color.Red;
            this.deadlineLabel.Location = new System.Drawing.Point(3, 204);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(76, 13);
            this.deadlineLabel.TabIndex = 7;
            this.deadlineLabel.Text = "Task Deadline";
            this.deadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workspaceTree
            // 
            this.workspaceTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFlowBreak(this.workspaceTree, true);
            this.workspaceTree.HideSelection = false;
            this.workspaceTree.HotTracking = true;
            this.workspaceTree.Location = new System.Drawing.Point(3, 55);
            this.workspaceTree.Name = "workspaceTree";
            treeNode1.Name = "Node1";
            treeNode1.Text = "My Tasks";
            treeNode1.ToolTipText = "Default Workspace";
            treeNode2.Name = "workspaceRootNode";
            treeNode2.Text = "Workspaces";
            treeNode2.ToolTipText = "Choose a workspace for your new task.";
            this.workspaceTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.workspaceTree.Size = new System.Drawing.Size(223, 172);
            this.workspaceTree.TabIndex = 8;
            this.workspaceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.workspaceTree_NodeSelected);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.statusComboBox);
            this.flowLayoutPanel1.Controls.Add(this.workspaceTree);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(292, -16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 419);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.DisplayMember = "Not Started";
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "To-Do",
            "In Progress",
            "Complete",
            "Backlog",
            "Not Started"});
            this.statusComboBox.Location = new System.Drawing.Point(3, 28);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(223, 21);
            this.statusComboBox.TabIndex = 2;
            this.statusComboBox.ValueMember = "Not Started";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.cancelNewTaskButton);
            this.flowLayoutPanel2.Controls.Add(this.saveNewTaskButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(290, 374);
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
            this.flowLayoutPanel3.Controls.Add(this.deadlineLabel);
            this.flowLayoutPanel3.Controls.Add(this.deadlineCalendar);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(283, 398);
            this.flowLayoutPanel3.TabIndex = 11;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // newTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 403);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.MaximumSize = new System.Drawing.Size(543, 442);
            this.MinimumSize = new System.Drawing.Size(543, 442);
            this.Name = "newTaskDialog";
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.newTaskForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        internal System.Windows.Forms.MonthCalendar deadlineCalendar;
        private System.Windows.Forms.Label deadlineLabel;
        internal System.Windows.Forms.TreeView workspaceTree;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        internal System.Windows.Forms.ComboBox statusComboBox;
    }
}