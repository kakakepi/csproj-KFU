using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗадание №1\n");
            Console.WriteLine("Число 'e' = 2.7");
            Console.WriteLine("\nЗадание №2\n");
            Console.WriteLine("50\n10");
            Console.WriteLine("\nЗадание №3\n");
            Console.WriteLine("45\n5213\n353\n343");
            Console.WriteLine("\nЗадание №4\n");
            Console.Write("Введите число, я прибавлю к нему 10:");
            int randnumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Получившееся число: {randnumb + 10}");
            Console.WriteLine("\nЗадание №5\n");
            Console.Write("Введите число - Сторону квадрата, а я найду его периметр");
            int squareside = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Периметр квадрата: {squareside * 4}");
            Console.WriteLine("\nЗадание №6\n");
            Console.Write("Введите число - радиус окружности, я найду ее площадь и длину");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Длина окружности: {radius * 2 * Math.PI}");
            Console.WriteLine($"Площадь окружности: {radius * radius * Math.PI}");
            Console.WriteLine("\nЗадание №7\n");
            Console.Write("Введите число x, я найду косинус:");
            double cosinus = Convert.ToDouble(Console.ReadLine());
            cosinus = cosinus * Math.PI / 180;
            Console.WriteLine($"Значение косинуса:{Math.Cos(cosinus)}");
            Console.WriteLine("\nЗадание №8\n");
            Console.WriteLine("Введите основания и высоту трапеции на двух строчках:");
            double foundation1 = Convert.ToDouble(Console.ReadLine());
            double foundation2 = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double side = Math.Sqrt((double)((foundation2 - foundation1) / 2) * (double)((foundation2 - foundation1) / 2) + height * height);
            Console.WriteLine($"Результат равен: {foundation1 + foundation2 + side * 2}");
            Console.WriteLine("\nЗадание №9\n");
            Console.WriteLine("Введите стоимость 1 кг яблок, далее 1 кг печеня, далее -конфет на разных строчках. Потом введите соответственно кол-во кг яблок, печенья, конфет:");
            int appleprice = Convert.ToInt32(Console.ReadLine());
            int cookieprice = Convert.ToInt32(Console.ReadLine());
            int candyprice = Convert.ToInt32(Console.ReadLine());
            int appleweight = Convert.ToInt32(Console.ReadLine());
            int cookieweight = Convert.ToInt32(Console.ReadLine());
            int candyweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость всей покупки: {appleprice * appleweight + candyprice * candyweight + cookieweight * cookieprice}");
            Console.WriteLine("\nЗадание №10\n");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("      Труд");
            Console.WriteLine("             Май");
            Console.WriteLine("\nЗадание №11\n");
            Console.WriteLine("Введите два числа:");
            try
            {
                double z123 = Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
                double z321 = Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
                Console.WriteLine($"ЧИслав другом порядке {z321}, {z123}");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Ошибка. {exc.Message}");
            }
            Console.WriteLine("\nЗадание №12\n");
            Console.WriteLine("Какую фигуру используем? 1- прямоугольник, 2 - круг, 3 - треугольник");
            int figure = Convert.ToInt32(Console.ReadLine());
            switch (figure)
            {
                case 1:
                    Console.WriteLine("Напишите стороны прямоугольника:");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    int side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Что вы хотите искать? 1- площадь, 2 - периметр.");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    switch (numb1)
                    {
                        case 1:
                            Console.WriteLine($"Площадь {side1 * side2}");
                            break;
                        case 2:
                            Console.WriteLine($"Периметр {side1 * 2 + side2 * 2}");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Впишите радиус круга:");
                    int radius1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Что вы хотите искать? 1- площадь, 2 - периметр.");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    switch (numb2)
                    {
                        case 1:
                            Console.WriteLine($"Площадь {radius1 * radius1 * Math.PI}");
                            break;
                        case 2:
                            Console.WriteLine($"Периметр {2 * radius1 * Math.PI}");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Впишите стороны треугольника");
                    int triangleside1 = Convert.ToInt32(Console.ReadLine());
                    int triangleside2 = Convert.ToInt32(Console.ReadLine());
                    int triangleside3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Что вы хотите искать? 1- площадь, 2 - периметр.");
                    int numb3 = Convert.ToInt32(Console.ReadLine());
                    switch (numb3)
                    {
                        case 1:
                            double p = (double)(triangleside1 + triangleside2 + triangleside3) / 2;
                            Console.WriteLine($"Площадь {Math.Sqrt(p * (p - triangleside1) * (p - triangleside2) * (p - triangleside3))}");
                            break;
                        case 2:
                            Console.WriteLine($"Периметр {triangleside1 + triangleside2 + triangleside3}");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Выбрана неправильная фигура");
                    break;
            }
            Console.WriteLine("\nЗадание №13\n");
            Console.WriteLine("Введите число, а я выведу в терминал:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {number}");
            Console.WriteLine("\nЗадание №14\n");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            Console.WriteLine("\nЗадание №15\n");
            Random rand = new Random();
            int randnumbe1 = rand.Next(1, 10000);
            int randnumbe2 = rand.Next(1, 10000);
            int randnumbe3 = rand.Next(1, 10000);
            int randnumbe4 = rand.Next(1, 10000);
            Console.WriteLine($"Случайные числа:\n{randnumbe1}\n{randnumbe2}\n{randnumbe3}\n{randnumbe4}");
            Console.WriteLine("\nЗадание №16\n");
            Console.WriteLine("Напишите коэффиценты на новых строчках (a,b,c):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            var d = Math.Sqrt(b * b - 4 * a * c);
            Console.WriteLine($"x1 = {(b + d) / 2 * a}");
            Console.WriteLine($"x2 = {(b - d) / 2 * a}");
            Console.WriteLine("\nЗадание №17\n");
            Console.WriteLine("Впишите в столбик два числа,я выведу сначала среднее геометрическое, потом среднее арифметическое");
            double avgnumb1 = Convert.ToDouble(Console.ReadLine());
            double avgnumb2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{Math.Sqrt(avgnumb1 * avgnumb2)}, {(avgnumb1 + avgnumb2) / 2}");
            Console.WriteLine("\nЗадание №18\n");
            Console.WriteLine("Введите по очереди координаты x,y точки 1, далее x,y у точки 2");
            double point1x = Convert.ToDouble(Console.ReadLine());
            double point1y = Convert.ToDouble(Console.ReadLine());
            double point2x = Convert.ToDouble(Console.ReadLine());
            double point2y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Расстояние между точками: {Math.Sqrt((point1x - point2x) * (point1x - point2x) + (point1y - point2y) * (point1y - point2y))}");
            Console.WriteLine("\nЗадание №19\n");
            Console.WriteLine("Введите значение a,b,c в столбик");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            int tempa1 = a1;
            int tempb1 = b1;
            int tempc1 = c1;
            a1 = tempb1;
            b1 = tempc1;
            c1 = tempa1;
            Console.WriteLine($"Значения a,b,c схема А {a1},{b1},{c1}");
            b1 = tempa1;
            c1 = tempb1;
            a1 = tempc1;
            Console.WriteLine($"Значения a,b,c схема Б {a1},{b1},{c1}");
            Console.WriteLine("\nЗадание №20\n");
            Console.WriteLine("Кол-во секунд введите:");
            int secondtimer = Convert.ToInt32(Console.ReadLine());
            int hourtimer = secondtimer / 3600;
            int minutes = (secondtimer % 3600) / 60;
            int seconds = secondtimer % 60;
            Console.WriteLine($"Часы: {hourtimer}, Минуты в последнем часе: {minutes}, Секунды в последней минуте: {seconds}");
            Console.WriteLine("\nЗадание №21\n");
            Console.WriteLine($"Кол-во квадратор: {(130 * 543) / (130 * 130)}");
            Console.WriteLine("\nЗадание №22\n");
            Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число:");
            int threestripes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Полученное число: {(threestripes % 10) * 100 + threestripes / 10}");
            Console.WriteLine("\nЗадание №23\n");
            Console.WriteLine("Введите число n>999:");
            int number007 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Кол-во сотен в числе: {number007 / 100}, Тысяч: {number007 / 1000}");
            Console.WriteLine("\nЗадание №24\n");
            Console.WriteLine("Введите ЧЕТЫРЕХЗНАЧНОЕ число:");
            int fourstripes = Convert.ToInt32(Console.ReadLine());
            int number70 = fourstripes % 10;
            int number71 = (fourstripes / 10) % 10;
            int number72 = (fourstripes / 100) % 10;
            int number73 = fourstripes / 1000;
            Console.WriteLine($"reverse: {number70 * 1000 + number71 * 100 + number72 * 10 + number73} ");
            Console.WriteLine($"Число '2-1-4-3': {number72 * 1000 + number73 * 100 + number70 * 10 + number71}");
            Console.WriteLine($"Число '1-3-2-4': {number73 * 1000 + number71 * 100 + number72 * 10 + number70}");
            Console.WriteLine($"Число '3-4-1-2': {number71 * 1000 + number70 * 100 + number73 * 10 + number72} ");
            Console.WriteLine("\nЗадание №25\n");
            Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число:");
            int threestripes1488 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Исходное число: {(threestripes1488 % 100) * 10 + threestripes1488 / 100}");
            Console.WriteLine("\nЗадание №26\n");
            Console.WriteLine("Введите сначала кол-во минут, далее - секунд, далее - часов:");
            double elminute = Convert.ToDouble(Console.ReadLine());
            double elsecunde = Convert.ToDouble(Console.ReadLine());
            double elhourse = Convert.ToDouble(Console.ReadLine()) % 12;
            Console.WriteLine($"Угол равен:{((elminute * 60 + elsecunde + elhourse * 3600) / 43200) * 360}");
            Console.WriteLine("\nЗадание №27\n");
            double angle666 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Часы: {(int)((angle666 / 360) * 43200) / 3600}, Минуты: {(int)((angle666 / 360) * 43200) / 60 % 60}");
            Console.WriteLine("\nЗадание №28\n");
            Console.WriteLine("Введите 3 числа:");
            int numbernine = Convert.ToInt32(Console.ReadLine());
            int numberten = Convert.ToInt32(Console.ReadLine());
            int number11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Меньшее число {Math.Min(Math.Min(Math.Abs(numbernine), Math.Abs(numberten)), Math.Abs(number11))}");
            Console.WriteLine("\nЗадание №29\n");
            Console.WriteLine("Введите 3 числа:");
            int number1337 = Convert.ToInt32(Console.ReadLine());
            int number228 = Convert.ToInt32(Console.ReadLine());
            int number777 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма большего и меньшего равна {Math.Min(Math.Min(number1337, number228), number777) + Math.Max(Math.Max(number1337, number228), number777)}");
            Console.WriteLine("\nЗадание №30\n");
            Console.WriteLine("Впишите натуральное число:");
            double naturnumb = Convert.ToDouble(Console.ReadLine());
            int delitsum = 0;
            for (int i = 1; i <= Math.Sqrt(naturnumb); i++)
            {
                if (naturnumb % i == 0)
                {
                    delitsum++;
                    if (i != Math.Sqrt(naturnumb))
                    {
                        delitsum++;
                    }
                }
            }
            Console.WriteLine($"Общее кол-во делителей у числа: {delitsum}");
            Console.WriteLine("\nЗадание №31\n");
            Console.WriteLine("Введите друг под другом коэффиценты A,B,C,D:");
            int a3k = Convert.ToInt32(Console.ReadLine());
            int b3k = Convert.ToInt32(Console.ReadLine());
            int c3k = Convert.ToInt32(Console.ReadLine());
            int d3k = Convert.ToInt32(Console.ReadLine());
            for (int i = -100; i <= 100; i++)
            {
                double res = a3k * Math.Pow(i, 3) + b3k * Math.Pow(i, 2) + c3k * i + d3k;
                if (res == 0)
                {
                    Console.WriteLine($"Корень уравнения: {i}");
                }
            }
            Console.WriteLine("\nЗадание №32\n");
            Console.WriteLine("Сначала впишите 1 и 2 элементы, далее - номер искомого элемента:");
            int alphamf = Convert.ToInt32(Console.ReadLine());
            int betamf = Convert.ToInt32(Console.ReadLine());
            int numbmf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Искомый элемент прогрессии: {alphamf + (betamf - alphamf) * (numbmf - 1)}");
            Console.WriteLine("\nЗадание №33\n");
            Console.WriteLine("Вы студент? Вы пенсионер? Вы трудоустроен? Ответы дать на трех разных строчках. (да/нет). иные не принимаются:");
            string student = Console.ReadLine();
            string pensioner = Console.ReadLine();
            string employee = Console.ReadLine();
            if (((pensioner == "да" || student == "да") && employee == "нет") && !(pensioner == "да" & student == "да"))
            {
                Console.WriteLine("Вам дадут кредит.");
            }
            else
            {
                Console.WriteLine("Вам не дадут кредит.");
            }
            Console.WriteLine("\nЗадание №34\n");
            Console.WriteLine("Введите имя");
            string namename = Console.ReadLine();
            Console.WriteLine($"{namename}");
            Console.WriteLine($"Привет, {namename}");
            Console.WriteLine("\nЗадание №35\n");
            Console.WriteLine("Как зовут?");
            string namenamename = Console.ReadLine();
            Console.WriteLine($"Привет, {namenamename}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            rand = new Random();
            Console.ForegroundColor = (ConsoleColor)rand.Next(1, 16);
            Console.WriteLine("\nЗадание №36\n");
            Console.WriteLine("1 -рандомные цифры, 2 - впишите цифры");
            int choice = Convert.ToInt32(Console.ReadLine());
            string[] digits = new string[12];
            if (choice == 1)
            {
                rand = new Random();
                for (int i = 0; i < 12; i++) digits[i] = rand.Next(0, 10).ToString();
            }
            else
            {
                Console.WriteLine("Введите цифры:");
                digits = Console.ReadLine().Split(' ');
            }
            int sum = 0;
            for (int i = 0; i <= 12; i++) sum += Convert.ToInt32(digits[i]) * (i % 2 == 0 ? 1 : 3);
            double zzzz = (10 - (sum % 10)) % 10;
            Console.WriteLine($"Контрольная сумма: {zzzz}");
        }
    }
}