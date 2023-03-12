using System;
public class CheckList : Goal
{
    private string _type = "CheckList";
    private int _goalPoints;
    private int _times;
    private int _bonus;
    private int _completed = 0;
    private int _points = 0;
    private bool _complete;

    public CheckList()
    {

    }

    public CheckList(string name, string description, int goalPoints, int times, int completed, int bonus, bool complete) : base (name, description)
    {
        _goalPoints = goalPoints;
        _times = times;
        _completed = completed;
        _bonus = bonus;
        _complete = complete;
    }

    public override void DisplayPoints() // Prompts the user for the total attempts at the goal, its worth, and the bonus.
    {
        Console.Write("How many times do you want to complete this goal? ");
        _times = int.Parse(Console.ReadLine());
        Console.Write("How many points is this goal worth each time you do it? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.Write($"How much is the bonus for completing this goal? ");
        _bonus = int.Parse(Console.ReadLine());
        return;
    }
    public int GetPoints()
    {
        return _goalPoints;
    }
    public override int GetGoalPoints()
    {
        if (_completed == _times)
        {
            _points = _goalPoints + _bonus;
        }
        else if (_completed < _times)
        {
            _points = _goalPoints;
        }
        return _points;
    }
    public int GetTimes()
    {
        return _times;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public int GetRunningTimes()
    {
        return _completed;
    }
    
    public override bool GetStatus()
    {
        return _complete;
    }

    public override string ToCSVRecord()
    {
        return $"{_type}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTimes()}|{GetRunningTimes()}|{GetBonus()}|{_complete}";
    }

    public override string ToString()
    {
        return $"[{((_complete == false) ? " " : "x")}] {GetName()} ({GetDescription()}) - Currently Completed: {GetRunningTimes()}/{GetTimes()}";
    }

    public override void Record()
    {
        _completed += 1;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        if (_completed < _times)
        {
            _complete = false;
        }
        else if (_completed >= _times)
        {
            _complete = true;
            Console.WriteLine("You completed this goal and have earned the bonus points! Good job!");
        }
     
    }
}