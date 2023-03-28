using System;

public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, string address, string type, string rsvp) : base(title, description, date, time, address, type)
    {
        _rsvp = rsvp;
    }

    public string GetRSVP()
    {
        return _rsvp;
    }

    public void SetRSVP(string rsvp)
    {
        rsvp = "";
    }

    public void GetFullDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"RSVP Email Address: {_rsvp}");
    }
}