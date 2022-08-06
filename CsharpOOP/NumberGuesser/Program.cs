using System;

namespace NumberGuesser 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appName = "Bingo Game";
            string appVersion = "1.0.0";
            string appAuthor = "Ying";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, Let's play a game", inputName);

            while (true)
            {

                // Set correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Guess number
                int guessCount = 0;
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 to 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Not a valid number");
                        continue;
                        Console.ForegroundColor = ConsoleColor.Red;
                        guess = Convert.ToInt32(input);
                        guessCount += 1;
                        Console.WriteLine("Wrong number, please try again");
                        Console.ResetColor();
                    }
        
                    Console.Beep();
                    Console.WriteLine("Amazing!");
                   
                }


                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
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