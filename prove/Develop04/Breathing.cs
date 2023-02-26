using System;
using System.Diagnostics;

public class Breathing : Activity
{
    public Breathing() : base() // Sets the Name and Description for the activity
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your heartbeat and breathing.");
    }
    public void DisplayInAndOut() // Formats and Displays the amount fo time between breaths. Approx. 5 seconds.
    {
        int time = GetUserLength() * 1000;
        int interval = 10000;
        int intervals = time / interval;

        for(int i = 0; i < intervals; i++)
        {
            Console.WriteLine("Breathe in... ");
            Countdown();
            Console.WriteLine("Breathe out... "); 
            Countdown();
        }
    }
    public void RunActivity() // Formats and runs the activity.
    {
        RunBegin();
        DisplayInAndOut();
        RunEnd();
    }
    private void Countdown() // Countsdown between breaths. 
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}