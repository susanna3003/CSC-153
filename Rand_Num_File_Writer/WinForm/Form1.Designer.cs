
namespace WinForm
{
    partial class randomNumWriter
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
            this.randNumHeader = new System.Windows.Forms.Label();
            this.userAmountTextBox = new System.Windows.Forms.TextBox();
            this.randHeader2 = new System.Windows.Forms.Label();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.randSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // randNumHeader
            // 
            this.randNumHeader.AutoSize = true;
            this.randNumHeader.Font = new System.Drawing.Font("Microsoft YaHei", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randNumHeader.Location = new System.Drawing.Point(55, 49);
            this.randNumHeader.Name = "randNumHeader";
            this.randNumHeader.Size = new System.Drawing.Size(575, 21);
            this.randNumHeader.TabIndex = 0;
            this.randNumHeader.Text = "Tell the Random Number Generator how many randoms to put in the file:";
            // 
            // userAmountTextBox
            // 
            this.userAmountTextBox.Location = new System.Drawing.Point(353, 130);
            this.userAmountTextBox.Name = "userAmountTextBox";
            this.userAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.userAmountTextBox.TabIndex = 1;
            // 
            // randHeader2
            // 
            this.randHeader2.AutoSize = true;
            this.randHeader2.Font = new System.Drawing.Font("Microsoft YaHei", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randHeader2.Location = new System.Drawing.Point(335, 130);
            this.randHeader2.Name = "randHeader2";
            this.randHeader2.Size = new System.Drawing.Size(0, 21);
            this.randHeader2.TabIndex = 2;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileButton.Location = new System.Drawing.Point(316, 217);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(176, 55);
            this.saveFileButton.TabIndex = 3;
            this.saveFileButton.Text = "Save the file:";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // randSaveFile
            // 
            this.randSaveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // randomNumWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.randHeader2);
            this.Controls.Add(this.userAmountTextBox);
            this.Controls.Add(this.randNumHeader);
            this.Name = "randomNumWriter";
            this.Text = "randomNumWriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randNumHeader;
        private System.Windows.Forms.TextBox userAmountTextBox;
        private System.Windows.Forms.Label randHeader2;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.SaveFileDialog randSaveFile;
    }
}

