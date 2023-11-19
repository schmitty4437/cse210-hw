using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Class: ManageGoals
// Attributes:
// * goals : List<Goal>
// * totalScore : int

// Behaviors:
// * ManageGoals() : void
// * CreateNewGoal() : void
// * UpdateTotalScore(points: int) : void
// * DisplayGoals() : void
// * DisplayTotalScore() : void
// * SaveGoals() : void
// * LoadGoals() : void
// * RecordEvent() : void
// * GetManageGoalsStringRepresentation() : string

class ManageGoals
{
    private List<Goal> goals;
    private int totalScore;

    //Constructor initialize list goals and total score
    public ManageGoals()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public int TotalScore
    {
        get { return totalScore; }
    }

    //Create new goal method
    public void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);

        Goal newGoal = null;

        switch (choice)
        {
            case 1:
                newGoal = new Simple();
                break;
            case 2:
                newGoal = new Eternal();
                break;
            case 3:
                newGoal = new Checklist();
                break;
            default:
                Console.WriteLine("Invalid choice. Goal creation canceled.");
                return;
        }
        newGoal.CreateGoal();
        goals.Add(newGoal);
    }

    //Update total score
    public void UpdateTotalScore(int points)
    {
        totalScore += points;
    }

    //Display all goals and their status
    public void DisplayGoals()
    {
        Console.WriteLine("List of Goals:");

        foreach (Goal goal in goals)
        {
            Console.Write(goal);
            if (goal is Checklist checklistGoal)
            {
                Console.Write($" - Currently completed: {checklistGoal.GoalCount}/{checklistGoal.OverallGoals}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    //Display total score
    public void DisplayTotalScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    //Save goals to file
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        SaveLoadGoal.SaveToFile(goals, fileName, this);
        Console.WriteLine();
    }

    //Load goals from file
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        //Uses SaveLoadGoal class to load goals and total score from a file
        Tuple<List<Goal>, int> loadedData = SaveLoadGoal.LoadFromFile(fileName);

        foreach (Goal goal in loadedData.Item1)
        {
            goal.RecordEvent(this, displayCongratulations: false);
        }
        goals = loadedData.Item1;
        totalScore = loadedData.Item2;
        Console.WriteLine();
    }

    //Record event for a goal
    public void RecordEvent()
    {
        if (goals.Count == 0)
        {
            //Changed color to red when there are no events to record.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No goals available. Please add a goal to record an event.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]._goalName}");
        }

        int goalIndex;

        //Checks for valid goal index
        do
        {
            Console.Write("Which goal did you accomplish? ");
        } while (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > goals.Count);

        Goal goal = goals[goalIndex - 1];
        
        // Check whether to display the congratulations message
        goal.RecordEvent(this, displayCongratulations: true);

        totalScore += goal._points;

        Console.WriteLine($"You now have {totalScore} points.");
        Console.WriteLine();
    }

    //Gets string representation of ManageGoals
    public string GetManageGoalsStringRepresentation()
    {
        return $"{totalScore}";
    }
}