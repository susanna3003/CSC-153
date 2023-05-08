using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver_Exam_Library
{
    public static class GradingLogic
    {
        public static List<int> wrongAnswers = new List<int>();

        public static string[] examAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };

        public static string[] studentAnswers = new string[20];

        public static int numCorrect = 0, numWrong = 0;
        public static Boolean pass = false;
    }
}
