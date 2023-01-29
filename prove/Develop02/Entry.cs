using System;

public class Entry
{
    public string _dateTime = ""; // Abstraction for the date and time.
    public string _prompt = ""; // Abstraction for the prompt.
    public string _userInput = ""; // Abstraction for the input.
    public void Display() // Display for all placed together. 
    {
        Console.WriteLine($"\n{_dateTime} - Prompt: {_prompt}");
        Console.WriteLine($"{_userInput}");
    }
}