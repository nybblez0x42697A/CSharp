using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_2._1_GUI
{
    public partial class newTaskDialog : Form
    {
        public newTaskDialog()
        {
            InitializeComponent();
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
            if (TaskName.Text.Length > 0)
            {
                saveNewTaskButton.Enabled = true;
            }
            else
            {
                TaskName.Text = "Task Name";
                TaskName.ForeColor = Color.Gray;
                saveNewTaskButton.Enabled = false;
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

    }
}
