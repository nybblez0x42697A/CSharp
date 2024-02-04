using System.Windows.Forms;

namespace MS539_2._1_GUI
{
    partial class TODO
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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskListView = new System.Windows.Forms.ListView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));

            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.Location = new System.Drawing.Point(208, 265);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskButton.MinimumSize = new System.Drawing.Size(26, 28);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(71, 28);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.newTask_Click);
            // 
            // taskListView
            // 
            this.taskListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.taskListView.AllowColumnReorder = true;
            this.taskListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskListView.BackColor = System.Drawing.SystemColors.Control;
            this.taskListView.CheckBoxes = true;
            this.taskListView.HideSelection = false;
            this.taskListView.Location = new System.Drawing.Point(0, 0);
            this.taskListView.Name = "taskListView";
            this.taskListView.Size = new System.Drawing.Size(289, 303);
            this.taskListView.TabIndex = 0;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.Details;
            this.taskListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.checkBox_CheckChanged);
            this.taskListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.checkBox_CheckChanged);
            this.taskListView.SelectedIndexChanged += new System.EventHandler(this.checkBox_CheckChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Location = new System.Drawing.Point(115, 265);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.MinimumSize = new System.Drawing.Size(26, 28);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 28);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Task";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // TODO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(289, 301);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.taskListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(305, 313);
            this.Name = "TODO";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo";
            this.Load += new System.EventHandler(this.TODOForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        internal System.Windows.Forms.ListView taskListView;
        private Button deleteButton;
    }
}

