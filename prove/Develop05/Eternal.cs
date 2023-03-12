using System;


public class Eternal : Goal
{
    private string _type = "Eternal";
    private int _points;
    private int _completed = 0;
    private bool _complete = false;

    public Eternal()
    {

    }
    public Eternal(string name, string description, int points, int completed, bool complete) : base (name, description)
    {
        _points = points;
        _completed = completed;
        _complete = complete;
    }
        public int GetRunningTotal()
    {
        return _completed;
    }

    public override void DisplayPoints() // Prompts the user for the point total.
    {
        Console.Write("How many points is this goal worth each time you complete it? ");
        _points = int.Parse(Console.ReadLine());
        return;
    }
    public override int GetGoalPoints()
    {
        return _points;
    }
    
    public override bool GetStatus()
    {
        return _complete;
    }

    public override string ToCSVRecord()
    {
        return $"{_type}|{GetName()}|{GetDescription()}|{GetGoalPoints()}|{GetRunningTotal()}|{_complete}";
    }

    public override string ToString()
    {
        return $"[ ] {GetName()} ({GetDescription()}) - Completed {GetRunningTotal()} times";
    }

    public override void Record()
    {
        _completed += 1;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }
}