using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Driver_Exam_Library
{
    public static class StudentAnswers
    {
        public static void LoadStudentAnswers()
        {
            //read answers from student text into array
            StreamReader readStudentAns;
            readStudentAns = File.OpenText(@"D:\SUSU\SPRING 2023\C#\MODULE 5\Drivers_Exam\Driver_Exam_Library\studentAnswers.txt");

            for (int i = 0; i < 20; i++)
            {
                while (!readStudentAns.EndOfStream)
                {
                    GradingLogic.studentAnswers[i] = readStudentAns.ReadLine();
                    i++;
                }
            }
        }
    }
}
