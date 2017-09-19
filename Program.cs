using System;

namespace numberguess
{
    class Program
    {
        static void Main(string[] args)
        {
            int UpperNumber;
            bool invalidInput = true;
            Game Game;


            Console.Clear();
            System.Console.WriteLine("Hello, lets play guess the number. Provide an upper number for the game: ");
            while (invalidInput)
            {
                string userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out UpperNumber))
                {
                    invalidInput = false;
                    //success
                    Game = new Game(UpperNumber);
                    Game.Play();
                }
                else
                {
                    System.Console.WriteLine("Please provide a valid number");
                }
            }
        }
    }
}
