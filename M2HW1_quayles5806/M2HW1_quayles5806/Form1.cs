using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * 2/12/2023
 * CSC 153
 * Susanna Quayle
 * Primary Color Mixer
 */


namespace M2HW1_quayles5806
{
    public partial class colorMixForm : Form
    {
        public colorMixForm()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if (redRadButton1.Checked && redRadButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (redRadButton1.Checked && blueRadButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (redRadButton1.Checked && yellRadButton2.Checked)
            {
                this.BackColor = Color.FromArgb(255, 128, 0);
            }
            else if (blueRadButton1.Checked && redRadButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueRadButton1.Checked && blueRadButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (blueRadButton1.Checked && yellRadButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellRadButton1.Checked && redRadButton2.Checked)
            {
                this.BackColor = Color.FromArgb(255, 128, 0);
            }
            else if (yellRadButton1.Checked && blueRadButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
