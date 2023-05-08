using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prime_Num_Library;

/**
* Date
* CSC 153
* Susanna Quayle
* Determine if number is prime
*/

namespace WindowsUI
{
    public partial class PrimeNumForm : Form
    {
        public PrimeNumForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //create userInt and parse from text box
            int userInt = int.Parse(enterIntTextBox.Text);

            finalTextBox.Text = Prime_Num_Library.Prime_Num_Library.IsPrime(userInt).ToString();
        }
    }
}
