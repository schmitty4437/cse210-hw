using System;

// Class: Checklist : Goal
// Attributes:
// * BonusPoints : int
// * GoalCount : int
// * OverallGoals : int

// Behaviors:
// * CalculatePoints() : void
// * CreateGoal() : void
// * RecordEvent(manageGoals: ManageGoals, displayCongratulations: bool) : void
// * IsComplete() : bool
// * GetStringRepresentation() : string

class Checklist : Goal
{
    private int _goalCount;
    private int _overallGoals;
    private int _bonusPoints;
    private int _inputPoints;

    public Checklist()
    {
        // Default type for Checklist Goal
        GoalType = "Checklist";
    }

    public string GoalType { get; set; }

    //Getters-setters
    public int GoalCount
    {
        get { return _goalCount; }
        set { _goalCount = value; }
    }

    public int OverallGoals
    {
        get { return _overallGoals; }
        set { _overallGoals = value; }
    }

    public int BonusPoints
    {
        get { return _bonusPoints; }
        set { _bonusPoints = value; }
    }

    //Calculate points for checklist goals
    public void CalculatePoints()
    {
        if (_goalAchieved)
        {
            // Calculate Points with BonusPoints
            _points = _goalCount * _bonusPoints;
        }
    }

    //Ovveride CreateGoal() to create the a checklist goal
    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        //use while loop that reads input from console then parse the input as an integer
        while (!int.TryParse(Console.ReadLine(), out _inputPoints))
        {
            Console.Write("Invalid input. Please enter a number: ");
        }

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        while (!int.TryParse(Console.ReadLine(), out _overallGoals))
        {
            Console.Write("Invalid input. Please enter a number: ");
        }

        Console.Write("What is the bonus for accomplishing it that many times? ");
        while (!int.TryParse(Console.ReadLine(), out _bonusPoints))
        {
            Console.Write("Invalid input. Please enter a number: ");
        }
        Console.WriteLine();
    }

    //Override RecordEvent so that user can record the checlist goal event
    public override void RecordEvent(ManageGoals manageGoals, bool displayCongratulations = true)
    {
        GoalCount++;

        Console.WriteLine($"Goal: {_goalName} ({_goalDescription}) - Currently completed: {_goalCount}/{_overallGoals}");

        // Update total score for each completed task
        manageGoals.UpdateTotalScore(_inputPoints);

        if (GoalCount >= OverallGoals && !_goalAchieved)
        {
            _goalAchieved = true;

            // Bonus points for completing all specified times
            _points = _bonusPoints;

            if (displayCongratulations)
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
            }
        }
        else if (GoalCount < OverallGoals && displayCongratulations)
        {
            // Display points even if not all goals are completed
            Console.WriteLine($"Congratulations! You have earned {_inputPoints} points!");
        }
    }

    //Checks if checklist goal was completed
    public override bool IsComplete()
    {
        return _goalAchieved;
    }

    //Get string representation for checklist goal
    public override string GetStringRepresentation()
    {
        return $"Checklist:{_goalName},{_goalDescription},{_bonusPoints},{_goalCount},{_overallGoals},{_goalAchieved}";
    }
}