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
 *  2/20/2023
 *  CSC 153
 *  Susanna Quayle
 *  Time Calculator
 */

namespace WinUI
{
    public partial class timeCalcForm : Form
    {
        public timeCalcForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // declare variables
            int numSec, numMinutes = 0, numHours = 0, numDays = 0;

            // parse user input from text str to double
            numSec = int.Parse(userSecTextBox.Text);

            // calc for days
            if (numSec > 86400)
            {
                numDays = numSec / 86400;
                numSec = numSec - (numDays * 86400);
            }

            // calc for hours
            if (numSec > 3600)
            {
                numHours = numSec / 3600;
                numSec = numSec - (numHours * 3600);
            }

            // calc for minutes
            if (numSec > 60)
            {
                numMinutes = numSec / 60;
                numSec = numSec - (numMinutes * 60);
            }

            daysDisplayTextBox.Text = numDays.ToString();
            hoursDisplayTextBox.Text = numHours.ToString();
            minutesDisplayTextBox.Text = numMinutes.ToString();
            secondsDisplayTextBox.Text = numSec.ToString();
        }
    }
}
