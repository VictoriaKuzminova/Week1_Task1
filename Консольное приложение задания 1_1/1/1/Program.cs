using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            while (true)
            {
                try
                {
                    Console.Write("Введите значвение 1-го катета: ");
                    a = double.Parse(Console.ReadLine());
                    if (a <= 0)
                    {
                        Console.WriteLine("Катет не может быть меньше или равен 0!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите значение 2-го катета: ");
                    b = double.Parse(Console.ReadLine());
                    if (b <= 0)
                    {
                        Console.WriteLine("Катет не может быть меньше или равен 0!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            double S = (a * b ) / 2;
            Console.WriteLine("Площадь прямоугольного треугольника равна " + S);
        }
    }
}
