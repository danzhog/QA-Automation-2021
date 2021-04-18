using System;

namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = args[0].ToLower();
            Console.Write("Вариант 1: как только два символа подряд одинаковые, то заканчиваем подсчет\n");

            int Counter = 1;
            int MaxCounter = 0;

            for (int i = 1; i < Str.Length; i++)
            {
                if (Str[i] != Str[i-1])
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
            Console.WriteLine($"максимальное количество неодинаковых элементов, следующих друг за другом = {MaxCounter}");
            Console.ReadKey();
        }
    }
}