namespace MS539_2._1_GUI
{
    partial class NewDurationForm
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
            this.components = new System.ComponentModel.Container();
            this.newDurationTextBox = new System.Windows.Forms.TextBox();
            this.newDurationOK = new System.Windows.Forms.Button();
            this.newDurationCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // newDurationTextBox
            // 
            this.newDurationTextBox.Location = new System.Drawing.Point(12, 35);
            this.newDurationTextBox.MaxLength = 5;
            this.newDurationTextBox.Name = "newDurationTextBox";
            this.newDurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.newDurationTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.newDurationTextBox, "Numerical Value");
            this.newDurationTextBox.TextChanged += new System.EventHandler(this.newDurationTextBox_TextChanged);
            // 
            // newDurationOK
            // 
            this.newDurationOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newDurationOK.Location = new System.Drawing.Point(12, 70);
            this.newDurationOK.Name = "newDurationOK";
            this.newDurationOK.Size = new System.Drawing.Size(75, 23);
            this.newDurationOK.TabIndex = 1;
            this.newDurationOK.Text = "OK";
            this.newDurationOK.UseVisualStyleBackColor = true;
            this.newDurationOK.Click += new System.EventHandler(this.newDurationOK_Click);
            // 
            // newDurationCancel
            // 
            this.newDurationCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newDurationCancel.Location = new System.Drawing.Point(107, 70);
            this.newDurationCancel.Name = "newDurationCancel";
            this.newDurationCancel.Size = new System.Drawing.Size(75, 23);
            this.newDurationCancel.TabIndex = 2;
            this.newDurationCancel.Text = "Cancel";
            this.newDurationCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a new duration value";
            // 
            // NewDurationForm
            // 
            this.AcceptButton = this.newDurationOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.newDurationCancel;
            this.ClientSize = new System.Drawing.Size(194, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDurationCancel);
            this.Controls.Add(this.newDurationOK);
            this.Controls.Add(this.newDurationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(210, 140);
            this.Name = "NewDurationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Duration";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button newDurationOK;
        internal System.Windows.Forms.Button newDurationCancel;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox newDurationTextBox;
        internal System.Windows.Forms.ToolTip toolTip1;
    }
}