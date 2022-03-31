using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sein Izumita";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            // Writing App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            // Ask User For name
            Console.WriteLine("What is your name?");

            // Name input as string
            string nameInput = Console.ReadLine();
            Console.WriteLine("hello {0}... Let's play a game", nameInput);
            while (true)
            {

                // Set Correct number randomly
                Random random = new Random();

                // Using Random library to generate number
                int correctNumber = random.Next(1, 11);

                // init guess var
                int guess = 0;

                // Asking user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {


                    string input = Console.ReadLine();

                    // Ensure that the input is an int
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Please enter an integer number");

                        Console.ResetColor();

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("The number you have chosen is incorrect. Please choose another number...");

                        Console.ResetColor();

                    }

                }
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("You have chosen the correct number. Congratulations, you win :)");

                Console.ResetColor();

                // Ask to play again
                Console.WriteLine("Do you want to play again? Y/N");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Thank you for playing, take care!");
                    return;
                }
                else
                {
                    return;
                }
            }

        }
    }
}
