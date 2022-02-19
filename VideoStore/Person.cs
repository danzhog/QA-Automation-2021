using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public void TakeСassette(Cassette cassette)
        {
            if (cassette.isAvalaible == true)
            {
                Console.WriteLine("You have successfully taken the cassette. Enjoy watching!\n");
                cassette.PersonWhoTookTheCassette = Name;
                cassette.isAvalaible = false;
            }
            else if (cassette.PersonWhoTookTheCassette == Name)
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by you. " +
                    $"You can take another one.\n");
                return;
            }
            else
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by {cassette.PersonWhoTookTheCassette}. " +
                    $"Try to come back later or take another one.\n");
                return;
            }
        }

        public void HandOverСassette(Cassette cassette)
        {
            if (cassette.PersonWhoTookTheCassette == Name)
            {
                Console.WriteLine("You have successfully handed over the cassette. We are waiting for you again!\n");
                cassette.PersonWhoTookTheCassette = null;
                cassette.isAvalaible = true;
            }
            else
            {
                Console.WriteLine($"Sorry, to hand over the tape, you must first take it.\n");
                return;
            }
        }
    }
}
