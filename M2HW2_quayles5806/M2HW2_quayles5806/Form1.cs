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
 * 2/15/2023
 * CSC 153
 * Susanna Quayle
 * Change For A Dollar Game
 */

namespace M2HW2_quayles5806
{
    public partial class dollarGameForm : Form
    {
        public dollarGameForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //declare double versions of change input and parse
            double userPennies, userNickels, userDimes, userQuarters, userAmount;
            userPennies = double.Parse(pennyTextBox.Text);
            userNickels = double.Parse(nickelTextBox.Text);
            userDimes = double.Parse(dimeTextBox.Text);
            userQuarters = double.Parse(quarterTextBox.Text);

            //get real value of change
            userPennies = userPennies * 0.01;
            userNickels = userNickels * 0.05;
            userDimes = userDimes * 0.1;
            userQuarters = userQuarters * 0.25;

            userAmount = userPennies + userNickels + userDimes + userQuarters;

            if (userAmount == 1.0)
            {
                MessageBox.Show("Congratulations! You have won the game!");
            }
            else if (userAmount > 1.0)
            {
                MessageBox.Show("Your amount was more than $1. Try again!");
            }
            else
            {
                MessageBox.Show("Your amount was less than $1. Try again!");
            }

        }
    }
}
