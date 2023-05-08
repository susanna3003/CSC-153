using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Stay_Library
{
    public static class Hospital_Stay
    {
        public static double CalcStayCharges(double userDays)
        {
            //calculate cost for num days user stayed. hospital daily rate $350
            double dailyRate = 350.00;
            double daysTotal = userDays * dailyRate;

            return daysTotal;
        }

        public static double CalcMiscCharges(double userMeds, double userSurgical, double userLab, double userRehab)
        {
            //calculate cost of meds, surgical, lab, and rehab
            double miscTotal = userMeds + userSurgical + userLab + userRehab;

            return miscTotal;
        }

        public static double CalcTotalCharges(double miscTotal, double daysTotal)
        {
            //add daysTotal + miscTotal for finalCost
            double finalCost = daysTotal + miscTotal;

            return finalCost;
        }

    }
}
