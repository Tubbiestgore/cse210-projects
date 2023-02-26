using System;

class Program
{
    static void Main(string[] args)
    {
        int totalBreathCount = 0;
        int totalReflectCount = 0;  // Counts total of each activity done (this is the extra step I took).
        int totalListCount = 0;

        string play = "yes";

        Console.WriteLine("Welcome to the Mindfulness program.");

        while (play == "yes")
        {
            Console.WriteLine("\nPlease select from one of the following activities: ");    // Displays selection options.
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("What would you like to do?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Clear();
                Breathing breath = new Breathing(); // Selects the breathing activity to be played.
                breath.RunActivity();
                totalBreathCount++;
            }

            else if (userInput == 2)
            {
                Console.Clear();
                Reflection reflection = new Reflection();   // Selects the reflection activity to be played
                reflection.RunActivity();
                totalReflectCount++;
            }

            else if (userInput == 3)
            {
                Console.Clear();
                Listing listing = new Listing();    // Selects the lisiting activity to be played
                listing.RunActivity();
                totalListCount++;
            }

            else if (userInput == 4)
            {
                play = "quit";
                Console.WriteLine("\nYou completed the following activities: "); // Quits and totals the amount of times an activity was done. 
                Console.WriteLine($"Breathing Activity: {totalBreathCount} times");
                Console.WriteLine($"Reflecting Activity: {totalReflectCount} times");
                Console.WriteLine($"Listing Activity: {totalListCount} times");
                Console.WriteLine("\nThank you for taking the time to be mindful.");
            }

            else
            {
                Console.WriteLine("I am sorry. This system only accepts inputs 1 - 4.");
            }
        }
    }
}