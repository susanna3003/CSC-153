
namespace WindowsUI
{
    partial class PrimeNumForm
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
            this.primeNumHeader = new System.Windows.Forms.Label();
            this.primeNumHeader2 = new System.Windows.Forms.Label();
            this.enterIntLabel = new System.Windows.Forms.Label();
            this.isPrimeLabel = new System.Windows.Forms.Label();
            this.enterIntTextBox = new System.Windows.Forms.TextBox();
            this.finalTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeNumHeader
            // 
            this.primeNumHeader.AutoSize = true;
            this.primeNumHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeNumHeader.Location = new System.Drawing.Point(355, 9);
            this.primeNumHeader.Name = "primeNumHeader";
            this.primeNumHeader.Size = new System.Drawing.Size(50, 30);
            this.primeNumHeader.TabIndex = 0;
            this.primeNumHeader.Text = "Is it";
            // 
            // primeNumHeader2
            // 
            this.primeNumHeader2.AutoSize = true;
            this.primeNumHeader2.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeNumHeader2.Location = new System.Drawing.Point(334, 39);
            this.primeNumHeader2.Name = "primeNumHeader2";
            this.primeNumHeader2.Size = new System.Drawing.Size(105, 34);
            this.primeNumHeader2.TabIndex = 1;
            this.primeNumHeader2.Text = "PRIME?";
            // 
            // enterIntLabel
            // 
            this.enterIntLabel.AutoSize = true;
            this.enterIntLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterIntLabel.Location = new System.Drawing.Point(54, 117);
            this.enterIntLabel.Name = "enterIntLabel";
            this.enterIntLabel.Size = new System.Drawing.Size(120, 21);
            this.enterIntLabel.TabIndex = 2;
            this.enterIntLabel.Text = "Enter a number:";
            // 
            // isPrimeLabel
            // 
            this.isPrimeLabel.AutoSize = true;
            this.isPrimeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPrimeLabel.Location = new System.Drawing.Point(54, 243);
            this.isPrimeLabel.Name = "isPrimeLabel";
            this.isPrimeLabel.Size = new System.Drawing.Size(86, 21);
            this.isPrimeLabel.TabIndex = 3;
            this.isPrimeLabel.Text = "Is it prime?";
            // 
            // enterIntTextBox
            // 
            this.enterIntTextBox.Location = new System.Drawing.Point(180, 118);
            this.enterIntTextBox.Name = "enterIntTextBox";
            this.enterIntTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterIntTextBox.TabIndex = 4;
            // 
            // finalTextBox
            // 
            this.finalTextBox.Location = new System.Drawing.Point(180, 243);
            this.finalTextBox.Name = "finalTextBox";
            this.finalTextBox.Size = new System.Drawing.Size(100, 20);
            this.finalTextBox.TabIndex = 5;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(207, 175);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(39, 31);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // PrimeNumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.finalTextBox);
            this.Controls.Add(this.enterIntTextBox);
            this.Controls.Add(this.isPrimeLabel);
            this.Controls.Add(this.enterIntLabel);
            this.Controls.Add(this.primeNumHeader2);
            this.Controls.Add(this.primeNumHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PrimeNumForm";
            this.Text = "Prime Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label primeNumHeader;
        private System.Windows.Forms.Label primeNumHeader2;
        private System.Windows.Forms.Label enterIntLabel;
        private System.Windows.Forms.Label isPrimeLabel;
        private System.Windows.Forms.TextBox enterIntTextBox;
        private System.Windows.Forms.TextBox finalTextBox;
        private System.Windows.Forms.Button goButton;
    }
}

