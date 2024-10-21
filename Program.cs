//*********************************************************
// Практическая работа № 9                             *
// Выполнила: Беляева Е.А., группа 2-ИСП-д                *
// Задание: составить программу работы линейного алгоритма*
//*********************************************************





using System;


class Program

{

    static void Main()

    {

        int minNumber = int.MaxValue; // Начальное значение для минимального числа

        int inputNumber;


        Console.WriteLine("Введите положительные числа (введите 0 для завершения):");


        while (true)

        {

            try

            {

                inputNumber = Convert.ToInt32(Console.ReadLine());


                if (inputNumber == 0)

                {

                    break; // Завершение ввода

                }


                if (inputNumber > 0)

                {

                    if (inputNumber < minNumber)

                    {

                        minNumber = inputNumber; // Обновление минимального числа

                    }

                }

                else

                {

                    Console.WriteLine("Пожалуйста, вводите только положительные числа.");

                }

            }

            catch (FormatException)

            {

                Console.WriteLine("Ошибка: введите корректное целое число.");

            }

        }


        if (minNumber != int.MaxValue)

        {

            Console.WriteLine($"Минимальное число: {minNumber}");

        }

        else

        {

            Console.WriteLine("Не было введено ни одного положительного числа.");

        }

    }

}