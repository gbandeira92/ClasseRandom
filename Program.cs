using System;

namespace ClasseRandom
{
    //Teste merge
    class Program
    {
        static void Main(string[] args)
        {
            int InputNumber;
            int RolledNumber;
            bool RestartProcess = true;
            while (RestartProcess == true)
            {
                bool InvalidInput = true;
                Write("Write a number from 1 to 100 to define a range: ");
                InputNumber = int.Parse(ReadLine());
                
                if (InputNumber > 0 && InputNumber < 101)
                {
                    Random rd = new Random();
                    RolledNumber = rd.Next(1, InputNumber);
                    if (RolledNumber % 2 == 0)
                    {
                        WriteLine($"The Rolled number is {RolledNumber} and it is Odd!");
                    }
                    else
                    {
                        WriteLine($"The Rolled number is {RolledNumber} and it is Even!");
                    }
                    RestartProcess = false;
                }
                else
                {
                    WriteLine("Number out of Range, please insert a valid number between 1 to 100!");
                    while (InvalidInput == true)
                    {
                        Write("Do you want to try again? [s/n]: ");
                        {
                            string TryAgain = ReadLine().ToString();
                            if (TryAgain == "S" || TryAgain == "s")
                            {
                                WriteLine("");
                                InvalidInput = false;
                            }
                            else if (TryAgain == "N" || TryAgain == "n")
                            {
                                WriteLine("");
                                InvalidInput = false;
                                RestartProcess = false;
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

            }
            WriteLine("Thanks for participation");
        }
        static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
        static void Write(string text)
        {
            Console.Write(text);
        }
        static string ReadLine()
        {
           return Console.ReadLine();
        }
    }
}
