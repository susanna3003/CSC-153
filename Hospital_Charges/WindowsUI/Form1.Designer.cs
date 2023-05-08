
namespace WindowsUI
{
    partial class hospitalChargeForm
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
            this.hospitalHeader = new System.Windows.Forms.Label();
            this.hospitalHeader2 = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.medsLabel = new System.Windows.Forms.Label();
            this.surgicalLabel = new System.Windows.Forms.Label();
            this.rehabLabel = new System.Windows.Forms.Label();
            this.labLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.medsTextBox = new System.Windows.Forms.TextBox();
            this.surgicalTextBox = new System.Windows.Forms.TextBox();
            this.labTextBox = new System.Windows.Forms.TextBox();
            this.rehabTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hospitalHeader
            // 
            this.hospitalHeader.AutoSize = true;
            this.hospitalHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalHeader.Location = new System.Drawing.Point(193, 9);
            this.hospitalHeader.Name = "hospitalHeader";
            this.hospitalHeader.Size = new System.Drawing.Size(424, 26);
            this.hospitalHeader.TabIndex = 0;
            this.hospitalHeader.Text = "Calculate the total cost of your hospital stay.";
            // 
            // hospitalHeader2
            // 
            this.hospitalHeader2.AutoSize = true;
            this.hospitalHeader2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalHeader2.Location = new System.Drawing.Point(73, 50);
            this.hospitalHeader2.Name = "hospitalHeader2";
            this.hospitalHeader2.Size = new System.Drawing.Size(665, 21);
            this.hospitalHeader2.TabIndex = 1;
            this.hospitalHeader2.Text = "Fill in the boxes below then click \"calculate\" to see your total. If services wer" +
    "e not used, put 0.00";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(25, 134);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(181, 16);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "How many days did you stay?";
            // 
            // medsLabel
            // 
            this.medsLabel.AutoSize = true;
            this.medsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medsLabel.Location = new System.Drawing.Point(25, 181);
            this.medsLabel.Name = "medsLabel";
            this.medsLabel.Size = new System.Drawing.Size(107, 16);
            this.medsLabel.TabIndex = 3;
            this.medsLabel.Text = "Medication fees?";
            // 
            // surgicalLabel
            // 
            this.surgicalLabel.AutoSize = true;
            this.surgicalLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgicalLabel.Location = new System.Drawing.Point(25, 230);
            this.surgicalLabel.Name = "surgicalLabel";
            this.surgicalLabel.Size = new System.Drawing.Size(88, 16);
            this.surgicalLabel.TabIndex = 4;
            this.surgicalLabel.Text = "Surgical fees?";
            // 
            // rehabLabel
            // 
            this.rehabLabel.AutoSize = true;
            this.rehabLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rehabLabel.Location = new System.Drawing.Point(25, 327);
            this.rehabLabel.Name = "rehabLabel";
            this.rehabLabel.Size = new System.Drawing.Size(125, 16);
            this.rehabLabel.TabIndex = 5;
            this.rehabLabel.Text = "Physical rehab fees?\r\n";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLabel.Location = new System.Drawing.Point(25, 279);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(63, 16);
            this.labLabel.TabIndex = 6;
            this.labLabel.Text = "Lab fees?";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(245, 132);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 7;
            // 
            // medsTextBox
            // 
            this.medsTextBox.Location = new System.Drawing.Point(245, 179);
            this.medsTextBox.Name = "medsTextBox";
            this.medsTextBox.Size = new System.Drawing.Size(100, 20);
            this.medsTextBox.TabIndex = 8;
            // 
            // surgicalTextBox
            // 
            this.surgicalTextBox.Location = new System.Drawing.Point(244, 228);
            this.surgicalTextBox.Name = "surgicalTextBox";
            this.surgicalTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgicalTextBox.TabIndex = 9;
            // 
            // labTextBox
            // 
            this.labTextBox.Location = new System.Drawing.Point(245, 277);
            this.labTextBox.Name = "labTextBox";
            this.labTextBox.Size = new System.Drawing.Size(100, 20);
            this.labTextBox.TabIndex = 10;
            // 
            // rehabTextBox
            // 
            this.rehabTextBox.Location = new System.Drawing.Point(245, 325);
            this.rehabTextBox.Name = "rehabTextBox";
            this.rehabTextBox.Size = new System.Drawing.Size(100, 20);
            this.rehabTextBox.TabIndex = 11;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateButton.Location = new System.Drawing.Point(542, 226);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // hospitalChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rehabTextBox);
            this.Controls.Add(this.labTextBox);
            this.Controls.Add(this.surgicalTextBox);
            this.Controls.Add(this.medsTextBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.labLabel);
            this.Controls.Add(this.rehabLabel);
            this.Controls.Add(this.surgicalLabel);
            this.Controls.Add(this.medsLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.hospitalHeader2);
            this.Controls.Add(this.hospitalHeader);
            this.Name = "hospitalChargeForm";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hospitalHeader;
        private System.Windows.Forms.Label hospitalHeader2;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label medsLabel;
        private System.Windows.Forms.Label surgicalLabel;
        private System.Windows.Forms.Label rehabLabel;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox medsTextBox;
        private System.Windows.Forms.TextBox surgicalTextBox;
        private System.Windows.Forms.TextBox labTextBox;
        private System.Windows.Forms.TextBox rehabTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

