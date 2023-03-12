using System;
public abstract class Goal // This is the parent class for all of the other activity classes in this program. 
{
    private string _name;
    private string _description;

    public Goal()
    {
        
    }
    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

       public virtual void DisplayPoints()
    {
        return;
    }
    public virtual int GetGoalPoints()
    {
        return 0;
    }

    public virtual bool GetStatus()
    {
        return false;
    }

    public virtual string ToCSVRecord()
    {
        return "";
    }
    public virtual void Record()
    {

    }

    public string DisplayName() // Prompts user for the name of the goal.
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }

    public string DisplayDescription() // prompts user for the description of the goal.
    {
        Console.Write("What is the description of your goal? ");
        _description = Console.ReadLine();
        return _description;
    }

 
}