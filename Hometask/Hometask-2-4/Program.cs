using System;

namespace hometask_2_2
{
    class Program
    {
        private static int n;
        private static List<int> list = new List<int>(n);

        static void Main(string[] args)
        {
            Console.WriteLine($"Введите n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите значения:");
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int temp;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Отсортированный массив:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
