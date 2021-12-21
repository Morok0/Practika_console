using System;
namespace Hello
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                double e = 2.718281828;
                if (x == -1) throw new Exception();
                else return Math.Pow(e , (x-1)*(x-1)/x);
            }
            catch
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}