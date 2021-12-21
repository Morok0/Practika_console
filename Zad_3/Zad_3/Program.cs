using System;

namespace Question2412849
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите [a,b]:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг h:");
            double h = double.Parse(Console.ReadLine());
            f(a, b, h);

            Console.WriteLine("============");
            for (double x = a; x <= b; x += h)
            {
                f(x, out double y);
                Console.WriteLine($"f({x,5:F})={y,10:F2}");
            }

            Console.Read();
        }
        static void f(double a, double b, double h)
        {
            double f = 0;
            for (double i = a; i <= b; i += h)
            {
                if (Math.Abs(i) < a)
                    f = 0;
                else if (Math.Abs(i) > a)
                    f = (i - a) / (i + a);
                else if (Math.Abs(i) == a)
                    f = 1;
                Console.WriteLine("f({0,5:F})={1,10:F2}", i, f);
            }
        }

        static void f(double x, out double y)
        {
            double a = 1;
            y = x < a
            ? 0
            : x > a
            ? (x - a) / (x + a)
            : 1;

        }
    }
}