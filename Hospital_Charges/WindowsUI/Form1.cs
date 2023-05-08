using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Stay_Library;

/**
* 3/22/23
* CSC 153
* Susanna Quayle
* Hospital Stay Charges
*/
namespace WindowsUI
{
    public partial class hospitalChargeForm : Form
    {
        public hospitalChargeForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //parse input from user to double
            double userDays = double.Parse(daysTextBox.Text);
            double userMeds = double.Parse(medsTextBox.Text);
            double userSurgical = double.Parse(surgicalTextBox.Text);
            double userLab = double.Parse(labTextBox.Text);
            double userRehab = double.Parse(rehabTextBox.Text);

            double daysTotalDisplay = Hospital_Stay.CalcStayCharges(userDays);
            double miscTotalDisplay = Hospital_Stay.CalcMiscCharges(userMeds, userSurgical, userLab, userRehab);
            double total = Hospital_Stay.CalcTotalCharges(Hospital_Stay.CalcMiscCharges(userMeds, userSurgical, userLab, userRehab), Hospital_Stay.CalcStayCharges(userDays));

            string newLine = Environment.NewLine;
            MessageBox.Show($"Your charges are calculated! Your daily rate total came to {daysTotalDisplay.ToString("c")}" + newLine + $"Your miscellaneous charges total was {miscTotalDisplay.ToString("c")}" + newLine + $"Your overall final cost is {total.ToString("c")}");
        }
    }
}
