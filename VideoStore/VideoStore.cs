using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore
{
    public class VideoStore
    {
        public List<Cassette> CassettesList { get; set; }
        public VideoStore(List<Cassette> cassettesList)
        {
            CassettesList = cassettesList;
        }

        private void GetFullInfo()
        {
            Console.WriteLine($"№\t {"Cassette Title",-15}\t " +
                $"{"Is available?",-15}\tWho took?");
            for (int i = 0; i < CassettesList.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t {CassettesList[i].MovieTitle,-15}\t " +
                    $"{CassettesList[i].isAvalaible,-15}" +
                    $"\t{CassettesList[i].PersonWhoTookTheCassette}");
            }
            Console.Write("\n");
        }

        public void Play()
        {
            string userChoice;
            userChoice = PromptUser();
            while (userChoice != "4")
            {
                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        GetFullInfo();
                        break;
                    case "2":
                        Console.Clear();
                        GetFullInfo();
                        TakeCassetteFullWay();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        GetFullInfo();
                        HandOverCassetteFullWay();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }                
                userChoice = PromptUser();
            }
        }

        private void HandOverCassetteFullWay()
        {
            int inputNumber;
            bool isInputOk = true;
            Console.Write("Print your Name and Surname: ");
            string nameSurname = Console.ReadLine();
            Person newUser = new Person(nameSurname);
            Console.Write("Print the number of cassette you wanna hand over: ");
            while (isInputOk)
            {
                bool isInputNumberOk = Int32.TryParse(Console.ReadLine(), out inputNumber);
                if (isInputNumberOk && inputNumber <= CassettesList.Count && inputNumber > 0)
                {
                    HandOverСassette(inputNumber, newUser);
                    isInputOk = false;
                }
                else
                {
                    Console.WriteLine("Invalid input.\nPlease, try again: ");
                }
            }
        }

        private void TakeCassetteFullWay()
        {
            int inputNumber;
            bool isInputOk = true;
            Console.Write("Print your Name and Surname: ");
            string nameSurname = Console.ReadLine();
            Person newUser = new Person(nameSurname);
            Console.Write("Print the number of cassette you wanna take: ");
            while (isInputOk)
            {
                bool isInputNumberOk = Int32.TryParse(Console.ReadLine(), out inputNumber);
                if (isInputNumberOk && inputNumber <= CassettesList.Count && inputNumber > 0)
                {
                    TakeСassette(inputNumber, newUser);
                    isInputOk = false;
                }
                else
                {
                    Console.Write("Invalid input.\nPlease, try again: ");
                }
            }        
        }

        private string PromptUser()
        {
            while (true)
            {
                Console.Write("Enter your choice:\n" +
                    "1. View the list of available cassettes\n" +
                    "2. Take an available cassette\n" +
                    "3. Hand over the borrowed cassette\n" +
                    "4. Exit\n");
                string choice = Console.ReadLine();
                Console.WriteLine("");
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                    return choice;
                else
                    Console.WriteLine("That was not a valid choice!\n");
            }
        }

        private void TakeСassette(int numberOfcassette, Person person)
        {
            int newNumberOfcassette = numberOfcassette - 1;
            if (CassettesList[newNumberOfcassette].isAvalaible == true)
            {
                Console.WriteLine("You have successfully taken the cassette. " +
                    "Enjoy watching!\n");
                CassettesList[newNumberOfcassette].PersonWhoTookTheCassette = person.Name;
                CassettesList[newNumberOfcassette].isAvalaible = false;
            }
            else if (CassettesList[newNumberOfcassette].PersonWhoTookTheCassette == person.Name)
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by you. " +
                    $"You can take another one.\n");
                return;
            }
            else
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by " +
                    $"{CassettesList[newNumberOfcassette].PersonWhoTookTheCassette}. " +
                    $"Try to come back later or take another one.\n");
                return;
            }
        }

        private void HandOverСassette(int numberOfcassette, Person person)
        {
            int newNumberOfcassette = numberOfcassette - 1;
            if (CassettesList[newNumberOfcassette].PersonWhoTookTheCassette == person.Name)
            {
                Console.WriteLine("You have successfully handed over the cassette. " +
                    "We are waiting for you again!\n");
                CassettesList[newNumberOfcassette].PersonWhoTookTheCassette = null;
                CassettesList[newNumberOfcassette].isAvalaible = true;
            }
            else
            {
                Console.WriteLine($"Sorry, to hand over the cassette, " +
                    $"you must first take it.\n");
                return;
            }
        }
    }
}
