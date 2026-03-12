using System;
using System.Globalization;

namespace Lab1Charp
{
    class Program
    {
        // --- Завдання 1.6 ---
        static void Task1()
        {
            Console.WriteLine("\n--- Завдання 1.6: Обчислення гіпотенузи ---");
            Console.Write("Введіть катет a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть катет b: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Гіпотенуза: {c}");
        }

        // --- Завдання 2.6 ---
        static void Task2()
        {
            Console.WriteLine("\n--- Завдання 2.6: Рівняння ax^2+bx+c=0 ---");
            Console.Write("Введіть a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введіть c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b != 0) Console.WriteLine("Так, рівняння має один розв'язок (лінійне).");
                else if (c == 0) Console.WriteLine("Так, рівняння має безліч розв'язків.");
                else Console.WriteLine("Ні, рівняння не має розв'язків.");
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d >= 0) Console.WriteLine("Так, рівняння має дійсні розв'язки.");
                else Console.WriteLine("Ні, рівняння не має дійсних розв'язків.");
            }
        }

        // --- Завдання 3.6 ---
        static void Task3()
        {
            Console.WriteLine("\n--- Завдання 3.6: Перевірка точки на площині ---");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            double r2 = x * x + y * y;

            if (r2 < 144 && x > 0 && y < x)
            {
                Console.WriteLine("Так");
            }
            else if (r2 > 144 || x < 0 || y > x)
            {
                Console.WriteLine("Ні");
            }
            else
            {
                Console.WriteLine("На межі");
            }
        }

        // --- Завдання 4.6 ---
        static void Task4()
        {
            Console.WriteLine("\n--- Завдання 4.6: Визначення поточного місяця ---");
            Console.Write("Введіть кількість днів (n > 0): ");
            int n = int.Parse(Console.ReadLine());

            DateTime startDate = new DateTime(1990, 1, 1);
            DateTime targetDate = startDate.AddDays(n);

            string monthName = targetDate.ToString("MMMM", new CultureInfo("uk-UA"));
            Console.WriteLine($"Поточний місяць: {monthName}");
        }

        // --- Допоміжна функція для Завдання 5.6 ---
        static double Subtract(double a, double b)
        {
            return a - b;
        }

        // --- Завдання 5.6 ---
        static void Task5()
        {
            Console.WriteLine("\n--- Завдання 5.6: Різниця двох дійсних чисел ---");
            Console.Write("Введіть перше число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Різниця: {Subtract(num1, num2)}");
        }

        // --- Завдання 6.6 ---
        static void Task6()
        {
            Console.WriteLine("\n--- Завдання 6.6: Обчислення математичного виразу ---");
            Console.Write("Введіть дійсне число x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введіть дійсне число y: ");
            double y = double.Parse(Console.ReadLine());

            double result = x * y + (x + y * y + 3) / (x * x + 5);
            Console.WriteLine($"Результат обчислення виразу: {result}");
        }

        // --- ГОЛОВНЕ МЕНЮ ПРОГРАМИ ---
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine("Оберіть завдання для запуску (1-6) або введіть 0 для виходу:");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Роботу завершено. Успіхів!");
                    break;
                }

                switch (choice)
                {
                    case "1": Task1(); break;
                    case "2": Task2(); break;
                    case "3": Task3(); break;
                    case "4": Task4(); break;
                    case "5": Task5(); break;
                    case "6": Task6(); break;
                    default:
                        Console.WriteLine("Неправильне введення. Введіть число від 1 до 6.");
                        break;
                }
            }
        }
    }
}