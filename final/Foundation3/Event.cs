using System;

public class Event
{
   private string _title;
   private string _description;
   private string _date;
   private string _time;
   private string _address;
   private string _type;

   public Event(string title, string description, string date, string time, string address, string type)
   {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
   } 

   public string GetTitle()
   {
        return _title;
   }

   public void SetTitle(string title)
   {
        title = "";
   }

   public string GetDescritpion()
   {
        return _description;
   }

   public void SetDescription(string description)
   {
        description = "";
   }

   public string GetDate()
   {
        return _date;
   }

   public void SetDate(string date)
   {
        date = "";
   }


   public string GetTime()
   {
        return _time;
   }

   public void SetTime(string time)
   {
        time = "";
   }
   public string GetAddress()
   {
        return _address;
   }

   public void SetAddress(string address)
   {
        address = "";
   }
   public string GetType()
   {
        return _type;
   }

   public void SetType(string type)
   {
        type = "";
   }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Event Type; {_type}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}

