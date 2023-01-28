using System;
using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public void Display()
    {
        foreach (Entry journal in _journal)
        {
            journal.Display();
        }
    }

    public void Save()
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

    public void Load()
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

    public void Delete()
    {
        Console.WriteLine("What is the file you wish to delete?");
        string name = Console.ReadLine();
        string fileName = name;

        System.IO.File.Delete(fileName);
    }
}