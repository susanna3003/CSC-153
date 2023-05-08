
namespace WindowUI
{
    partial class randomNumForm
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
            this.randomNumHeader = new System.Windows.Forms.Label();
            this.userGuessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomNumHeader
            // 
            this.randomNumHeader.AutoSize = true;
            this.randomNumHeader.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumHeader.Location = new System.Drawing.Point(218, 9);
            this.randomNumHeader.Name = "randomNumHeader";
            this.randomNumHeader.Size = new System.Drawing.Size(346, 28);
            this.randomNumHeader.TabIndex = 0;
            this.randomNumHeader.Text = "Guess a number between 1-100";
            // 
            // userGuessTextBox
            // 
            this.userGuessTextBox.Location = new System.Drawing.Point(334, 74);
            this.userGuessTextBox.Name = "userGuessTextBox";
            this.userGuessTextBox.Size = new System.Drawing.Size(87, 20);
            this.userGuessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.guessButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guessButton.Location = new System.Drawing.Point(334, 124);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(87, 50);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "GUESS";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(285, 223);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(190, 79);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomNumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.userGuessTextBox);
            this.Controls.Add(this.randomNumHeader);
            this.Name = "randomNumForm";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.randomNumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomNumHeader;
        private System.Windows.Forms.TextBox userGuessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

