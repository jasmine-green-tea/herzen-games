using System;

namespace class_task_1_1
{
    class Program
    {
        private static int a;
        private static int b;

        static void Main(string[] args)
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.Write($"Переменная a = {a}, переменная b = {b}");
            Console.ReadKey();
        }
    }
}
