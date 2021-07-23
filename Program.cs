using System;
using System.Collections.Generic;

namespace ClasseRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice myDice = new Dice();
            
            Write("Enter the amount of sides of your dice between 2 and 100: ");
            myDice.AmountOfSides = GetAmountOfValidSides();
            WriteLine("");
            int rolledDice = myDice.RolledDice();
            RolledDiceOddorEven(rolledDice);
            
            WriteLine("Thank you for participation");
        }

        public static int GetAmountOfValidSides()
        {
            int AmountOfValidSides = int.Parse(ReadLine());

            if (AmountOfValidSides > 1 && AmountOfValidSides < 101)
            {
                return AmountOfValidSides;
            }
            Console.Clear();
            WriteLine($"The input amount is: {AmountOfValidSides}");
            Write("Amount out of range!\nPlease insert between 2 and 100: ");
            return GetAmountOfValidSides();
        }

        static void RolledDiceOddorEven(int rolledDice)
        {
            if (rolledDice % 2 == 0)
            {
                WriteLine($"The Rolled number is {rolledDice} and it is Odd!");
            }
            else
            {
                WriteLine($"The Rolled number is {rolledDice} and it is Even!");
            }
        }

        private static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
        private static void Write(string text)
        {
            Console.Write(text);
        }
        private static string ReadLine()
        {
           return Console.ReadLine();
        }
    }
}
