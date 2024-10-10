using System;

namespace hometask_1_3
{
    class Program
    {
        private static int a;
        private static int b;
        private static int c;

        static void Main(string[] args)
        {
            Console.WriteLine($"Введите a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите c:");
            c = Convert.ToInt32(Console.ReadLine());

            int d = b * b - (4 * a * c);

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine($"Нет корней");
                }
                else
                {
                    Console.WriteLine($"Количество решений: 1\nКорень: " + -c / b);
                }
                
            }
            else if (d > 0)
            {
                Console.WriteLine($"Количество решений: 2\nКорень 1: " + (-b + Math.Sqrt(d)) / 2 * a + 
                                                        "\nКорень 2: " + (-b - Math.Sqrt(d)) / 2 * a);

            }
            else if (d == 0)
            {
                Console.WriteLine($"Количество решений: 1\nКорень: " + -b / 2 * a);
            }
            else
            {
                Console.WriteLine($"Нет корней");
            }
        }
    }
}