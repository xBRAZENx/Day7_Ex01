using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Area
    {
        public double Rectangle(double l,double b)
        {
            double area;
            area = l * b;
            return area;
        }
        public double Square(double s)
        {
            double area;
            area = Math.Pow(s,2);
            return area;
        }
        public double Circle(double r)
        {
            double area;
            area = 2*3.14*Math.Pow(r,2);
            return area;
        }
        public double Triangle(double b, double h)
        {
            double area;
            area = 0.5*b*h;
            return area;
        }
    }
}
