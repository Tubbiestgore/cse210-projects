using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(double length, double speed) : base(length)
    {
        _speed = speed;
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(double speed)
    {
        speed = 0;
    }

    public override double Speed()
    {
        return Math.Round(_speed, 1);
    }

    public override double Distance()
    {
        double distance = Math.Round(GetLength() * Speed() / 60, 1);
        return distance;
    }

    public override double Pace()
    {
        double pace = Math.Round(60 / Speed(), 1);
        return pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} Minutes) - Distance: {Distance()} miles, Speed: {Speed()} Mph, Pace: {Pace()} minutes per mile");
    }

}