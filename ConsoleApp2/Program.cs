using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону треугольника А:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника В:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника С:");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a + b > c) && (b + c > a) && (c + a > b))
                Console.WriteLine("Такой треугольник существует");
            else Console.WriteLine("Такой треугольник не существует");
        }
    }
}
