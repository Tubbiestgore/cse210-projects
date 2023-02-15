using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test1 = new Assignment("Samuel Bennett", "Multiplicaiton");
        Console.WriteLine(test1.GetSummary());

        MathAssignment test2 = new MathAssignment("Roberto Rodirguez", "Fractions", "7.3","8-19");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());

        WritingAssignment test3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}