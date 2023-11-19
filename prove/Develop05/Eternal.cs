using System;

// Class: Eternal : Goal
// Attributes:
// * None

// Behaviors:
// * CreateGoal() : void
// * RecordEvent(manageGoals: ManageGoals, displayCongratulations: bool) : void
// * IsComplete() : bool
// * GetStringRepresentation() : string

class Eternal : Goal
{
    public Eternal()
    {
        // Default type for Eternal Goal
        GoalType = "Eternal";
    }

    public string GoalType { get; set; }

    //Ovveride CreateGoal() to create the a Eternal goal
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

    //Override RecordEvent so that user can record the eternal goal event
    public override void RecordEvent(ManageGoals manageGoals, bool displayCongratulations = true)
    {
        _goalAchieved = false;

        if (displayCongratulations)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    public override bool IsComplete()
    {
        return false; // Eternal Goal is never complete
    }

    //Get string representation for eternal goal
    public override string GetStringRepresentation()
    {
        return GetStringRepresentationBase("Eternal");
    }
}