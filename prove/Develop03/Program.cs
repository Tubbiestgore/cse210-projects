using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

      string filePath = "List.txt";
      string[]lines = File.ReadAllLines(filePath);
      string selectedLine = lines[new Random().Next(lines.Length)]; //This pulls from my list of Old Testament Scripture Mastery and then randomly selects a line. This is where I wdid my extra portion.
      string[] parts = selectedLine.Split(";");
  
      string part1 = parts[0];
      string part2 = parts[1];      //This arrays each section of that line and gives them an associated variable.
      string part3 = parts[2];
      string part4 = parts[3];
      
      Reference newReference = new Reference($"{part1}",$"{part2}",$"{part3}");
      Scripture scripture = new Scripture(newReference, $"{part4}");             // Creates a new Reference from the randomly selected scripture as well as a new Scripture as well as word class.
      Word memorizer = new Word(scripture);
      
      string play = " ";

      while (play != "quit" && memorizer.remainingWords() == true)
      {
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", newReference.toString(), memorizer.toString())); // Formats and displays the scripture after it has gone through the Word class. 
        Console.WriteLine();
        play = Console.ReadLine();
        memorizer.removeWords();
      }

      Console.WriteLine("\nThank you for reading your scriptures today."); 
      
    }
}