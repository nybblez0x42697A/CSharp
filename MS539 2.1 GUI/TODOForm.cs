using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using TODO.Classes;

/** This form is used to load tasks from a file and call subsequent forms
 * for creating new tasks to add to the todo list.
 * 
 *  * Updates: 5.1
 *  - Added the usage of string functions from Date objects to improve readability of task list columns.
 *  - Added label edit action to account for the user making changes to tasknames while within the main form.
 *  - Modified logic to update the objects holding the json data to account for user-modified tasks.
 *  
 *   Anticipated Time to Complete: 2 hours
 * 
 *   Actual Time to Complete: 1 hour
 * 
 *  I didn't have to many issues with these updates. It mostly went fairly smoothly. I think I want to add logic to allow editing of the majority
 *  of fields for the tasks, but that depends on time.
 * */

namespace MS539_2._1_GUI
{
    public partial class TODO : Form
    {
        private string jsonFilePath = @"..\..\Resources\tasks.json"; // task file in json format for saving and loading task list.
        private Rootspace Root = new Rootspace();


        public TODO()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(TODOForm_FormClosing);

            // Subscribe to the UnhandledException event for saving if the app crashes.
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        private void TODOForm_Load(object sender, EventArgs e)
        {
            InitializeTaskListView();
            LoadTasks();


        }

        private void TODOForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Save tasks before the application exits unexpectedly
            SaveTasks();
            MessageBox.Show("TODO closed unexpectedly, but managed to save updates to your TODO list.");
        }

        private void LoadTasks()
        {

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                Root = JsonConvert.DeserializeObject<Rootspace>(json) ?? new Rootspace();

                foreach (var obj in Root.Workspaces)
                {


                    // Create a group for each workspace.
                    ListViewGroup group = new ListViewGroup(obj.Key, obj.Key);
                    taskListView.Groups.Add(group);

                    foreach (var task in obj.Value.Tasks)
                    {
                        ListViewItem item = new ListViewItem(new[]{
                            task.Key,
                            task.Value.Description ?? "",
                            task.Value.Workspace ?? obj.Key,
                            task.Value.Status ?? "",
                            task.Value.Priority ?? "",
                            task.Value.StartDate ?? "N/A",
                            task.Value.Deadline ?? "N/A",
                            task.Value.TaskDuration ?? "",
                            task.Value.StartTime ?? "",
                            task.Value.EndTime ?? ""
                        }, group);
                        taskListView.Items.Add(item);
                    }
                }
                taskListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

        private void SaveTasks()
        {
            string json = JsonConvert.SerializeObject(Root, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }


        private void InitializeTaskListView()
        {

            // Add columns to the DataGridView.
            taskListView.Columns.Insert(0, "Name", "Name");
            taskListView.Columns.Add("Description", "Description");
            taskListView.Columns.Add("Workspace", "Workspace");
            taskListView.Columns.Add("Status", "Status");
            taskListView.Columns.Add("Priority", "Priority");
            taskListView.Columns.Add("Start Date", "Start Date");
            taskListView.Columns.Add("Deadline", "Deadline");
            taskListView.Columns.Add("Duration", "Duration");
            taskListView.Columns.Add("Start Time", "Start Time");
            taskListView.Columns.Add("End Time", "End Time");

            taskListView.ShowGroups = true;

        }

        private void newTask_Click(object sender, EventArgs e)
            {
                // Open a dialog to input task information.
                newTaskDialog taskInputDialog = new newTaskDialog(taskListView.Groups);
            
            if (taskInputDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the task text from a TextBox (or any other control).
                string taskText = taskInputDialog.TaskName.Text;

                // Check if the task text is not empty.
                if (!string.IsNullOrEmpty(taskText))
                {
                    try
                    {
                        // Add new task to the Root object for writing to file
                        Task newTask = new Task();
                        newTask.Name = taskText;
                        newTask.Workspace = taskInputDialog.workspaceTree.SelectedNode.Text;

                        newTask.Deadline = taskInputDialog.deadlineCalendar.Value.Date.ToShortDateString();
                        newTask.Status = taskInputDialog.statusComboBox.Text;
                        newTask.Priority = taskInputDialog.priorityComboBox.Text;
                        newTask.StartDate = taskInputDialog.startDateCalendar.Value.Date.ToShortDateString();
                        newTask.Description = taskInputDialog.descriptionText.Text;
                        newTask.StartTime = taskInputDialog.startDateCalendar.Value.Date.ToShortTimeString();
                        newTask.EndTime = taskInputDialog.deadlineCalendar.Value.Date.ToShortTimeString();
                        newTask.TaskDuration = taskInputDialog.durationComboBox.Text;

                        Root.Workspaces[newTask.Workspace].Tasks.Add(newTask.Name, newTask);
                        

                        // Create a new ListViewItem using the task text and add it to the ListView.
                        ListViewItem newItem = new ListViewItem(newTask.Name);
                        newItem.Group = taskListView.Groups[newTask.Workspace];
                        // Set task information in new task list item.
                        newItem.SubItems.Add(newTask.Description);
                        newItem.SubItems.Add(newTask.Workspace);
                        newItem.SubItems.Add(newTask.Status);
                        newItem.SubItems.Add(newTask.Priority);
                        newItem.SubItems.Add(newTask.StartDate);
                        newItem.SubItems.Add(newTask.Deadline);
                        newItem.SubItems.Add(newTask.TaskDuration);
                        newItem.SubItems.Add(newTask.StartTime);
                        newItem.SubItems.Add(newTask.EndTime);

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
                int workspaceColumn = taskListView.Columns.IndexOfKey("Workspace");

                int taskNameColumn = taskListView.Columns.IndexOfKey("Name");
                try
                {

                foreach (ListViewItem item in taskListView.Items)
                {
                    string currentTask = item.SubItems[taskNameColumn].Text;
                    string currentWorkspace = item.SubItems[workspaceColumn].Text;

                    if (item.Selected || item.Checked )
                    {

                        Root.Workspaces[currentWorkspace].Tasks.Remove(currentTask);


                        taskListView.Items.Remove(item);
                    }
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void randomTaskButton_Click(object sender, EventArgs e)
        {
            List<string> incompleteTasks = new List<string>();
            int taskNameColumn = taskListView.Columns.IndexOfKey("Name");
            int workspaceColumn = taskListView.Columns.IndexOfKey("Workspace");

            foreach (ListViewItem item in taskListView.Items)
            {
                string currentTask = item.SubItems[taskNameColumn].Text;
                string currentWorkspace = item.SubItems[workspaceColumn].Text;

                if (Root.Workspaces[currentWorkspace].Tasks[currentTask].Status != "Complete")
                {
                    incompleteTasks.Add(item.SubItems[taskNameColumn].Text);
                }
            }
            // Select only incomplete tasks

            if (incompleteTasks.Count >= 1)
            {
                Random rnd = new Random();
                // Select a random task from the list of incomplete tasks
                var taskOfTheDay = incompleteTasks[rnd.Next(incompleteTasks.Count)];

               MessageBox.Show($"Task of the Day: {taskOfTheDay}");
            }
            else
            {
                MessageBox.Show("No incomplete tasks to choose from.");
            }
        }

        private void taskListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {

            string workspace = taskListView.Items[e.Item].SubItems[taskListView.Columns.IndexOfKey("Workspace")].Text;
            int taskNameColumn = taskListView.Columns.IndexOfKey("Name");
            string oldTaskName = taskListView.Items[e.Item].SubItems[taskNameColumn].Text;

            Root.Workspaces[workspace].Tasks[e.Label] = Root.Workspaces[workspace].Tasks[oldTaskName];
            Root.Workspaces[workspace].Tasks.Remove(oldTaskName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
