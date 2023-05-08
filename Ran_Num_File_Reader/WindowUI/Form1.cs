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
* 3/15/2023
* CSC 153
* Susanna Quayle
* Random Number File Reader
*/

namespace WindowUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create file reading object
            StreamReader readingFile;
            int amountNum = 0;
            int total = 0;

            //read file to list box
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                readingFile = File.OpenText(openFile.FileName);
                while (!readingFile.EndOfStream)
                {
                    int value = int.Parse(readingFile.ReadLine()); 
                    listBox.Items.Add(value.ToString());
                    amountNum++;
                    total += value;
                }
                listBox.Items.Add($"Total randoms: {amountNum}");
                listBox.Items.Add($"Total sum of the randoms: {total}");
            }
           
        }
    }
}
