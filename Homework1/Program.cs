using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Создать и заполнить массив из 10 элементов значениями 2 в степени индекса элемента
            //(результирующий массив - [1 2 4 8 .... 512]) 
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Pow(2, i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            //Задание 2
            //В целочисленном массиве из 10 элементов поменять местами максимальное и минимальное значение.
            Console.Write("\n\n\nНачальный массив: ");

            Random rnd = new Random();

            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(0, 100);
            }
            int min = arr1[0];
            int index_min = 0;
            int max = arr1[0];
            int index_max = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < min) { min = arr1[i]; index_min = i; }
                if (arr1[i] > max) { max = arr1[i]; index_max = i; }
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }

            arr1[index_min] = max;
            arr1[index_max] = min;
            Console.WriteLine("\nМинимальное число = {0}", min);
            Console.WriteLine("Максимальное число = {0}", max);
            Console.Write("Результат: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }
            Console.Write("\n\n\n\n");


            //Задание 3
            //Рассчитать среднее значение для элементов массива.

            int[] arr2 = new int[10];
            int summa = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0} ", arr2[i]);
                summa += arr2[i];
            }
            double length = arr2.Length;
            double average = summa / length;
            Console.WriteLine("\nСреднее значение для элементов массива = {0}", average);
        }
    }
}
