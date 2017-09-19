using System;

namespace numberguess
{
    class Game
    {
        int UpperNumber;
        int wins = 0;
        int losses = 0;
        int guesses = 3;
        bool playing = true;
        int validGuess;
        bool invalidGuess = true;

        public void Play()
        {
            Random randGen = new Random();
            int mysteryNumber = randGen.Next(1, UpperNumber + 1);
            System.Console.WriteLine($"Ok I have my number Take a guess");
            while (playing)
            {
                if (ValidateGuess())
                {
                    if (validGuess == mysteryNumber)
                    {

                        System.Console.WriteLine("THATS IT!! YOU WIN!! Do you Want to play again? (Y/N)");
                        string Choice = Console.ReadLine();
                        if (Choice.ToUpper() == "N")
                        {
                            playing = false;
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("NICE TRY, BUT NOPE!");
                    }
                    invalidGuess = true;
                }
                else
                {
                    System.Console.WriteLine("You lose, ran out of guesses");
                    playing = false;
                }
            }
        }

        public bool ValidateGuess()
        {
            if (guesses > 0)
            {
                while (invalidGuess)
                {
                    System.Console.WriteLine($"You have {guesses} remaining");
                    string guess = Console.ReadLine();
                    guesses--;
                    if (Int32.TryParse(guess, out validGuess))
                    {
                        invalidGuess = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Please Provide a valid number that will cost you 1 guess");
                    }
                }
                return true;
            }
            return false;
        }

        public Game(int num)
        {
            UpperNumber = num;
        }

    }
}