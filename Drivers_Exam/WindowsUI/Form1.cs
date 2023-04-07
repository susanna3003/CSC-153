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
            //store correct exam answers in array
            String[] examAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };

            //create studentAnswers.txt
            //StreamWriter writeStudentAnswers;
            //writeStudentAnswers = File.CreateText("studentAnswers.txt");

            //read answers from student text into array
            StreamReader readStudentAns;
            readStudentAns = File.OpenText("studentAnswers.txt");

            //create studentAnswers array
            const int SIZE = 20;
            String[] studentAnswers = new string[SIZE];
            
            for (int i = 0; i < SIZE; i++)
            {
                while (!readStudentAns.EndOfStream)
                {
                    studentAnswers[i] = readStudentAns.ReadLine();
                }
            }

            //compare and calculate correct ans
            int numCorrect = 0;
            int numWrong = 0;
            Boolean pass = false;

            for (int j = 0; j < SIZE; j++)
            {
                if (examAnswers[j] == studentAnswers[j])
                {
                    numCorrect++;
                }
                else if (examAnswers[j] != studentAnswers[j])
                {
                    numWrong++;
                }
            }

            if (numCorrect >= 15)
            {
                pass = true;
            }
            
            if (pass == true)
            {
                MessageBox.Show("You passed!");
            }
            else if (pass == false)
            {
                MessageBox.Show("You failed. Better luck next time.");
            }
        }
    }
}
