using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void TakeСassette(Cassette cassette)
        {
            if (cassette.isTaken == false)
            {
                Console.WriteLine("You have successfully taken the cassette. Enjoy watching!");
                cassette.PersonWhoTakeTheCassette = Name;
                cassette.isTaken = true;
            }
            else
            {
                Console.WriteLine($"Sorry, the cassette is already taken by {cassette.PersonWhoTakeTheCassette}. Try to come back later or take another one.");
                return;
            }
        }
    }
}
