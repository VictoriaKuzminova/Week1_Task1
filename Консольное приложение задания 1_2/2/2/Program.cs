    using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите двузначное число: ");
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        if (num <= 10 || num >= 100)
                        {
                            Console.WriteLine("Число должно быть двузначным!");
                            continue;
                        }
                    }
                    else
                    {
                        if (num <= -100 || num >= -10)
                        {
                            Console.WriteLine("Число должно быть двузначным!");
                           continue;
                        }
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }

            int num1;
            if (num < 0)
            {
                num1 = -1 * (num / 10);
            }
            else
            {
                num1 = num / 10;
            }
            int num2;
            if (num > 0)
            {
                num2 = num % 10;
            }
            else
            {
                num2 = -1 * (num % 10);
            }
            if (num1 > num2) Console.WriteLine("Первое число больше второго");
            else if (num1 < num2) Console.WriteLine("Первое число меньше второго");
            else Console.WriteLine("Числа равны");
        }
    }
}
