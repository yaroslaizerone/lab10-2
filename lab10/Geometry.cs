using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Geometry
    {
        public int RectangleArea(int a, int b) { 
            return a * b;
        }
        public double RectangleAreaCelindr(int r, int h) {
            return Math.Round(Math.PI*Math.Pow(r,2)*h,2);
        }

        
    }
    public class Management
    {
        public double[] SlovingQuadEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }

            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }

            return null;

        }
    }
}
