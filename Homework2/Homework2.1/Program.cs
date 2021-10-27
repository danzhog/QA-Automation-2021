using System;

namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = args[0];
            Console.Write("Вариант 1: Подстрока, состоящая из НЕуникальных неодинаковых символов, " +
                "расположенных последовательно в строке\n");
            Console.Write($"Введена строка: " + givenString + "\n");

            int numberOfNonUniqueElements = GetNumberOfDifferentNonUniqueElements(givenString);

            Console.WriteLine($"максимальная последовательность неодинаковых " +
                $"НЕуникальных элементов  = {numberOfNonUniqueElements}");
            Console.ReadKey();
        }

        static int GetNumberOfDifferentNonUniqueElements(string str)
        {
            string Str = str.ToLower();
            int Counter = 1;
            int MaxCounter = 0;

            for (int i = 1; i < Str.Length; i++)
            {
                if (Str[i] != Str[i - 1])
                {
                    Counter++;
                    if (Counter > MaxCounter)
                    {
                        MaxCounter = Counter;
                    }
                }

                else
                {
                    if (Counter > MaxCounter)
                    {
                        MaxCounter = Counter;
                    }

                    Counter = 1;
                }
            }
            
            return MaxCounter;
        }
    }
}
