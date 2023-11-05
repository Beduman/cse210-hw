using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1, 100);
        int guess = -10;


        while (guess != Number)
        {
            Console.WriteLine("Guess a number between 1 and 100: ");
            string guessword = Console.ReadLine();
            guess = int.Parse(guessword);

            if (Number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (Number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        }
    }
}