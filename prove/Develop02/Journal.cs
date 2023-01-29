using System;
using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>(); // List of the new journal entries.
    public void Display() // A simple for loop which will display all the entries in the list in a nice format.
    {
        foreach (Entry journal in _journal)
        {
            Console.Write("\n");
            journal.Display();
        }
    }
    public void Save() // Method to save the entries from the current iteration of the program to a file which the user designates. 
    {
        Console.WriteLine("What will be your file name? ");
        string name = Console.ReadLine();
        string fileName = name;
        Console.WriteLine($"\nYour new filename is {fileName}");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry journal in _journal)
            {
                outputFile.WriteLine($"{journal._dateTime};{journal._prompt};{journal._userInput}");
            }
        }
    }
    public void Load() // Method to load from a file which the user has previously created. 
    {
        Console.WriteLine("What is your file name? ");
        string name = Console.ReadLine();
        string fileName = name;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            Entry entry = new Entry();

             entry._dateTime = parts[0];
             entry._prompt = parts[1];
             entry._userInput = parts[2];

             entry.Display();
        }
    }
    public void Delete() // Method to delete a previous file if the user so wishes (This is the above and beyond which I was able to accomplish).
    {
        Console.WriteLine("What is the file you wish to delete?");
        string name = Console.ReadLine();
        string fileName = name;

        System.IO.File.Delete(fileName);
        Console.WriteLine("\nThe File has been deleted.");
    }
}