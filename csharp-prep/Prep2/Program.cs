using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string read = Console.ReadLine();
        int grade = int.Parse(read);

        string letter = "";
        string sign = "";
        int lastDigit = grade % (10);
        
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
            sign = "";
        }

        if (lastDigit >= 7 && grade <= 90 && grade >= 60)
        {
            sign = "+";
        }

        else if (lastDigit <= 3 && grade >= 60)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        Console.WriteLine($"\nYour final grade is: {letter}{sign}.");

        if (grade >= 70)
        {
            Console.Write("Congratulations! You passed the course!");
        }

        else
        {
            Console.Write("I am sorry, but you did not pass this course. Give it your best go next time around!");
        }
    }
}