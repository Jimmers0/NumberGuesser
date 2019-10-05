using System;

//Namespace

namespace NumberGuesser

    // Main Class
{
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {



                //Set correct number
                //int correctNumber = 7;

                //create random number
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "This is not a nnumber... guess a number!");

                        ////Keep going
                        continue;
                    }
                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Incorrect!");

                    }
                }

                //Output Success Message

                //Change text color
                PrintColorMessage(ConsoleColor.Yellow, "Correct!");


                //Reset text color
                Console.ResetColor();

                //Ask to play again?
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                } else
                {
                    return;
                }

            }



        }
        static void GetAppInfo()
        {

            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jamie Randall";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset ConsoleColor
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //get user input

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Lets play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Write out app info
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
