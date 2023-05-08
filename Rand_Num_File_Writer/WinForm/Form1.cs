using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
* 3/12/23
* CSC 153
* Susanna Quayle
* Random Number File Writer
*/

namespace WinForm
{
    public partial class randomNumWriter : Form
    {
        public randomNumWriter()
        {
            InitializeComponent();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            //get rand
            Random rand = new Random();

            //declare variables
            int userAmount, sentry = 0;

            userAmount = int.Parse(userAmountTextBox.Text);

            StreamWriter randomNumbers;
            //randomNumbers = File.CreateText("randomnumbers.txt");

            SaveFileDialog randSaveFile = new SaveFileDialog();
            if (randSaveFile.ShowDialog() == DialogResult.OK)
            {
                randomNumbers = File.CreateText("randomnumbers.txt");
                do
                {
                    randomNumbers.WriteLine(rand.Next(1, 100) + 1);
                    sentry++;
                } while (sentry != userAmount);

                randomNumbers.Close();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
