using System;

namespace Test20october2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Write your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            if (name == "danzhog")
            {
                Console.WriteLine("Tomorrow you have 2 lessons with incredible teachers");
            }
            else
            {
                Console.WriteLine("You should take your exams and go study");
            }
        }
    }
}
