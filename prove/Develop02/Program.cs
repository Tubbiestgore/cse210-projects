using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";


        while (play == "yes")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            int option = int.Parse(input);

            if (option == 1)
            {

            }

            else if (option == 2)
            {

            }

            else if (option == 3)
            {

            }

            else if (option == 4)
            {

            }

            else if (option == 5)
            {

            }

            else if (option == 6)
            {
                Console.WriteLine("Thank you for writing in your journal today.");
                play = "no";
            }

            else
            {
                Console.WriteLine("\nI am sorry, this system only allows for inputs 1-6.");
            }
            
        }
    }
}