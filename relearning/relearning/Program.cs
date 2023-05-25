using System;

namespace relearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Welcome to the least fun game you've played!");
            Console.WriteLine("Were going to play rock, paper, scissors!");
            Console.WriteLine("Type in your choice, press enter, and we'll both see who wins!");
            String answer = Console.ReadLine();


            // I do realize that it's impossible to win, in another version, have the application pull a random number between 1 and 3, correlate those to rock paper or scissors, and then you have a nice game!
            if (answer == "rock")
            {
                Console.WriteLine("paper! I win!");
            }
            else if (answer == "paper")
            {
                Console.WriteLine("scissors! I win!");
            }
            else if (answer == "scissors")
            {
                Console.WriteLine("rock! I win!");
            }
            else {
                Console.WriteLine("Cheater! That isnt a proper guess!");
            }

            Console.WriteLine("Alright, fine, heres one you can actually win, press enter to proceed");
            Console.ReadLine();

            */


            Console.WriteLine("You're playing: Rock Paper Scissors, against a random number generator");
            rpsGame();


            for (String i = "balls"; i == "balls";) {
                Console.WriteLine(" ");
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                String anss = Console.ReadLine();
                if (anss == "1")
                {
                    Console.WriteLine(" ");
                    rpsGame();
                    i = "balls";
                }
                else {
                    i = "ball"; // can be anything but "balls"
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Please hit enter to close the program");
            Console.ReadLine(); // just here to keep open the terminal window, press enter to close the program after
        }

        public static void rpsGame() {

            var rand = new Random();
            int guess = rand.Next(3);
            Console.WriteLine("Please input your guess: ");
            String playerGuess = Console.ReadLine();
            // this is all probably bad practice

            // rock
            if (guess == 0 && playerGuess == "rock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  Draw!");
            }
            else if (guess == 0 && playerGuess == "scissors")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  I win!");
            }
            else if (guess == 0 && playerGuess == "paper")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  You win!");
            }
            // paper 
            else if (guess == 1 && playerGuess == "rock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  I Win!");
            }
            else if (guess == 1 && playerGuess == "paper")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  Draw!");
            }
            else if (guess == 1 && playerGuess == "scissors")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  You win!");
            }
            //scissors
            else if (guess == 2 && playerGuess == "rock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  You win!");
            }
            else if (guess == 2 && playerGuess == "paper")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  I win!");
            }
            else if (guess == 2 && playerGuess == "scissors")
            {
                Console.WriteLine(" ");
                Console.WriteLine("||  Draw!");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Error: Please try again.");
            }

        }
    }
}