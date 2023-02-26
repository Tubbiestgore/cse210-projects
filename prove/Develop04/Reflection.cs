using System;
using System.Diagnostics;

public class Reflection : Activity
{
    private List<string> _prompt;
    private List<string> _question;

    public Reflection() : base()    // Sets the Name and Description for the activity
    {
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. A suggestion would be to take at least a minute or more on this activity.");

        _prompt = new List<string> // List of Prompts
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };

        _question = new List<string> // List of Questions
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void RunActivity() // Formats and Runs the activity.
    {
        RunBegin();
        DisplayPrompt();
        DisplayQuestion();
        RunEnd();
    }
    public void DisplayPrompt() // Formats and Displays the prompt which is pulled randomly from the list.
    {
        Console.WriteLine("Consider the following: ");
        int randomIndex = new Random().Next(0, _prompt.Count());
        Console.WriteLine(_prompt[randomIndex]);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }    
    public void DisplayQuestion() // Formats and Displays the questions in order and gives a countdown before beginning to display the questions. 
    {
        List<int> index = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            int randomInt = new Random().Next(0, _question.Count());
            while (index.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _question.Count());
            }
            index.Add(randomInt);
        }
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\n");
        DisplayCountdown(7);

        foreach (int i in index)
        {
            Console.Write(_question[i]);
            DisplaySpinner((GetUserLength() / index.Count()));
            Console.WriteLine();
        }
    }
}