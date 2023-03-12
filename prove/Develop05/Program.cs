using System;
class Program
{
    static void Main(string[] args)
    {
        GoalMaster goals = new GoalMaster();    //Instatiates the GoalMaster class.
        string play = "yes";
        int userInput1;
        int userInput2;

        Console.WriteLine("Welcome to the Eternal Quest Program!\n");

        while (play == "yes")
        {
            goals.DisplayPoints(goals.getPointTotal());     //Displays point total followed by the main menu.
            Console.WriteLine("\nPlease select from the following menu: ");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            userInput1 = int.Parse(Console.ReadLine());

            if (userInput1 == 1)    //Instatiates the Goal for the GoalMaster to add, and displays secondary menu.
            {   
                Goal goal = null;       
                Console.WriteLine("\nPlease select the type of goal: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. CheckList Goal");
                userInput2 = int.Parse(Console.ReadLine());

                if (userInput2 == 1) // Activates the Simple Goal class.
                {
                    goal = new Simple();
                    goal.DisplayName();
                    goal.DisplayDescription();
                    goal.DisplayPoints();
                }

                else if (userInput2 == 2) // Activates the Eternal Goal class.
                {
                    goal = new Eternal(); 
                    goal.DisplayName();
                    goal.DisplayDescription();
                    goal.DisplayPoints();
                }

                else if (userInput2 == 3) // Activates the CheckList Goal class.
                {
                    goal = new CheckList();
                    goal.DisplayName();
                    goal.DisplayDescription();
                    goal.DisplayPoints();
                }

                else
                {
                    Console.WriteLine("\nI am sorry. At this point in the program the system selects only numbers 1-3. Please try again.");
                }

                if (goal != null) // Adds goal to the list.
                {
                    goals.addGoal(goal);
                }
            }

            else if (userInput1 == 2) // Displays all currently instatiated or loaded Goals.
            {
                goals.DisplayGoals();
            }

            else if (userInput1 == 3) // Saves Goals to CSV.
            {
                goals.SaveGoals();
            }

            else if (userInput1 == 4) // Loads Goals from CSV.
            {
                goals.LoadGoals();
            }

            else if (userInput1 == 5) // Displays a record event.
            {
                goals.DisplayRecordEvent();
            }

            else if (userInput1 == 6) // Quits the game, and asks the user if they want to save. 
            {
                Console.WriteLine("\nThank you for playing. Do you want to save before you quit? (y/n)");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    goals.SaveGoals();
                }

                else if (input == "n")
                {
                    play = "no";
                    Console.WriteLine("\nThank you! Hope to see you again soon!");

                }

                else
                {
                    Console.WriteLine("\nI am sorry. The program only accepts inputs y or n for this point in the program. Please try again.");
                }

            }

            else
            {
                Console.WriteLine("\nI am sorry. This program only accepts inputs 1-6. Please try again.");
            }


        }
            
    }
}