
namespace WindowsUI
{
    partial class worldSeriesChampForm
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
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.worldSeriesHeader = new System.Windows.Forms.Label();
            this.worldSeriesHeader2 = new System.Windows.Forms.Label();
            this.worldSeriesHead3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 16;
            this.teamsListBox.Location = new System.Drawing.Point(12, 115);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(776, 308);
            this.teamsListBox.TabIndex = 0;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.teamsListBox_SelectedIndexChanged);
            // 
            // worldSeriesHeader
            // 
            this.worldSeriesHeader.AutoSize = true;
            this.worldSeriesHeader.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldSeriesHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.worldSeriesHeader.Location = new System.Drawing.Point(243, 9);
            this.worldSeriesHeader.Name = "worldSeriesHeader";
            this.worldSeriesHeader.Size = new System.Drawing.Size(387, 37);
            this.worldSeriesHeader.TabIndex = 1;
            this.worldSeriesHeader.Text = "World Series Championships";
            // 
            // worldSeriesHeader2
            // 
            this.worldSeriesHeader2.AutoSize = true;
            this.worldSeriesHeader2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldSeriesHeader2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.worldSeriesHeader2.Location = new System.Drawing.Point(204, 46);
            this.worldSeriesHeader2.Name = "worldSeriesHeader2";
            this.worldSeriesHeader2.Size = new System.Drawing.Size(461, 28);
            this.worldSeriesHeader2.TabIndex = 2;
            this.worldSeriesHeader2.Text = "How many times has your favorite team won?";
            // 
            // worldSeriesHead3
            // 
            this.worldSeriesHead3.AutoSize = true;
            this.worldSeriesHead3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldSeriesHead3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.worldSeriesHead3.Location = new System.Drawing.Point(302, 86);
            this.worldSeriesHead3.Name = "worldSeriesHead3";
            this.worldSeriesHead3.Size = new System.Drawing.Size(216, 26);
            this.worldSeriesHead3.TabIndex = 3;
            this.worldSeriesHead3.Text = "click below to find out!";
            // 
            // worldSeriesChampForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.worldSeriesHead3);
            this.Controls.Add(this.worldSeriesHeader2);
            this.Controls.Add(this.worldSeriesHeader);
            this.Controls.Add(this.teamsListBox);
            this.Name = "worldSeriesChampForm";
            this.Text = "World Series Championships";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Label worldSeriesHeader;
        private System.Windows.Forms.Label worldSeriesHeader2;
        private System.Windows.Forms.Label worldSeriesHead3;
    }
}

