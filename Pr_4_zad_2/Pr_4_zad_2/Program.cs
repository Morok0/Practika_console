using System;

namespace Pr_4_zad_2
{
    class Program
    {
        static void F(double q, double b, int n, out double fn, out double sum)
        {
            if (n > 1)
            {
                F(q, b, n - 1, out fn, out sum);
                fn = fn * q;
                sum += fn;

            }
            else { fn = b; sum = b; };
        }
        static void Main(string[] args)
        {
            Console.Write("q = ");
            double q = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            double sum;
            double fn;
            F(q, b, n, out fn, out sum);

            Console.WriteLine("fn =" + fn);
            Console.WriteLine("sum =" + sum);

        }

    }
}
