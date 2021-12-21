using System;

namespace Zad_1
{
    class Program
    {

        static double max(double a, double b)
        {
            return (a >= b) ? a : b;
        }

        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            double z = max(x, 2 * y - x) + max(5 * x + 3 * y, y);
            Console.WriteLine("z=" + z);

        }
    }   
}
