using System;

namespace ClasseRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber, rolledNumber;
            bool restartProcess = true;
            while (restartProcess)
            {
                bool invalidInput = true;
                Write("Write a number from 1 to 100 to define a range: ");
                inputNumber = int.Parse(ReadLine());
                
                if (inputNumber > 0 && inputNumber < 101)
                {
                    AllowedNumber(inputNumber, out rolledNumber);
                    restartProcess = false;
                }
                else
                {
                    WriteLine("Number out of Range, please insert a valid number between 1 to 100!");
                    BlockedNumber(ref restartProcess, ref invalidInput);
                }

            }
            WriteLine("Thank you for participation");
        }

        private static void AllowedNumber(int inputNumber, out int rolledNumber)
        {
            Random rd = new Random();
            rolledNumber = rd.Next(1, inputNumber);
            if (rolledNumber % 2 == 0)
            {
                WriteLine($"The Rolled number is {rolledNumber} and it is Odd!");
            }
            else
            {
                WriteLine($"The Rolled number is {rolledNumber} and it is Even!");
            }
            
        }
        private static void BlockedNumber(ref bool restartProcess, ref bool invalidInput)
        {
            while (invalidInput)
            {
                Write("Do you want to try again? [y/n]: ");
                {
                    string TryAgain = ReadLine().ToString();
                    if (TryAgain == "Y" || TryAgain == "y")
                    {
                        WriteLine("");
                        invalidInput = false;
                    }
                    else if (TryAgain == "N" || TryAgain == "n")
                    {
                        WriteLine("");
                        invalidInput = false;
                        restartProcess = false;
                        WriteLine("Finished process");
                    }
                    else
                    {
                        WriteLine("");
                        WriteLine("Invalid handwriting, please insert a valid one!");
                    }
                }
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
