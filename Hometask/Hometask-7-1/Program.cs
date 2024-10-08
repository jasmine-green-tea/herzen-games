using System;

namespace hometask_7_1
{
    class Program
    {
        private static int n;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Введите n:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
            }
        }
    }
}