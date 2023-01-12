using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello. This program takes an organized list, which you the user creates.");
        Console.WriteLine("It will then return several functions of the list to you. Type 0 to complete the list.");
        
        List<int> numbers = new List<int>();
        int play = 1;

        while (play != 0)
        {
            
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int userInput = int.Parse(input);
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

            else
            {
                play = 0;
            }
        }

        int sum = 0;
        foreach (int entity in numbers)
        {
            sum += entity;
        }

        float avg = ((float)sum) / numbers.Count;

        int max = numbers[0];
        foreach(int entity in numbers)
        {
            if (entity > max)
            {
                max = entity;
            }
        }

        int minPosNum = int.MaxValue;
        foreach(int entity in numbers)
        {
            if (entity > 0)
            {
                if (entity < minPosNum)
                {
                    minPosNum = entity;
                }
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The max is: {max}");
        Console.WriteLine($"The minimum postive number is: {minPosNum}.");
        Console.WriteLine("Thank you for using this program.");

    }
}