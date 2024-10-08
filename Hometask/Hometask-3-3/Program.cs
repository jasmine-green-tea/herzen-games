using ComplexNumbers;

namespace hometask_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var z1 = new Complex(2, 3);
            var z2 = new Complex(0, 1);
            int n = 3;

            Console.WriteLine($"Первое комплексное число: " + z1);
            Console.WriteLine($"Второе комплексное число: " + z2);
            Console.WriteLine("Сумма комплексных чисел: " + (z1 + z2));
            Console.WriteLine("Разность комплексных чисел: " + (z1 - z2));
            Console.WriteLine("Произведение комплексных чисел: " + (z1 * z2));
            Console.WriteLine("Деление комплексных чисел: " + (z1 / z2));
            Console.WriteLine("Возведение комплексного числа в степень: " + z1.Power(n));
            Console.WriteLine("Нахождение угла: " + z1.Angle());
            Console.WriteLine("Модуль комплексного числа: " + z1.Abs());

        }
    }
}