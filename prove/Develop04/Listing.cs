using System;
using System.Diagnostics;

public class Listing : Activity
{
    private List<string> _prompt;

    public Listing() : base()   // Sets the Name and Description for the activity
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. Take relaxation from this activity.");

        _prompt = new List<string>  // List of Prompts. 
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };
    }
    public void RunActivity() // Formats and runs the activity.
    {
        RunBegin();
        DisplayPrompt();
        ListingCounter();
        RunEnd();
    }
    private void DisplayPrompt() // Pulls a prompt randomly, and then displays to the user. 
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        int randomIndex = new Random().Next(0, _prompt.Count());
        Console.WriteLine(_prompt[randomIndex]);
        Console.WriteLine("\n");
    }
    private void ListingCounter() // Counts total items as well as time, for how the log the activity is supposed to take. 
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetUserLength());
        DateTime currentTime = DateTime.Now;
        int totalItems = 0;

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            totalItems += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {totalItems} items.");
        DisplaySpinner(5);
    }
}