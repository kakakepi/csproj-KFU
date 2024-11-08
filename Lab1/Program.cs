﻿using System;
using System.Globalization;

namespace lab_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа\n");
            Console.Write("Упражнение 2.1\n\nВведите своё имя:");
            string username = Console.ReadLine();
            Console.WriteLine($"Приветствую, {username}\n");
            Console.Write("Упражнение 2.2\n\nВведите Число:");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число 2:");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            if (numb2 != 0) {
                Console.WriteLine($"Результат деления {numb1} на {numb2} равняется {(double)numb1/numb2}.\n");
            }
            else {
                Console.WriteLine("Ошибка при делении на 0.\n");
            }
            Console.WriteLine("Домашняя работа 2.1\n");
            Console.Write("Введите букву:");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch =='я' || ch =='z') {
                Console.WriteLine("Это конечная буква алфавита. Следующая буква будет 'a'\n");
            }
            else if (ch == 'Я' || ch == 'Z') {
                Console.WriteLine("Это конечная буква алфавита. Следующая буква будет 'A'\n");
            }
            else {
                ch = (char)(ch + 1);
                Console.WriteLine($"Следующая буква алфавита: {ch}\n");
            }
            Console.WriteLine("Домашнее задание 2.2\n");
            Console.WriteLine("Напишите коэффиценты на новых строчках (a,b,c):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            var d = Math.Sqrt(b * b - 4 * a * c);
            Console.WriteLine($"x1 = {(b + d)/2*a}");
            Console.WriteLine($"x2 = {(b - d)/2*a}");
        }
    }
}