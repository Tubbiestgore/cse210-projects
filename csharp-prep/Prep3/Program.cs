using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        int totalGuesses = 0;

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);

        while (play == "yes")
        {
            Console.Write("What is your guess? ");
            string read2 = Console.ReadLine();
            int guess = int.Parse(read2);
            totalGuesses = totalGuesses + 1;

            if (guess == randomNumber)
            {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"The total guesses made was {totalGuesses}.");
            Console.WriteLine("Thank you.");
            play = "False";
            }

            else if (guess > randomNumber)
            {
            Console.WriteLine("Lower");
            }

            else
            {
            Console.WriteLine("Higher");
            }
        }
    }
}