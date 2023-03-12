using System;
public class GoalMaster
{
    private List<Goal> _totalGoals = new List<Goal>();
    private int _pointTotal;
    private string _fileName;

    public void addGoal(Goal _goal) // Adds goals to the total number of created goals.
    {
        _totalGoals.Add(_goal);
    }

    public int getPointTotal() // Gets the total amount of points.
    {
        return _pointTotal;
    }

    public void DisplayPoints(int totalPoints) // Displays that point total.
    {
        
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void DisplayGoals() //Displays Goals, including an option for if there are no goals.
    {
        if (_totalGoals.Count() == 0)
        {
            Console.WriteLine("\nNo goals have been created or loaded.");
            return;
        }

        Console.WriteLine("\nYour goals:");
        foreach (Goal goal in _totalGoals)
        {
            Console.WriteLine($"{_totalGoals.IndexOf(goal) + 1}. {goal.ToString()}");
        }
        Console.WriteLine();
    }

    public void SaveGoals() // Saves the goals and total points using CSV.
    {
        if (_totalGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.\n");
            return;
        }
    
        Console.WriteLine("Please enter the filename you want to save: ");
        _fileName = Console.ReadLine();
        string file = _fileName;
        
        List<string> savedGoal = new List<string>();
        savedGoal.Add(_pointTotal.ToString());
        foreach (Goal goal in _totalGoals)
        {
            savedGoal.Add(goal.ToCSVRecord());
        }
        CSV.SaveToCSV(savedGoal, file);
        Console.WriteLine($"Your new filename is {file}");
    }

    public void LoadGoals() // Loads the user selected file.
    {
        List<string> file;
        Console.WriteLine("\nPlease enter the filename you want to load: ");
        _fileName = Console.ReadLine();
        file = CSV.LoadFromCSV(_fileName);
        _pointTotal = int.Parse(file[0]) + _pointTotal;

        Goal goal = null; // Adds loaded goal to the currently instatiated list (including goals already created this instantiation of the program.)
        foreach (string line in file)
        {
            string[] parts = line.Split('|');
            string type = parts[0];
            if (type == "Simple")
            {
                goal = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            }

            else if (type == "Eternal")
            {
                goal = new Eternal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), bool.Parse(parts[5]));
            }

            else if (type == "CheckList")
            {
                goal = new CheckList(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
            }

            if (goal != null && _totalGoals.Contains(goal) == false)
            {
                _totalGoals.Add(goal);
            }
        }
        Console.WriteLine("Successfully Loaded.");
    }

    public void DisplayRecordEvent() // Allows the user to record their goal completion.
    {
        Console.WriteLine("The Goals are:");

        foreach (Goal goal in _totalGoals)
        {
            Console.WriteLine(string.Format($"{_totalGoals.IndexOf(goal) + 1}. [{((goal.GetStatus() == false) ? " " : "x")}] {goal.GetName()}"));
        }

        Console.Write("Which goal did you complete? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        bool status = _totalGoals[recordEvent].GetStatus();

        if (status == false)
        {
            _totalGoals[recordEvent].Record();
            _pointTotal += _totalGoals[recordEvent].GetGoalPoints();
            Console.WriteLine(string.Format($"\nYou now have {_pointTotal.ToString()} points! Congratulations!"));
        }

        else
        {
            Console.WriteLine("\nThis goal was already completed.");
        }
    }
}