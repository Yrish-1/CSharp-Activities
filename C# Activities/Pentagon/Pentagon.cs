using System;

namespace PentagonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Pentagon p1 = new Pentagon();
            Pentagon p2 = new Pentagon(5);

            Console.WriteLine("Pentagon p1");
            Console.WriteLine("-------------------");
            p1.Display();

            Console.WriteLine("Pentagon p2");
            Console.WriteLine("-------------------");

            p2.Display();
        }

        public class Pentagon
        {
            private double side;

            public Pentagon()
            {
                side = 0;
            }

            public Pentagon(double side)
            {
                this.side = side;
            }

            public double GetPerimeter()
            {
                return 5 * side;
            }

            public double GetArea()
            {
                return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2)) / 4;
            }

            public void Display()
            {
                Console.WriteLine("Side length: {0}", side);
                Console.WriteLine("Perimeter: {0:F3}", GetPerimeter());
                Console.WriteLine("Area : {0:F3}", GetArea());
            }
        }
    }
}