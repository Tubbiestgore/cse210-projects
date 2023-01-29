using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random(); // This is for the random prompt which will be featured later in the program.

        var list = new List<string> // The list of random prompts.
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was I grateful for today?",
            "What did I do today that will benefit me tomorrow?",
            "What do I appreciate most about those around me, friends, family, etc?",
            "How much peace did I feel today, and why?",
            "What did I do today for others?"
        };

        string play = "yes"; // Variable to keep the while loop going.

        Journal journal = new Journal(); //Creates a new Journal everytime the program is played.

        Console.WriteLine("Welcome to the Journal Program!");

        while (play == "yes")
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            int option = int.Parse(input);

            if (option == 1)
            {
                DateTime time = DateTime.Now;
                string date = time.ToString(); // Gets the Date and Time everytime the user selects this option.

                int index = random.Next(list.Count);
                string prompt = list[index]; // Pulls a random prompt from the list and displays.
                Console.WriteLine(list[index]);

                Entry userInput = new Entry();
                userInput._dateTime = date; // Creates a new user entry using the abstracted entry format. Takes the date and the prompt.
                userInput._prompt = prompt;

                Console.Write("> ");

                string entry = Console.ReadLine();
                userInput._userInput = entry; // Reads user entry and then adds that to a list in the journal abstraction and the entry abstraction. 
                journal._journal.Add(userInput);
            }

            else if (option == 2)
            {
                journal.Display(); // Displays all entries created during this runthrough of the program.
            }

            else if (option == 3)
            {
                journal.Load(); // Loads the Journal from a perviously created file. 
            }

            else if (option == 4)
            {
                journal.Save(); // Saves the journal entries already written into a new file which the user selects.
            }

            else if (option == 5)
            {
                journal.Delete(); // Deletes a file which the user selects (again this is my exceeding requirements).
            }

            else if (option == 6)
            {
                Console.WriteLine("Thank you for writing in your Journal today."); // Ends the program.
                play = "no";
            }

            else
            {
                Console.WriteLine("\nI am sorry, this system only allows for inputs 1-6."); // Will reiterate to the user that only 1-6 as an option may be selected. 
            }  
        }
    }
}