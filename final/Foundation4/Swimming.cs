using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(double length, int laps) : base(length)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        laps = 0;
    }

    public override double Distance()
    {
        double distance = Math.Round(_laps * 50 / 1000 * 0.62, 1);
        return distance;
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
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} Minutes) - Distance: {Distance()} miles, SPeed: {Speed()} Mph, Pace: {Pace()} minutes per mile");
    }
}