
namespace WinUI
{
    partial class timeCalcForm
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
            this.timeCalcHeader = new System.Windows.Forms.Label();
            this.timeCalcSubHead = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.userSecTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.daysDisplayTextBox = new System.Windows.Forms.Label();
            this.hoursDisplayTextBox = new System.Windows.Forms.Label();
            this.minutesDisplayTextBox = new System.Windows.Forms.Label();
            this.secondsDisplayTextBox = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeCalcHeader
            // 
            this.timeCalcHeader.AutoSize = true;
            this.timeCalcHeader.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCalcHeader.Location = new System.Drawing.Point(297, 25);
            this.timeCalcHeader.Name = "timeCalcHeader";
            this.timeCalcHeader.Size = new System.Drawing.Size(171, 28);
            this.timeCalcHeader.TabIndex = 0;
            this.timeCalcHeader.Text = "Time Calculator";
            // 
            // timeCalcSubHead
            // 
            this.timeCalcSubHead.AutoSize = true;
            this.timeCalcSubHead.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCalcSubHead.Location = new System.Drawing.Point(94, 69);
            this.timeCalcSubHead.Name = "timeCalcSubHead";
            this.timeCalcSubHead.Size = new System.Drawing.Size(563, 19);
            this.timeCalcSubHead.TabIndex = 1;
            this.timeCalcSubHead.Text = "Enter any number of seconds and find out how many minutes, hours, or days it make" +
    "s up.";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(346, 131);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(64, 19);
            this.secondsLabel.TabIndex = 2;
            this.secondsLabel.Text = "Seconds:";
            // 
            // userSecTextBox
            // 
            this.userSecTextBox.Location = new System.Drawing.Point(326, 166);
            this.userSecTextBox.Name = "userSecTextBox";
            this.userSecTextBox.Size = new System.Drawing.Size(100, 20);
            this.userSecTextBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(326, 231);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 32);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "CALCULATE";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // daysDisplayTextBox
            // 
            this.daysDisplayTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.daysDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daysDisplayTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysDisplayTextBox.Location = new System.Drawing.Point(86, 344);
            this.daysDisplayTextBox.Name = "daysDisplayTextBox";
            this.daysDisplayTextBox.Size = new System.Drawing.Size(100, 23);
            this.daysDisplayTextBox.TabIndex = 5;
            this.daysDisplayTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursDisplayTextBox
            // 
            this.hoursDisplayTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hoursDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hoursDisplayTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursDisplayTextBox.Location = new System.Drawing.Point(263, 344);
            this.hoursDisplayTextBox.Name = "hoursDisplayTextBox";
            this.hoursDisplayTextBox.Size = new System.Drawing.Size(100, 23);
            this.hoursDisplayTextBox.TabIndex = 6;
            this.hoursDisplayTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesDisplayTextBox
            // 
            this.minutesDisplayTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minutesDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minutesDisplayTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesDisplayTextBox.Location = new System.Drawing.Point(415, 344);
            this.minutesDisplayTextBox.Name = "minutesDisplayTextBox";
            this.minutesDisplayTextBox.Size = new System.Drawing.Size(100, 23);
            this.minutesDisplayTextBox.TabIndex = 7;
            this.minutesDisplayTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondsDisplayTextBox
            // 
            this.secondsDisplayTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondsDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondsDisplayTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsDisplayTextBox.Location = new System.Drawing.Point(557, 344);
            this.secondsDisplayTextBox.Name = "secondsDisplayTextBox";
            this.secondsDisplayTextBox.Size = new System.Drawing.Size(100, 23);
            this.secondsDisplayTextBox.TabIndex = 8;
            this.secondsDisplayTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(115, 302);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(46, 21);
            this.daysLabel.TabIndex = 9;
            this.daysLabel.Text = "Days";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(287, 302);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(55, 21);
            this.hoursLabel.TabIndex = 10;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(430, 302);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(72, 21);
            this.minutesLabel.TabIndex = 11;
            this.minutesLabel.Text = "Minutes";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLabel.Location = new System.Drawing.Point(571, 302);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(73, 21);
            this.secLabel.TabIndex = 12;
            this.secLabel.Text = "Seconds";
            // 
            // timeCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.secondsDisplayTextBox);
            this.Controls.Add(this.minutesDisplayTextBox);
            this.Controls.Add(this.hoursDisplayTextBox);
            this.Controls.Add(this.daysDisplayTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.userSecTextBox);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.timeCalcSubHead);
            this.Controls.Add(this.timeCalcHeader);
            this.Name = "timeCalcForm";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeCalcHeader;
        private System.Windows.Forms.Label timeCalcSubHead;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox userSecTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label daysDisplayTextBox;
        private System.Windows.Forms.Label hoursDisplayTextBox;
        private System.Windows.Forms.Label minutesDisplayTextBox;
        private System.Windows.Forms.Label secondsDisplayTextBox;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secLabel;
    }
}

