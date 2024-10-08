using System;

namespace hometask_11_1
{
    class Program
    {
        private static string path = "..\\..\\..\\sin.txt";

        static void Main(string[] args)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine($"x\tsinx");
                for (double i = 0; i <= 1.01f; i += 0.1f)
                {
                    sw.WriteLine($"{i.ToString("0.000")}\t{Math.Sin(i).ToString("0.000")}");
                }
            }
        }
    }
}