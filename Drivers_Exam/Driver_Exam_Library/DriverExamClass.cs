using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver_Exam_Library
{
    public static class DriverExamClass
    {
        public static void Grade()
        {
            for (int j = 0; j < 20; j++)
            {
                if (GradingLogic.examAnswers[j] == GradingLogic.studentAnswers[j])
                {
                    GradingLogic.numCorrect++;
                }
                else if (GradingLogic.examAnswers[j] != GradingLogic.studentAnswers[j])
                {
                    GradingLogic.numWrong++;
                    GradingLogic.wrongAnswers.Add(j + 1);
                }
            }

            if (GradingLogic.numCorrect >= 15)
            {
                GradingLogic.pass = true;
            }

        }
    }
}
