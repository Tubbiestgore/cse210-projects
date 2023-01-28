using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
    
        var random = new Random();
        var list = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string play = "yes";
        Journal journal = new Journal();

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
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToString();

                int index = random.Next(list.Count);
                string journalPrompt = list[index];
                Console.WriteLine(list[index]);

                Entry userInput = new Entry();
                userInput._dateTime = dateText;
                userInput._prompt = journalPrompt;
                Console.Write("> ");
                string entry = Console.ReadLine();
                userInput._userInput = entry;
                journal._journal.Add(userInput);
            }

            else if (option == 2)
            {
                Console.Write("\n");
                journal.Display();
            }

            else if (option == 3)
            {
                journal.Load();
            }

            else if (option == 4)
            {
                journal.Save();
            }

            else if (option == 5)
            {
                journal.Delete();
            }

            else if (option == 6)
            {
                Console.WriteLine("Thank you for writing in your Journal today.");
                play = "no";
            }

            else
            {
                Console.WriteLine("\nI am sorry, this system only allows for inputs 1-6.");
            }
            
        }
    }
}