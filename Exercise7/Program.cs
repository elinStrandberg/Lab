using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addera(2, 3));
            Console.WriteLine(Moms(500.50));
            Console.WriteLine(Moms(100.5, 0.125));
        }

        private static double Moms(double number, double moms)
        {
            return number * moms;
        }

        private static double Moms(double number)
        {
            return number * 0.25;
        }

        private static double Addera(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
