using System;

public class Entry
{
    public string _dateTime = "";
    public string _prompt = "";
    public string _userInput = "";
    
    public void Display()
    {
        Console.WriteLine($"\n{_dateTime} - Prompt: {_prompt}");
        Console.WriteLine($"{_userInput}");
    }
}