using System;

namespace class_task_1_1
{
    class Program
    {
        private static int a;
        private static int b;

        static void Main(string[] args)
        {
            Console.Write($"Введите a:\n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите b:\n");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.Write($"Переменная a = {a}, переменная b = {b}\n");
            Console.Write($"Для завершения программы нажмите любую клавишу... ");
            Console.ReadKey();
        }
    }
}
