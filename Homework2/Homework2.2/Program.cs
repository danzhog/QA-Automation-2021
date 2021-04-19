using System;

namespace Homework2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = args[0].ToLower();
            Console.Write("Вариант 2: ни один символ в строке не должен повторяться\n");

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

            Console.WriteLine($"максимальная последовательность неодинаковых элементов = {MaxCounter}");
            Console.ReadKey();
        }
    }
}
