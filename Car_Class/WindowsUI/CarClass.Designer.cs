
namespace WindowsUI
{
    partial class carClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carClassForm));
            this.carClassHeader = new System.Windows.Forms.Label();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.carMakeLabel = new System.Windows.Forms.Label();
            this.carYearTextBox = new System.Windows.Forms.TextBox();
            this.carMakeTextBox = new System.Windows.Forms.TextBox();
            this.accelButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // carClassHeader
            // 
            this.carClassHeader.AutoSize = true;
            this.carClassHeader.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.18182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carClassHeader.ForeColor = System.Drawing.Color.Red;
            this.carClassHeader.Location = new System.Drawing.Point(12, 9);
            this.carClassHeader.Name = "carClassHeader";
            this.carClassHeader.Size = new System.Drawing.Size(171, 41);
            this.carClassHeader.TabIndex = 0;
            this.carClassHeader.Text = "CAR INFO";
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carYearLabel.ForeColor = System.Drawing.Color.Red;
            this.carYearLabel.Location = new System.Drawing.Point(15, 89);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(83, 24);
            this.carYearLabel.TabIndex = 1;
            this.carYearLabel.Text = "Car Year:";
            // 
            // carMakeLabel
            // 
            this.carMakeLabel.AutoSize = true;
            this.carMakeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carMakeLabel.ForeColor = System.Drawing.Color.Red;
            this.carMakeLabel.Location = new System.Drawing.Point(15, 232);
            this.carMakeLabel.Name = "carMakeLabel";
            this.carMakeLabel.Size = new System.Drawing.Size(151, 24);
            this.carMakeLabel.TabIndex = 2;
            this.carMakeLabel.Text = "Car Make/Model:";
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.Location = new System.Drawing.Point(20, 132);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.carYearTextBox.TabIndex = 3;
            // 
            // carMakeTextBox
            // 
            this.carMakeTextBox.Location = new System.Drawing.Point(20, 287);
            this.carMakeTextBox.Name = "carMakeTextBox";
            this.carMakeTextBox.Size = new System.Drawing.Size(100, 20);
            this.carMakeTextBox.TabIndex = 4;
            // 
            // accelButton
            // 
            this.accelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accelButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.accelButton.Location = new System.Drawing.Point(523, 146);
            this.accelButton.Name = "accelButton";
            this.accelButton.Size = new System.Drawing.Size(189, 45);
            this.accelButton.TabIndex = 5;
            this.accelButton.Text = "ACCELERATE";
            this.accelButton.UseVisualStyleBackColor = false;
            this.accelButton.Click += new System.EventHandler(this.accelButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brakeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakeButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.brakeButton.Location = new System.Drawing.Point(523, 252);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(189, 45);
            this.brakeButton.TabIndex = 6;
            this.brakeButton.Text = "BRAKE";
            this.brakeButton.UseVisualStyleBackColor = false;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(216, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // carClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accelButton);
            this.Controls.Add(this.carMakeTextBox);
            this.Controls.Add(this.carYearTextBox);
            this.Controls.Add(this.carMakeLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.carClassHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "carClassForm";
            this.Text = "Car Class";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carClassHeader;
        private System.Windows.Forms.Label carYearLabel;
        private System.Windows.Forms.Label carMakeLabel;
        private System.Windows.Forms.TextBox carYearTextBox;
        private System.Windows.Forms.TextBox carMakeTextBox;
        private System.Windows.Forms.Button accelButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

