using System;
using System.Collections.Generic;

namespace ClasseRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("How many dices do you want to roll? ");

            int amountTimesRolledDice = ValidationDicesToRoll();
            List<Dice> dices = new List<Dice>();
            int index = 0, sumResultRolledDices = 0;
            while (index < amountTimesRolledDice)
            {
                WriteLine("");
                Write($"{++index} dice-> Enter the amount sides of your dice between 2 and 100: ");
                dices.Add(new Dice { AmountOfSides = GetAmountOfValidSides() });
                int myRolledDice = dices[--index].RolledDice();
                RolledDiceOddorEven(myRolledDice);
                sumResultRolledDices += myRolledDice;
                index++;
            }

            WriteLine($"The sum of {amountTimesRolledDice} Rolled Dices are {sumResultRolledDices}");
            WriteLine("Thank you for participation");
        }
        public static int ValidationDicesToRoll()
        {
            int validationAmountDices = int.Parse(ReadLine());
            if (validationAmountDices > 0)
            {
                return validationAmountDices;
            }
            Console.Clear();
            WriteLine("Amount out of range!\nPlease insert greather then 0\n");
            WriteLine("How many dices do you want to roll? ");
            return ValidationDicesToRoll();
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
                WriteLine($"The Rolled number is {rolledDice} and it is Odd!\n");
            }
            else
            {
                WriteLine($"The Rolled number is {rolledDice} and it is Even!\n");
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
