using System;
using System.Text;
namespace NumeralSystem
{
    class NumeralSystem
    {
        const byte minBase = 2;
        const byte maxBase = 20;
        const string invalidInput = "Invalid input. Try again";
        static void Main(string[] args)
        {
            int inputNumber;
            byte newBaseNumber;

            Console.Write("Please, input an integer in decimal: ");
            bool isInputNumberOk = Int32.TryParse(Console.ReadLine(), out inputNumber);
            Console.Write("Please, input a new base number system from 2 to 20: ");
            bool isInputBaseNumberOk = Byte.TryParse(Console.ReadLine(), out newBaseNumber);

            if (isInputNumberOk && isInputBaseNumberOk)
            {
                Console.WriteLine("Your result is: " + ConvertNumberToANewBase(inputNumber, newBaseNumber)); 
            }
            else
            {
                Console.WriteLine(invalidInput);
            }
        }

        static string ConvertNumberToANewBase(int number, byte newBase)
        {
            if (newBase < minBase || newBase > maxBase || number < 0)
            {
                return invalidInput;
            }

            StringBuilder convertedNumber = new StringBuilder("");
            while (true)
            {
                convertedNumber.Insert(0, ConvertNumberToANewBaseSymbol(number % newBase));
                number /= newBase;

                if (number == 0) 
                    break;
            }

            return convertedNumber.ToString();
        }

        static char ConvertNumberToANewBaseSymbol(int num)
        {
            if (num > 9)
            {
                return (char)('A' - 10 + num);
            }

            return (char)('0' + num);
        }
    }
}
