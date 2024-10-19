//*********************************************************
// Практическая работа № 8                              *
// Выполнила: Беляева Е.А., группа 2-ИСП-д                *
// Задание: составить программу работы линейного алгоритма*
//*********************************************************






using System;

namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            // Объявляем переменную для хранения минимального значения
            int minValue = int.MaxValue;
            int input;

            // Начинаем бесконечный цикл
            while (true)
            {
                Console.Title = "Практическая работа №8"; // заголовок консоли
                Console.BackgroundColor = ConsoleColor.DarkGreen;// цвет консоли
                Console.ForegroundColor = ConsoleColor.DarkBlue;// цвет текста консоли 
                
                Console.WriteLine("Здравствуйте!");
                Console.Write("Введите положительное число (0 для завершения): ");
                input = Convert.ToInt32(Console.ReadLine()); // Считываем ввод пользователя

                // Проверяем, если введён 0, выходим из цикла
                if (input == 0)
                {
                    break; // Прерываем цикл
                }

                // Проверяем, является ли введённое число положительным и меньше текущего минимального
                if (input > 0 && input < minValue)
                {
                    minValue = input; // Обновляем значение минимального числа
                }
            }

            // Проверяем, было ли введено хотя бы одно положительное число
            if (minValue == int.MaxValue)
            {
                Console.WriteLine("Вы не ввели ни одного положительного числа.");
            }
            else
            {
                Console.WriteLine("Минимальное число: " + minValue); // Выводим минимальное число
            } Console.ReadKey();
        }
    }
}