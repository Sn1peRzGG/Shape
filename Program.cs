using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Shape
    {
        internal int Area;
    }
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
    }
    class Rectangle : Shape
    {
        private double sideRectangle;

        public Rectangle(double sideRectangle)
        {
            this.sideRectangle = sideRectangle;
        }

        public double Area()
        {
            return Math.Round(Math.Pow(sideRectangle, 2), 2);
        }
    }
    class Triangle : Shape
    {
        private double sideTriangle;

        public Triangle(double sideTriangle)
        {
            this.sideTriangle = sideTriangle;
        }

        public double Area()
        {
            return Math.Round(Math.Pow(sideTriangle, 2) * Math.Sqrt(3) / 4, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine($"Введіть фігуру (1 - коло, 2 - квадрат, 3 - трикутник):\n");
            int choise = Convert.ToInt32(Console.ReadLine().Trim());
            if (choise != 1 && choise != 2 && choise != 3) {
                Console.WriteLine("Некоректний ввід. Введіть дійсне число.");
            } else if (choise == 1)
            {
                Console.WriteLine("Введіть радіус кола (у см):");
                string radiusInput = Console.ReadLine();
                if (double.TryParse(radiusInput, out double radius))
                {
                    Circle circle = new Circle(radius);
                    double circleArea = circle.Area();
                    Console.WriteLine($"Площа кола з радіусом {radius} см дорівнює {circleArea} см²!");
                }
            } else if (choise == 2)
            {
                Console.WriteLine("Введіть сторону квадрата (у см):");
                string sideInput = Console.ReadLine();
                if (double.TryParse(sideInput, out double sideRectangle))
                {
                    Rectangle rectangle = new Rectangle(sideRectangle);
                    double rectangleArea = rectangle.Area();
                    Console.WriteLine($"Площа квадрата зі стороною {sideRectangle} см дорівнює {rectangleArea} см²!");
                }
            } else
            {
                Console.WriteLine("Введіть сторону рівностороннього трикутника (у см):");
                string sideInput = Console.ReadLine();
                if (double.TryParse(sideInput, out double sideTriangle))
                {
                    Triangle triangle = new Triangle(sideTriangle);
                    double triangleArea = triangle.Area();
                    Console.WriteLine($"Площа рівностороннього трикутника зі стороною {sideTriangle} см дорівнює {triangleArea} см²!");
                }
            }
        }
    }
}
