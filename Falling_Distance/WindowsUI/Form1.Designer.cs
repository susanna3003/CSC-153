
namespace WindowsUI
{
    partial class fallingDistForm
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
            this.fallingHeader = new System.Windows.Forms.Label();
            this.fallingHeader2 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fallingHeader
            // 
            this.fallingHeader.AutoSize = true;
            this.fallingHeader.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallingHeader.Location = new System.Drawing.Point(310, 9);
            this.fallingHeader.Name = "fallingHeader";
            this.fallingHeader.Size = new System.Drawing.Size(154, 34);
            this.fallingHeader.TabIndex = 0;
            this.fallingHeader.Text = "Falling Distance";
            // 
            // fallingHeader2
            // 
            this.fallingHeader2.AutoSize = true;
            this.fallingHeader2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallingHeader2.Location = new System.Drawing.Point(164, 80);
            this.fallingHeader2.Name = "fallingHeader2";
            this.fallingHeader2.Size = new System.Drawing.Size(469, 29);
            this.fallingHeader2.TabIndex = 1;
            this.fallingHeader2.Text = "Enter time in seconds to see how far an object has fallen in meters";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(164, 219);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(94, 29);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "time falling:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(518, 219);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(115, 29);
            this.distanceLabel.TabIndex = 3;
            this.distanceLabel.Text = "distance fallen:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(158, 262);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 4;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(523, 262);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(340, 263);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "CALCULATE!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // fallingDistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.fallingHeader2);
            this.Controls.Add(this.fallingHeader);
            this.Name = "fallingDistForm";
            this.Text = "Falling Distance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fallingHeader;
        private System.Windows.Forms.Label fallingHeader2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

