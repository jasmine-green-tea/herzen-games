using System;

namespace KR_1_1
{
    class Program
    {
        private static double x;

        public static int Factorial(int number)
        {
            int multi = 1;
            while (number != 0)
            {
                multi *= number;
                number--;
            }
            return multi;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Введите x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Вычислено: " + (x - Math.Pow(x, 3) / Factorial(3) +
                                                   Math.Pow(x, 5) / Factorial(5) -
                                                   Math.Pow(x, 7) / Factorial(7) +
                                                   Math.Pow(x, 9) / Factorial(9) -
                                                   Math.Pow(x, 11) / Factorial(11) +
                                                   Math.Pow(x, 13) / Factorial(13)));
        }
    }
}