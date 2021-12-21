using System;

namespace Pr_4_zad_1
{
    class Program
    {
        static double B(int n)
        {
            if (n < 1) throw new ArgumentException();
            if (n == 1) return 5;
            return (n - 1) * (n * n + n + 1);
        }

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine("b{0,-2} = {1}", i, B(i));
            }
            Console.ReadLine();
        }
    }
}
