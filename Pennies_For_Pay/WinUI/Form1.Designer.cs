
namespace WinUI
{
    partial class pfpForm
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
            this.penniesHeader = new System.Windows.Forms.Label();
            this.penniesSubHead = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.penniesSubHead2 = new System.Windows.Forms.Label();
            this.userNumDaysBox = new System.Windows.Forms.TextBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // penniesHeader
            // 
            this.penniesHeader.AutoSize = true;
            this.penniesHeader.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penniesHeader.Location = new System.Drawing.Point(265, 9);
            this.penniesHeader.Name = "penniesHeader";
            this.penniesHeader.Size = new System.Drawing.Size(232, 36);
            this.penniesHeader.TabIndex = 0;
            this.penniesHeader.Text = "Pennies For Pay";
            // 
            // penniesSubHead
            // 
            this.penniesSubHead.AutoSize = true;
            this.penniesSubHead.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penniesSubHead.Location = new System.Drawing.Point(12, 77);
            this.penniesSubHead.Name = "penniesSubHead";
            this.penniesSubHead.Size = new System.Drawing.Size(293, 19);
            this.penniesSubHead.TabIndex = 1;
            this.penniesSubHead.Text = "Sarah just got a job and her salary is 1 penny. ";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(13, 144);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(247, 19);
            this.promptLabel.TabIndex = 2;
            this.promptLabel.Text = "Give Sarah a number of days to work...";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.Location = new System.Drawing.Point(14, 219);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(242, 19);
            this.payLabel.TabIndex = 3;
            this.payLabel.Text = "and see how much money she makes.";
            // 
            // penniesSubHead2
            // 
            this.penniesSubHead2.AutoSize = true;
            this.penniesSubHead2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penniesSubHead2.Location = new System.Drawing.Point(12, 96);
            this.penniesSubHead2.Name = "penniesSubHead2";
            this.penniesSubHead2.Size = new System.Drawing.Size(338, 19);
            this.penniesSubHead2.TabIndex = 4;
            this.penniesSubHead2.Text = "However, this amount is doubled each day she works.";
            // 
            // userNumDaysBox
            // 
            this.userNumDaysBox.Location = new System.Drawing.Point(17, 175);
            this.userNumDaysBox.Name = "userNumDaysBox";
            this.userNumDaysBox.Size = new System.Drawing.Size(100, 20);
            this.userNumDaysBox.TabIndex = 5;
            // 
            // payTextBox
            // 
            this.payTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.payTextBox.Location = new System.Drawing.Point(18, 250);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.ReadOnly = true;
            this.payTextBox.Size = new System.Drawing.Size(737, 20);
            this.payTextBox.TabIndex = 6;
            this.payTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(18, 286);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(109, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "CALCULATE PAY";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pfpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.payTextBox);
            this.Controls.Add(this.userNumDaysBox);
            this.Controls.Add(this.penniesSubHead2);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.penniesSubHead);
            this.Controls.Add(this.penniesHeader);
            this.Name = "pfpForm";
            this.Text = "Pennies For Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label penniesHeader;
        private System.Windows.Forms.Label penniesSubHead;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label penniesSubHead2;
        private System.Windows.Forms.TextBox userNumDaysBox;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

