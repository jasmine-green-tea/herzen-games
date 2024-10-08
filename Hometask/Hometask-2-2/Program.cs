using System;

namespace hometask_2_2
{
    class Program
    {
        private static List<int> list = new List<int>(10);
        private static int maxFirst = -1;
        private static int maxSecond = -1;

        static void Main(string[] args)
        {

            Console.WriteLine($"Введите 10 положительных чисел:");
            for (int i = 0; i < 10; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < 10; i++)
            {
                if (list[i] > maxFirst)
                {
                    maxSecond = maxFirst;
                    maxFirst = list[i];
                }
                if (list[i] < maxFirst && list[i] > maxSecond)
                    maxSecond = list[i];
            }
            Console.WriteLine($"Первое наибольшее значение: " + maxFirst + "\nВторое наибольшее значение: " + maxSecond);
        }
    }
}