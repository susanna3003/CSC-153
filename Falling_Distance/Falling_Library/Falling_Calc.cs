using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falling_Library
{
    public class Falling_Calc
    {
        public static double FallingDistance(double fallingTime)
        {
            //calculate distance with formula d=1/2gt^2 with g=9.8
            double h = 0.5, g = 9.8;
            double distance = h * (g * (fallingTime * fallingTime));

            return distance;
        }
    }
}
