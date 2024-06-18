using System;

namespace ProgramGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Guesser App";
            string appVersion = "1.0";
            string appAuthor = "Scott_limited";
            string appDescription = "This is a number guesser application";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("App Name: {0} Version: {1} By: {2}", appName, appVersion, appAuthor);
            Console.WriteLine("About: " +appDescription);
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game", name);
            while (true)
            {
                Random randomNumber = new Random();
                int correctNumber = randomNumber.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10!");

                while (guess != correctNumber)
                {
                    string number = Console.ReadLine();
                    if (!int.TryParse(number, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong character, Please enter a number!!!");
                        Console.ResetColor();
                        continue;
                    }
                    guess = Int32.Parse(number);
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Answer!!!");
                        Console.ResetColor();
                        Console.WriteLine("Try again");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("GOOD Guess " + name);
                        Console.ResetColor();
                        

                    }
                }
                Console.WriteLine("Want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }

        }
    }
}