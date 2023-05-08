
namespace WindowsUI
{
    partial class employeeClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeClassForm));
            this.employeeHeader = new System.Windows.Forms.Label();
            this.susanPictureBox = new System.Windows.Forms.PictureBox();
            this.joyPictureBox = new System.Windows.Forms.PictureBox();
            this.markPictureBox = new System.Windows.Forms.PictureBox();
            this.susanButton = new System.Windows.Forms.Button();
            this.markButton = new System.Windows.Forms.Button();
            this.joyButton = new System.Windows.Forms.Button();
            this.susanTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.joyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.susanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeHeader
            // 
            this.employeeHeader.AutoSize = true;
            this.employeeHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeHeader.Location = new System.Drawing.Point(49, 20);
            this.employeeHeader.Name = "employeeHeader";
            this.employeeHeader.Size = new System.Drawing.Size(836, 45);
            this.employeeHeader.TabIndex = 0;
            this.employeeHeader.Text = "THIS ORGANIZATION | EMPLOYEE INFORMATION";
            // 
            // susanPictureBox
            // 
            this.susanPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("susanPictureBox.BackgroundImage")));
            this.susanPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.susanPictureBox.Location = new System.Drawing.Point(126, 126);
            this.susanPictureBox.Name = "susanPictureBox";
            this.susanPictureBox.Size = new System.Drawing.Size(101, 100);
            this.susanPictureBox.TabIndex = 1;
            this.susanPictureBox.TabStop = false;
            // 
            // joyPictureBox
            // 
            this.joyPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("joyPictureBox.BackgroundImage")));
            this.joyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.joyPictureBox.Location = new System.Drawing.Point(673, 126);
            this.joyPictureBox.Name = "joyPictureBox";
            this.joyPictureBox.Size = new System.Drawing.Size(101, 100);
            this.joyPictureBox.TabIndex = 2;
            this.joyPictureBox.TabStop = false;
            // 
            // markPictureBox
            // 
            this.markPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("markPictureBox.BackgroundImage")));
            this.markPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.markPictureBox.Location = new System.Drawing.Point(394, 126);
            this.markPictureBox.Name = "markPictureBox";
            this.markPictureBox.Size = new System.Drawing.Size(101, 100);
            this.markPictureBox.TabIndex = 3;
            this.markPictureBox.TabStop = false;
            // 
            // susanButton
            // 
            this.susanButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.susanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.susanButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.susanButton.Location = new System.Drawing.Point(126, 254);
            this.susanButton.Name = "susanButton";
            this.susanButton.Size = new System.Drawing.Size(101, 29);
            this.susanButton.TabIndex = 4;
            this.susanButton.Text = "S. MEYERS";
            this.susanButton.UseVisualStyleBackColor = false;
            this.susanButton.Click += new System.EventHandler(this.susanButton_Click);
            // 
            // markButton
            // 
            this.markButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.markButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markButton.Location = new System.Drawing.Point(394, 254);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(101, 29);
            this.markButton.TabIndex = 5;
            this.markButton.Text = "M. JONES";
            this.markButton.UseVisualStyleBackColor = false;
            this.markButton.Click += new System.EventHandler(this.markButton_Click);
            // 
            // joyButton
            // 
            this.joyButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.joyButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joyButton.Location = new System.Drawing.Point(673, 254);
            this.joyButton.Name = "joyButton";
            this.joyButton.Size = new System.Drawing.Size(101, 29);
            this.joyButton.TabIndex = 6;
            this.joyButton.Text = "J. ROGERS";
            this.joyButton.UseVisualStyleBackColor = false;
            this.joyButton.Click += new System.EventHandler(this.joyButton_Click);
            // 
            // susanTextBox
            // 
            this.susanTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.susanTextBox.Location = new System.Drawing.Point(82, 318);
            this.susanTextBox.Multiline = true;
            this.susanTextBox.Name = "susanTextBox";
            this.susanTextBox.Size = new System.Drawing.Size(200, 150);
            this.susanTextBox.TabIndex = 7;
            // 
            // markTextBox
            // 
            this.markTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markTextBox.Location = new System.Drawing.Point(347, 318);
            this.markTextBox.Multiline = true;
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(200, 150);
            this.markTextBox.TabIndex = 8;
            // 
            // joyTextBox
            // 
            this.joyTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joyTextBox.Location = new System.Drawing.Point(624, 318);
            this.joyTextBox.Multiline = true;
            this.joyTextBox.Name = "joyTextBox";
            this.joyTextBox.Size = new System.Drawing.Size(200, 150);
            this.joyTextBox.TabIndex = 9;
            // 
            // employeeClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.joyTextBox);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.susanTextBox);
            this.Controls.Add(this.joyButton);
            this.Controls.Add(this.markButton);
            this.Controls.Add(this.susanButton);
            this.Controls.Add(this.markPictureBox);
            this.Controls.Add(this.joyPictureBox);
            this.Controls.Add(this.susanPictureBox);
            this.Controls.Add(this.employeeHeader);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "employeeClassForm";
            this.Text = "Employee Class";
            ((System.ComponentModel.ISupportInitialize)(this.susanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeHeader;
        private System.Windows.Forms.PictureBox susanPictureBox;
        private System.Windows.Forms.PictureBox joyPictureBox;
        private System.Windows.Forms.PictureBox markPictureBox;
        private System.Windows.Forms.Button susanButton;
        private System.Windows.Forms.Button markButton;
        private System.Windows.Forms.Button joyButton;
        private System.Windows.Forms.TextBox susanTextBox;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.TextBox joyTextBox;
    }
}

