using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the number the user has to guess
            int favoriteNumber = 7;

            Console.WriteLine("Guess my favorite number. Hint: less than 10");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Too low!");
            }

            if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Too high!");
            }

            if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You are correct!");
            }

            else
            {
                Console.WriteLine("Oh well");
            }
        }
    }
}
