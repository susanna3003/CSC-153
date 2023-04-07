
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
            this.SuspendLayout();
            // 
            // gradeButton
            // 
            this.gradeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradeButton.Font = new System.Drawing.Font("Myanmar Text", 28.14545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeButton.Location = new System.Drawing.Point(270, 118);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(212, 155);
            this.gradeButton.TabIndex = 0;
            this.gradeButton.Text = "GRADE";
            this.gradeButton.UseVisualStyleBackColor = false;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // DriverLicenseExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeButton);
            this.Name = "DriverLicenseExam";
            this.Text = "Driver\'s License Exam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gradeButton;
    }
}

