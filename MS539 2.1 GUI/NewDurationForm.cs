using System;
using System.Drawing;
using System.Windows.Forms;

/** This form is used to input a new duration value for a task.
 * 
 * Anticipated Time to Complete: 2 hours
 * 
 * Actual Time to Complete: 2 1/2 hours
 * 
 * Contributing Issues: I had to look up how to use the tool tip feature, which took a little bit of time. However,
 * the issue that took me the longest was trying to figure out how to get the OK button to work properly with the requirement
 * for showing 2 ways to check integer values and handle the errors without the dialog result being set to OK and passed
 * back to the calling form. Ultimately, I got it to work by setting the dialog result to none when the text in the text box
 * is changed to something other than an integer, and then setting it back to OK when the text is changed to an integer.
 * Probably not the most elegant solution, but it works. I'll keep the code in the text box changed event for the final version
 * and remove the code from the OK button click event after submitting this assignment. I like the way the text box changes color
 * in real time as the user types, and the tool tip is a nice touch. I also like the way the OK button is disabled when the text
 * is not an integer. I think the form is simple and easy to use, and I'm confident any user will know what to do when they see it.
 * */

namespace MS539_2._1_GUI
{
    public partial class NewDurationForm : Form
    {
        public NewDurationForm()
        {
            InitializeComponent();
        }

        private void newDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(newDurationTextBox.Text, out int result) == false && newDurationTextBox.Text != "")
            {
                    newDurationTextBox.BackColor = Color.PaleVioletRed;
                    toolTip1.Show("Value must be an integer", newDurationTextBox);
                    newDurationOK.DialogResult = DialogResult.None;
            }
            else
            {
                    newDurationTextBox.BackColor = Color.White;
                    toolTip1.Hide(newDurationTextBox);
                    newDurationOK.Enabled = true;
                    newDurationOK.DialogResult = DialogResult.OK;
             }
        }

        private void newDurationOK_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(newDurationTextBox.Text);
            }
            catch
            {
                DialogResult result = MessageBox.Show("Value must be an integer", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                       newDurationCancel.PerformClick();
                }
            }
        }
    }
}
