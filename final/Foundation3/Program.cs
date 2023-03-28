using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, and welcome to the event planning program!");
        Console.WriteLine("This is an example program in the case of events being planned for a company.");
        Console.WriteLine("Some examples are as follows:");

        Address address1 = new Address("490 Sandy Boulevard", "San Fransisco", "California", 76543, "USA");
        string eventAddress1 = address1.GetAddress();
        Lecture lecture = new Lecture("The Future of AI", "A lecture on the future of Artificial Intelligence in the modern world.", "April 20th, 2023", "9 AM - 12 PM", eventAddress1, "Lecture", "Johnathan Harvard", 5000);
        Console.WriteLine();
        Console.WriteLine("The Short Description: ");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine("The Standard Details: ");
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("The Full Details: ");
        lecture.DisplayFullDetails();
        Console.WriteLine();

        Address address2 = new Address("10093 S Custard Way", "Detroit", "Michigan", 89999, "USA");
        string eventAddress2 = address2.GetAddress();
        Reception reception = new Reception("The Wedding of Happy Koko, and Liz Taylor", "Happy and Liz's wedding reception.", "August 12th, 2023 - August 13th, 2023", "5 PM - 1 AM", eventAddress2, "Reception", "Happiest.ok@insertcompanyhere.com");
        Console.WriteLine();
        Console.WriteLine("The Short Description: ");
        reception.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine("The Standard Details: ");
        reception.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("The Full Details: ");
        reception.DisplayFullDetails();
        Console.WriteLine();

        Address address3 = new Address ("150 SunnySide Drive", "Vancouver", "Washington", 98765, "USA");
        string eventAddress3 = address3.GetAddress();
        Outdoor outdoor = new Outdoor("PickleBall! A Family Favorite!", "Big old PickleBall tournament, come one come all!", "July 14th, 2023", "3 PM - 7 PM", eventAddress3, "Outdoor", "Partially Cloudy with a slight chance of Rain");
        Console.WriteLine();
        Console.WriteLine("The Short Description: ");
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        Console.WriteLine("The Standard Details: ");
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("The Full Details: ");
        outdoor.DisplayFullDetails();
        Console.WriteLine();


    }
}