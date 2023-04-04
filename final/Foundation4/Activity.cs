using System;

public abstract class Activity
{
    private string _date { get; set;}
    private double _length;

    public Activity(double length)
    {
        _length = length;
    }

    public string GetDate()
    {
        DateTime date = DateTime.Now;
        string _date = date.ToString("dd/MM/yyyy");
        return _date;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        length = 0;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract void GetSummary();
}