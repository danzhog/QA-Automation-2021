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

        public void AddCassetteToList(Cassette cassette)
        {
            CassettesList.Add(cassette);
        }

        public void GetFullInfo()
        {
            //Console.WriteLine("List of our Cassettes".PadLeft(49));
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

        public void TakeСassette(int numberOfcassette, Person person)
        {
            if (CassettesList[numberOfcassette-1].isAvalaible == true)
            {
                Console.WriteLine("You have successfully taken the cassette. " +
                    "Enjoy watching!\n");
                CassettesList[numberOfcassette-1].PersonWhoTookTheCassette = person.Name;
                CassettesList[numberOfcassette-1].isAvalaible = false;
            }
            else if (CassettesList[numberOfcassette-1].PersonWhoTookTheCassette == person.Name)
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by you. " +
                    $"You can take another one.\n");
                return;
            }
            else
            {
                Console.WriteLine($"Sorry, the cassette has already been taken by " +
                    $"{CassettesList[numberOfcassette-1].PersonWhoTookTheCassette}. " +
                    $"Try to come back later or take another one.\n");
                return;
            }
        }

        public void HandOverСassette(int numberOfcassette, Person person)
        {
            if (CassettesList[numberOfcassette-1].PersonWhoTookTheCassette == person.Name)
            {
                Console.WriteLine("You have successfully handed over the cassette. " +
                    "We are waiting for you again!\n");
                CassettesList[numberOfcassette-1].PersonWhoTookTheCassette = null;
                CassettesList[numberOfcassette-1].isAvalaible = true;
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
