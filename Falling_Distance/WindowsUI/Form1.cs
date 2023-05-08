using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Falling_Library;

/**
* 3/20/2023
* CSC 153
* Susanna Quayle
* Falling Distance Caclulator
*/

namespace WindowsUI
{
    public partial class fallingDistForm : Form
    {
        public fallingDistForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare falling time and parse from user text
            double fallingTime = int.Parse(timeTextBox.Text);

            distanceTextBox.Text = Falling_Calc.FallingDistance(fallingTime).ToString();
        }
    }
}
