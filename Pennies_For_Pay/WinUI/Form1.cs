using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 3/1/2023
* CSC 153
* Susanna Quayle
* Pennies For Pay
*/

namespace WinUI
{
    public partial class pfpForm : Form
    {
        public pfpForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declare variables
            // salary set at 1 cent, updateSalary, userNumDays, and x as sentry variable
            double salary = 0.01;
            double updateSalary = 0, userNumDays, numDays = 1, totalPay = 0.01;

            userNumDays = double.Parse(userNumDaysBox.Text);

            for (numDays = 0; numDays < userNumDays; numDays++)
            {
                if (numDays != 0)
                {
                    salary *= 2;
                    totalPay += salary;
                }
            }

            payTextBox.Text = totalPay.ToString("c");

        }
    }
}
