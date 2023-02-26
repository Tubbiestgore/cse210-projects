using System;
using System.Diagnostics;

public class Activity // This is the parent class for all other activity classes. 
{
    private string _start;
    private string _end;
    private string _activityDescription;
    private string _activityName;
    static int _spinner = 0;
    static int _userSession = 0;

    public Activity()
    {
        _spinner = _userSession = 0;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    public int GetUserLength()
    {
        return _userSession;
    }
    public void DisplayLength()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? "); // Prompts user for a length period.
        _userSession = int.Parse(Console.ReadLine());
    }
    public void DisplayStart()
    {
        _start = $"You have chosen the {_activityName}."; // Formats and displays the start message for each activity.
        Console.WriteLine(_start);
        Console.WriteLine($"\n{_activityDescription}");
    }
    public void DisplayReadyUp()
    {
        Console.WriteLine("\nGet ready..."); // Formats and displays the Get ready period for each activity.
        DisplaySpinner(5);
    }
    public void DisplaySpinner(int numSeconds)  
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSeconds)   // Performs the function of a timer/spinner. This was a little tricky to get right.
        {
            _spinner++;
            switch (_spinner % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.WriteLine(" ");
    }
    public void DisplayEnd()
    {
        _end = $"Congradulations! You have completed {_userSession} seconds of the {_activityName}."; // Displays the message at the end of the activity

        Console.WriteLine("\nGood Job!");
        DisplaySpinner(3);
        Console.WriteLine($"{_end}");
        DisplaySpinner(5);
        Console.Clear();
    }
    public void RunBegin()  // Formats the beginning of an activity for display to the user. 
    {
        DisplayStart();
        DisplayLength();
        DisplayReadyUp();
        Console.Clear();
    }
    public void RunEnd()    // Formats the end of an activity for display to the user. 
    {
        DisplayEnd();
    }
    public void DisplayCountdown(int numSeconds)    // Displays a countdown for the reflection activity. 
    {
        for (int i = numSeconds; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }    
}