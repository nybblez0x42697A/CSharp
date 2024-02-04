using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MS539_2._1_GUI
{
    public partial class TODO : Form
    {

        public TODO()
        {
            InitializeComponent();
            InitializeTaskListView();
        }

        private void TODOForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeTaskListView()
        {
            // Add columns to the DataGridView.
            taskListView.Columns.Insert(0, "Name", "Name");
            taskListView.Columns.Add("Workspace", "Workspace");
            taskListView.Columns.Add("Deadline", "Deadline");
            taskListView.Columns.Add("Status", "Status");
            taskListView.Groups.Add("My Tasks", "My Tasks");
            taskListView.ShowGroups = true;
            taskListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void newTask_Click(object sender, EventArgs e)
            {
                // Open a dialog to input task information.
                newTaskDialog taskInputDialog = new newTaskDialog();
            if (taskInputDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the task text from a TextBox (or any other control).
                string taskText = taskInputDialog.TaskName.Text;

                // Check if the task text is not empty.
                if (!string.IsNullOrEmpty(taskText))
                {
                    try
                    {
                        // Create a new ListViewItem using the task text and add it to the ListView.
                        ListViewItem newItem = new ListViewItem(taskText);
                        newItem.Group = taskListView.Groups[taskInputDialog.workspaceTree.SelectedNode.Text];
                        // Retrieve task information from the dialog.
                        newItem.SubItems.Add(taskInputDialog.workspaceTree.SelectedNode.Text);
                        newItem.SubItems.Add(taskInputDialog.deadlineCalendar.SelectionEnd.ToString());
                        newItem.SubItems.Add(taskInputDialog.statusComboBox.SelectedItem.ToString());
                        // Add the task to the ListView.
                        taskListView.Items.Add(newItem);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
          }

        private void checkBox_CheckChanged(object sender, EventArgs e)
        {
            if (taskListView.CheckedItems.Count > 0)
            { 
                deleteButton.Visible = true;
            }
            else if (taskListView.SelectedItems.Count > 0)
            {
                deleteButton.Visible = true;
            }
            else
            {
                deleteButton.Visible = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected.
            if (taskListView.SelectedItems.Count > 0 || taskListView.CheckedItems.Count > 0 )
            {
                // Remove the selected item.
                foreach (ListViewItem item in taskListView.Items)
                {
                    if(item.Selected || item.Checked)
                    { 
                        taskListView.Items.Remove(item);
                    }
                }
            }
        }

    }
}
