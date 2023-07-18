using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            int choice;
            Console.WriteLine("Choose the Shape as follows :\t 1.Rectangle \t 2.Square \t 3.Circle \t 4.Triangle");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter length and breadth of rectangle");
                        double l=double.Parse(Console.ReadLine());
                        double b=double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Rectangle is: " + area.Rectangle(l, b));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter side of Square");
                        double l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Square is: " + area.Square(l));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter radius of Circle");
                        double l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Circle is: " + area.Circle(l));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter base and height of Triangle");
                        double b = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Triangle is: " + area.Triangle(b,h));
                        break;
                    }
                default: { Console.WriteLine("Invalid Selection");break; }

            }
            Console.ReadKey();
        }
    }
}
