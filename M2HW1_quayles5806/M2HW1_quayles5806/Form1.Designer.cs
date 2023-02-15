
namespace M2HW1_quayles5806
{
    partial class colorMixForm
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
            this.colorBox1 = new System.Windows.Forms.GroupBox();
            this.yellRadButton1 = new System.Windows.Forms.RadioButton();
            this.blueRadButton1 = new System.Windows.Forms.RadioButton();
            this.redRadButton1 = new System.Windows.Forms.RadioButton();
            this.colorBox2 = new System.Windows.Forms.GroupBox();
            this.yellRadButton2 = new System.Windows.Forms.RadioButton();
            this.blueRadButton2 = new System.Windows.Forms.RadioButton();
            this.redRadButton2 = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorBox1.SuspendLayout();
            this.colorBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorBox1
            // 
            this.colorBox1.Controls.Add(this.yellRadButton1);
            this.colorBox1.Controls.Add(this.blueRadButton1);
            this.colorBox1.Controls.Add(this.redRadButton1);
            this.colorBox1.Location = new System.Drawing.Point(71, 46);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(276, 211);
            this.colorBox1.TabIndex = 0;
            this.colorBox1.TabStop = false;
            this.colorBox1.Text = "Select first color";
            // 
            // yellRadButton1
            // 
            this.yellRadButton1.AutoSize = true;
            this.yellRadButton1.Location = new System.Drawing.Point(6, 152);
            this.yellRadButton1.Name = "yellRadButton1";
            this.yellRadButton1.Size = new System.Drawing.Size(56, 17);
            this.yellRadButton1.TabIndex = 2;
            this.yellRadButton1.TabStop = true;
            this.yellRadButton1.Text = "Yellow";
            this.yellRadButton1.UseVisualStyleBackColor = true;
            // 
            // blueRadButton1
            // 
            this.blueRadButton1.AutoSize = true;
            this.blueRadButton1.Location = new System.Drawing.Point(6, 97);
            this.blueRadButton1.Name = "blueRadButton1";
            this.blueRadButton1.Size = new System.Drawing.Size(46, 17);
            this.blueRadButton1.TabIndex = 1;
            this.blueRadButton1.TabStop = true;
            this.blueRadButton1.Text = "Blue";
            this.blueRadButton1.UseVisualStyleBackColor = true;
            // 
            // redRadButton1
            // 
            this.redRadButton1.AutoSize = true;
            this.redRadButton1.Location = new System.Drawing.Point(6, 43);
            this.redRadButton1.Name = "redRadButton1";
            this.redRadButton1.Size = new System.Drawing.Size(45, 17);
            this.redRadButton1.TabIndex = 0;
            this.redRadButton1.TabStop = true;
            this.redRadButton1.Text = "Red";
            this.redRadButton1.UseVisualStyleBackColor = true;
            // 
            // colorBox2
            // 
            this.colorBox2.Controls.Add(this.yellRadButton2);
            this.colorBox2.Controls.Add(this.blueRadButton2);
            this.colorBox2.Controls.Add(this.redRadButton2);
            this.colorBox2.Location = new System.Drawing.Point(438, 46);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(276, 211);
            this.colorBox2.TabIndex = 0;
            this.colorBox2.TabStop = false;
            this.colorBox2.Text = "Select second color";
            // 
            // yellRadButton2
            // 
            this.yellRadButton2.AutoSize = true;
            this.yellRadButton2.Location = new System.Drawing.Point(6, 152);
            this.yellRadButton2.Name = "yellRadButton2";
            this.yellRadButton2.Size = new System.Drawing.Size(56, 17);
            this.yellRadButton2.TabIndex = 3;
            this.yellRadButton2.TabStop = true;
            this.yellRadButton2.Text = "Yellow";
            this.yellRadButton2.UseVisualStyleBackColor = true;
            // 
            // blueRadButton2
            // 
            this.blueRadButton2.AutoSize = true;
            this.blueRadButton2.Location = new System.Drawing.Point(6, 97);
            this.blueRadButton2.Name = "blueRadButton2";
            this.blueRadButton2.Size = new System.Drawing.Size(46, 17);
            this.blueRadButton2.TabIndex = 2;
            this.blueRadButton2.TabStop = true;
            this.blueRadButton2.Text = "Blue";
            this.blueRadButton2.UseVisualStyleBackColor = true;
            // 
            // redRadButton2
            // 
            this.redRadButton2.AutoSize = true;
            this.redRadButton2.Location = new System.Drawing.Point(6, 43);
            this.redRadButton2.Name = "redRadButton2";
            this.redRadButton2.Size = new System.Drawing.Size(45, 17);
            this.redRadButton2.TabIndex = 1;
            this.redRadButton2.TabStop = true;
            this.redRadButton2.Text = "Red";
            this.redRadButton2.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(227, 326);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(120, 45);
            this.mixButton.TabIndex = 1;
            this.mixButton.Text = "MIX";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(438, 326);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 45);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // colorMixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.colorBox2);
            this.Controls.Add(this.colorBox1);
            this.Name = "colorMixForm";
            this.Text = "Color Mixer";
            this.colorBox1.ResumeLayout(false);
            this.colorBox1.PerformLayout();
            this.colorBox2.ResumeLayout(false);
            this.colorBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorBox1;
        private System.Windows.Forms.RadioButton yellRadButton1;
        private System.Windows.Forms.RadioButton blueRadButton1;
        private System.Windows.Forms.RadioButton redRadButton1;
        private System.Windows.Forms.GroupBox colorBox2;
        private System.Windows.Forms.RadioButton yellRadButton2;
        private System.Windows.Forms.RadioButton blueRadButton2;
        private System.Windows.Forms.RadioButton redRadButton2;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

