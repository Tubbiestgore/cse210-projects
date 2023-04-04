using System;

public class Running : Activity
{
    private double _distance;

    public Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        distance = 0;
    }

    public override double Distance()
    {
        return Math.Round(_distance, 1);
    }

    public override double Speed()
    {
        double speed = Math.Round((Distance() / GetLength()) * 60, 1);
        return speed;
    }

    public override double Pace()
    {
        double pace = Math.Round(GetLength() / Distance(), 1);
        return pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} Minutes) - Distance: {Distance()} miles, Speed: {Speed()} Mph, Pace: {Pace()} minutes per mile");
    }
}