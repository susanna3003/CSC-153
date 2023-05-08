using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Driver_Exam_Library;
using System.IO;

/**
* 4/6/2023
* CSC 153
* Susanna Quayle
* Driver's License Exam
*/

namespace WindowsUI
{
    public partial class DriverLicenseExam : Form
    {
        public DriverLicenseExam()
        {
            InitializeComponent();
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            StudentAnswers.LoadStudentAnswers();
            DriverExamClass.Grade();

            if (GradingLogic.pass == true)
            {
                //MessageBox.Show("You passed!");
                passOrFailTextBox.Text = "You passed!";
            }
            else if (GradingLogic.pass == false)
            {
                //MessageBox.Show("You failed. Better luck next time.");
                passOrFailTextBox.Text = "You failed. Better luck next time.";
            }

            String numCorrectString = GradingLogic.numCorrect.ToString();
            numCorrectTextBox.Text = numCorrectString;

            String numWrongString = GradingLogic.numWrong.ToString();
            numIncorrectTextBox.Text = numWrongString;

            //List<int> incorrectAnswers = new List<int>(); wait for class library
            foreach (int wrongAnswer in GradingLogic.wrongAnswers)
            {
                incorrectQListBox.Items.Add(wrongAnswer);
            }
            
        }
    }
}
