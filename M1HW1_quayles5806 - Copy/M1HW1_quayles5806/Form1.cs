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
 * 1/20/23
 * CSC 153
 * Susanna Quayle
 * Name Formatter - user inputs preferred title, first, middle, and last name - program provides 6 different formats of user name
 */
namespace M1HW1_quayles5806
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prefTitle_Click(object sender, EventArgs e)
        {

        }

        private void fName_Click(object sender, EventArgs e)
        {

        }

        private void mName_Click(object sender, EventArgs e)
        {

        }

        private void lasName_Click(object sender, EventArgs e)
        {

        }

        private void prefTitleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void mNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lasNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameForm1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"{prefTitleText.Text} {fNameText.Text} {mNameText.Text} {lasNameText.Text}");
        }

        private void nameForm2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"{fNameText.Text} {mNameText.Text} {lasNameText.Text}");
        }

        private void nameForm3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"{fNameText.Text} {lasNameText.Text}");
        }

        private void nameForm4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"{lasNameText.Text}, {fNameText.Text} {mNameText.Text}, {prefTitleText.Text}");
        }

        private void nameForm5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"{lasNameText.Text}, {fNameText.Text} {mNameText.Text}");
        }

        private void nameForm6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"{lasNameText.Text}, {fNameText.Text}");
        }
    }
}
