using System;

// Class: Goal (abstract)
// Attributes:
// * _goalName : string
// * _goalDescription : string
// * _points : int
// * _goalAchieved : bool

// Behaviors:
// * CreateGoal() : void (abstract)
// * RecordEvent(manageGoals: ManageGoals, displayCongratulations: bool) : void (abstract)
// * IsComplete() : bool (abstract)
// * GetStringRepresentation() : string (abstract)

abstract class Goal
{
    //Using this attribute to display a check mark instead of an x for completed goals
    private char c;

    public string _goalName { get; set; }
    public string _goalDescription { get; set; }
    public int _points { get; set; }
    public bool _goalAchieved { get; set; }

    //Abstract methods to be used by subclasses
    public abstract void CreateGoal();
    public abstract void RecordEvent(ManageGoals manageGoals, bool displayCongratulations = true);
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();    

    //Override method to display goal information
    public override string ToString()
    {
        //Completed goals check mark
        c = '√';
        //Ternary conditional operator to see if the goal was completed or not
        string status = _goalAchieved ? $"\u001b[32m[{c}]\u001b[0m" : "[ ]";
        return $"{status} {_goalName} ({_goalDescription})";
    }

    //Used protected method to get string representation of a goal
    protected string GetStringRepresentationBase(string goalType)
    {
        return $"{goalType}:{_goalName},{_goalDescription},{_points},{_goalAchieved}";
    }
}