using System;

namespace Homework2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = args[0];
            Console.Write($"Вариант 2: Подстрока, состоящая из уникальных неодинаковых символов, " +
                "расположенных последовательно в строке " + startString + "\n");
            int numberOfUniqeElements = GetNumberOfDifferentUniqueElements(startString);
            Console.WriteLine($"максимальная последовательность " +
                $"неодинаковых уникальных элементов = {numberOfUniqeElements}");
            Console.ReadKey();
        }

        static int GetNumberOfDifferentUniqueElements(string str)
        {
            string Str = str.ToLower();

            int Counter = 1;
            int MaxCounter = 0;

            int[] StrNew = new int[Str.Length];
            StrNew[0] = Str[0];

            for (int i = 1; i < Str.Length; i++)
            {
                for (int j = 0; j < Str.Length; j++)
                {
                    if (Str[i] == StrNew[j])
                    {
                        if (Counter > MaxCounter)
                        {
                            MaxCounter = Counter;
                        }

                        Counter = 0;
                        break;
                    }
                }

                StrNew[i] = Str[i];

                if (Counter > MaxCounter)
                {
                    MaxCounter = Counter;
                }

                Counter++;
            }

            return MaxCounter;
        }
    }
}
