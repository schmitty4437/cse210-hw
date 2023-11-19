using System;

// Class: Simple : Goal
// Attributes:
// * None

// Behaviors:
// * CreateGoal() : void
// * RecordEvent(manageGoals: ManageGoals, displayCongratulations: bool) : void
// * IsComplete() : bool
// * GetStringRepresentation() : string

class Simple : Goal
{
    public Simple()
    {
        // Default type for Simple Goal
        GoalType = "Simple";
    }

    public string GoalType { get; set; }

    //Ovveride CreateGoal() to create the a Simple goal
    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string input = Console.ReadLine();
        int points = int.Parse(input);
        _points = points;
        Console.WriteLine();
    }

    //Override RecordEvent so that user can record the simple goal event
    public override void RecordEvent(ManageGoals manageGoals, bool displayCongratulations = true)
    {
        _goalAchieved = true;
        
        if (displayCongratulations)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    //Checks if Simple goal was completed
    public override bool IsComplete()
    {
        return _goalAchieved;
    }

    //Get string representation for simple goal
    public override string GetStringRepresentation()
    {
        return GetStringRepresentationBase("Simple");
    }
}