using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Library
{
    public class Area
    {
        public Area(double circleRad)
        {
            double area, p = Math.PI;
            area = p * (circleRad * circleRad);
            return;
        }

        public Area(int width, int length)
        {
            int area;
            area = length * width;
            return;
        }

        public Area(double height, double cylinderRad)
        {
            double area, p = Math.PI;
            area = (p * (cylinderRad * cylinderRad) * height);
            return;
        }
    }
}
