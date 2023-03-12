using System;
class Simple : Goal
{
    private string _type = "Simple";
    private bool _complete;
    private int _points;

    public Simple()
    {

    }
    public Simple(string name, string description, int points, bool complete) : base (name, description)
    {
        _complete = complete;
        _points = points;
    }

    public override void DisplayPoints() // Prompts the user for the point total.
    {
        Console.Write("How many points is this goal worth? ");
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
        return $"{_type}|{GetName()}|{GetDescription()}|{GetGoalPoints()}|{_complete}";
    }

    public override string ToString()
    {
        return $"[{((_complete == false) ? " " : "x")}] {GetName()} ({GetDescription()})";
    }

    public override void Record()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        _complete = true;
    }
}