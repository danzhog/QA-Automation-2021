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

        public void TakeСassette(int numberOfcassette, VideoStore videoStore)
        {
            if (videoStore.CassettesList[numberOfcassette].isAvalaible == true)
            {
                Console.WriteLine("You have successfully taken the cassette. Enjoy watching!\n");
                videoStore.CassettesList[numberOfcassette].PersonWhoTookTheCassette = Name;
                videoStore.CassettesList[numberOfcassette].isAvalaible = false;
            }
            else if (videoStore.CassettesList[numberOfcassette].PersonWhoTookTheCassette == Name)
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by you. " +
                    $"You can take another one.\n");
                return;
            }
            else
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by " +
                    $"{videoStore.CassettesList[numberOfcassette].PersonWhoTookTheCassette}. " +
                    $"Try to come back later or take another one.\n");
                return;
            }
        }

        public void HandOverСassette(int numberOfcassette, VideoStore videoStoreName)
        {
            if (videoStoreName.CassettesList[numberOfcassette].PersonWhoTookTheCassette == Name)
            {
                Console.WriteLine("You have successfully handed over the cassette. We are waiting for you again!\n");
                videoStoreName.CassettesList[numberOfcassette].PersonWhoTookTheCassette = null;
                videoStoreName.CassettesList[numberOfcassette].isAvalaible = true;
            }
            else
            {
                Console.WriteLine($"Sorry, to hand over the cassette, you must first take it.\n");
                return;
            }
        }
    }
}
