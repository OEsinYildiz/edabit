using System;

namespace Make_a_Circle_with_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Circle(4.44);
            Console.WriteLine(q.GetArea());
            Console.WriteLine(q.GetPerimeter());
        }
    }

    class Circle
    {
        private double _r;
        public const double PI = 3.1415926535897931;

        public Circle(double r)
        {
            _r = r;
        }

        public double GetArea()
        {
            return PI * Math.Pow(_r, 2);
        }

        public double GetPerimeter()
        {
            return 2 * PI * _r;
        }
    }
}