
namespace WindowsUI
{
    partial class DriverLicenseExam
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
            this.gradeButton = new System.Windows.Forms.Button();
            this.driverExamHeader = new System.Windows.Forms.Label();
            this.driverExamHeader2 = new System.Windows.Forms.Label();
            this.passOrFailLabel = new System.Windows.Forms.Label();
            this.numCorrectLabel = new System.Windows.Forms.Label();
            this.numIncorrectLabel = new System.Windows.Forms.Label();
            this.incorrectQLabel = new System.Windows.Forms.Label();
            this.passOrFailTextBox = new System.Windows.Forms.TextBox();
            this.numIncorrectTextBox = new System.Windows.Forms.TextBox();
            this.numCorrectTextBox = new System.Windows.Forms.TextBox();
            this.incorrectQListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradeButton.Font = new System.Drawing.Font("Myanmar Text", 28.14545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeButton.Location = new System.Drawing.Point(270, 75);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(255, 62);
            this.gradeButton.TabIndex = 0;
            this.gradeButton.Text = "GRADE";
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // driverExamHeader
            // 
            this.driverExamHeader.AutoSize = true;
            this.driverExamHeader.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverExamHeader.Location = new System.Drawing.Point(239, 9);
            this.driverExamHeader.Name = "driverExamHeader";
            this.driverExamHeader.Size = new System.Drawing.Size(348, 34);
            this.driverExamHeader.TabIndex = 1;
            this.driverExamHeader.Text = "Your Driver\'s Exam has been submitted!";
            // 
            // driverExamHeader2
            // 
            this.driverExamHeader2.AutoSize = true;
            this.driverExamHeader2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverExamHeader2.Location = new System.Drawing.Point(275, 43);
            this.driverExamHeader2.Name = "driverExamHeader2";
            this.driverExamHeader2.Size = new System.Drawing.Size(250, 29);
            this.driverExamHeader2.TabIndex = 2;
            this.driverExamHeader2.Text = "Click \"GRADE\" to see how you did.";
            // 
            // passOrFailLabel
            // 
            this.passOrFailLabel.AutoSize = true;
            this.passOrFailLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passOrFailLabel.Location = new System.Drawing.Point(32, 206);
            this.passOrFailLabel.Name = "passOrFailLabel";
            this.passOrFailLabel.Size = new System.Drawing.Size(98, 34);
            this.passOrFailLabel.TabIndex = 3;
            this.passOrFailLabel.Text = "Pass / Fail";
            // 
            // numCorrectLabel
            // 
            this.numCorrectLabel.AutoSize = true;
            this.numCorrectLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCorrectLabel.Location = new System.Drawing.Point(171, 206);
            this.numCorrectLabel.Name = "numCorrectLabel";
            this.numCorrectLabel.Size = new System.Drawing.Size(155, 34);
            this.numCorrectLabel.TabIndex = 4;
            this.numCorrectLabel.Text = "Number Correct:";
            // 
            // numIncorrectLabel
            // 
            this.numIncorrectLabel.AutoSize = true;
            this.numIncorrectLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIncorrectLabel.Location = new System.Drawing.Point(372, 206);
            this.numIncorrectLabel.Name = "numIncorrectLabel";
            this.numIncorrectLabel.Size = new System.Drawing.Size(168, 34);
            this.numIncorrectLabel.TabIndex = 5;
            this.numIncorrectLabel.Text = "Number Incorrect:";
            // 
            // incorrectQLabel
            // 
            this.incorrectQLabel.AutoSize = true;
            this.incorrectQLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectQLabel.Location = new System.Drawing.Point(575, 206);
            this.incorrectQLabel.Name = "incorrectQLabel";
            this.incorrectQLabel.Size = new System.Drawing.Size(183, 34);
            this.incorrectQLabel.TabIndex = 6;
            this.incorrectQLabel.Text = "Incorrect Questions:";
            // 
            // passOrFailTextBox
            // 
            this.passOrFailTextBox.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passOrFailTextBox.Location = new System.Drawing.Point(38, 243);
            this.passOrFailTextBox.Name = "passOrFailTextBox";
            this.passOrFailTextBox.Size = new System.Drawing.Size(100, 32);
            this.passOrFailTextBox.TabIndex = 7;
            // 
            // numIncorrectTextBox
            // 
            this.numIncorrectTextBox.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIncorrectTextBox.Location = new System.Drawing.Point(400, 243);
            this.numIncorrectTextBox.Name = "numIncorrectTextBox";
            this.numIncorrectTextBox.Size = new System.Drawing.Size(100, 32);
            this.numIncorrectTextBox.TabIndex = 9;
            // 
            // numCorrectTextBox
            // 
            this.numCorrectTextBox.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCorrectTextBox.Location = new System.Drawing.Point(189, 243);
            this.numCorrectTextBox.Name = "numCorrectTextBox";
            this.numCorrectTextBox.Size = new System.Drawing.Size(100, 32);
            this.numCorrectTextBox.TabIndex = 10;
            // 
            // incorrectQListBox
            // 
            this.incorrectQListBox.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectQListBox.FormattingEnabled = true;
            this.incorrectQListBox.ItemHeight = 23;
            this.incorrectQListBox.Location = new System.Drawing.Point(596, 243);
            this.incorrectQListBox.Name = "incorrectQListBox";
            this.incorrectQListBox.Size = new System.Drawing.Size(120, 96);
            this.incorrectQListBox.TabIndex = 11;
            // 
            // DriverLicenseExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incorrectQListBox);
            this.Controls.Add(this.numCorrectTextBox);
            this.Controls.Add(this.numIncorrectTextBox);
            this.Controls.Add(this.passOrFailTextBox);
            this.Controls.Add(this.incorrectQLabel);
            this.Controls.Add(this.numIncorrectLabel);
            this.Controls.Add(this.numCorrectLabel);
            this.Controls.Add(this.passOrFailLabel);
            this.Controls.Add(this.driverExamHeader2);
            this.Controls.Add(this.driverExamHeader);
            this.Controls.Add(this.gradeButton);
            this.Name = "DriverLicenseExam";
            this.Text = "Driver\'s License Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Label driverExamHeader;
        private System.Windows.Forms.Label driverExamHeader2;
        private System.Windows.Forms.Label passOrFailLabel;
        private System.Windows.Forms.Label numCorrectLabel;
        private System.Windows.Forms.Label numIncorrectLabel;
        private System.Windows.Forms.Label incorrectQLabel;
        private System.Windows.Forms.TextBox passOrFailTextBox;
        private System.Windows.Forms.TextBox numIncorrectTextBox;
        private System.Windows.Forms.TextBox numCorrectTextBox;
        private System.Windows.Forms.ListBox incorrectQListBox;
    }
}

