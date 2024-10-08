using System;

namespace hometask_1_1
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            Console.Write($"Введите n:\n");
            n = Convert.ToInt32(Console.ReadLine() );

            for (int i = 2; i < n; i++)
            {
                int j;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                } 
                if (i == j)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}