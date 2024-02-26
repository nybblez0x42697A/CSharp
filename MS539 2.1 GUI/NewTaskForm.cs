using System;
using System.Drawing;
using System.Windows.Forms;

namespace MS539_2._1_GUI
{
    public partial class newTaskDialog : Form
    {
        public newTaskDialog(ListViewGroupCollection workspaces)
        {
            InitializeComponent();
            workspaceTree_Load(workspaces);
        }

        private void newTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_EnterFocus(object sender, EventArgs e)
        {
            if (descriptionText.Text == "Description")
            {
                descriptionText.Text = "";
                descriptionText.ForeColor = Color.Black;
            }
        }

        private void richTextBox1_LeaveFocus(object sender, EventArgs e)
        {
            if (descriptionText.Text.Length == 0)
            {
                descriptionText.Text = "Description";
                descriptionText.ForeColor = Color.Gray;
            }
        }
        private void taskName_EnterFocus(object sender, EventArgs e)
        {
            if (TaskName.Text == "Task Name")
            {
                TaskName.Text = "";
                TaskName.ForeColor = Color.Black;
            }
        }

        private void taskName_LeaveFocus(object sender, EventArgs e)
        {
            if (TaskName.Text.Length == 0)
            {
                TaskName.Text = "Task Name";
                TaskName.ForeColor = Color.Gray;
            }
        }

        private void workspaceTree_Load(ListViewGroupCollection workspaces)
        {
            foreach( var workspace in workspaces )
            {
                workspaceTree.Nodes.Add(workspace.ToString());
            }
        }

        private void workspaceTree_NodeSelected(object sender, TreeViewEventArgs e)
        {
            if(workspaceTree.SelectedNode != null)
            {
                saveNewTaskButton.Enabled = true;
            }
            else
            {
                saveNewTaskButton.Enabled = false;
            }
        }


        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deadlineCalendar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void durationComboBox_Selected(object sender, EventArgs e)
        {
            if (durationComboBox.SelectedItem.ToString() == "+ New Duration")
            {
                NewDurationForm newDurationInput = new NewDurationForm();
                if (newDurationInput.ShowDialog() == DialogResult.OK)
                {
                    durationComboBox.Items.Insert(durationComboBox.Items.Count - 1, newDurationInput.newDurationTextBox.Text);
                    durationComboBox.SelectedItem = newDurationInput.newDurationTextBox.Text;
                }
            }
        }
    }
}
