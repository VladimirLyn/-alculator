﻿using System;

namespace Сalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение 4.Деление");

                int operation = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Результат операции {result}");
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Результат операции {result}");
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Результат операции {result}");
                        break;

                    case 4:
                        result = num1 / num2;
                        Console.WriteLine($"Результат операции {result}");
                        break;

                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }
            }
        }
    }
}
