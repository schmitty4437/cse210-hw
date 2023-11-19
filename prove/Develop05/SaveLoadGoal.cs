using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Class: SaveLoadGoal
// Attributes:
// * None

// Behaviors:
// * SaveToFile(goals: List<Goal>, fileName: string, manageGoals: ManageGoals) : void
// * LoadFromFile(fileName: string) : Tuple<List<Goal>, int>
// * CreateGoalFromString(data: string) : Goal
// * CreateSimpleGoal(values: string[]) : Simple
// * CreateEternalGoal(values: string[]) : Eternal
// * CreateChecklistGoal(values: string[]) : Checklist

class SaveLoadGoal
{
    //Save goals to a file method
    public static void SaveToFile(List<Goal> goals, string fileName, ManageGoals manageGoals)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Save total score
            writer.WriteLine(manageGoals.TotalScore);

            // Save each goal
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    //Load goals to a file method
    public static Tuple<List<Goal>, int> LoadFromFile(string fileName)
    {
        List<Goal> loadedGoals = new List<Goal>();
        int loadedTotalScore = 0;

        //Taking all lines from a file and putting them in an array
        string[] lines = File.ReadAllLines(fileName);

        //Verify file has lines
        if (lines.Length > 0)
        {
            // Load total score
            loadedTotalScore = int.Parse(lines[0]);

            // Load each goal
            for (int i = 1; i < lines.Length; i++)
            {
                //Creats a goal objects from lines
                Goal goal = CreateGoalFromString(lines[i]);
                if (goal != null)
                {
                    loadedGoals.Add(goal);

                    if (goal is Checklist checklistGoal)
                    {
                        string[] values = lines[i].Split(':');

                        if (values.Length >= 2)
                        {
                            string[] checklistValues = values[1].Split(',');

                            checklistGoal.GoalCount = int.Parse(checklistValues[3]);
                            checklistGoal.OverallGoals = int.Parse(checklistValues[4]);
                            checklistGoal.BonusPoints = int.Parse(checklistValues[2]);

                            // Debug statements
                            //Console.WriteLine($"Debug: GoalCount={checklistGoal.GoalCount}, OverallGoals={checklistGoal.OverallGoals}, BonusPoints={checklistGoal.BonusPoints}");
                        }
                    }
                }
            }
        }
        return Tuple.Create(loadedGoals, loadedTotalScore);
    }

    //This method create the goal object from a string representation
    private static Goal CreateGoalFromString(string data)
    {
        string[] parts = data.Split(':');

        //Check if ther are two parts
        if (parts.Length >= 2)
        {
            string goalType = parts[0];
            string[] values = parts[1].Split(',');

            switch (goalType)
            {
                case "Simple":
                    return CreateSimpleGoal(values);
                case "Eternal":
                    return CreateEternalGoal(values);
                case "Checklist":
                    return CreateChecklistGoal(values);
                // Add more cases for other goal types if needed
                default:
                    return null;
            }
        }
        return null;
    }

    //Method for Simple goal object from array
    private static Simple CreateSimpleGoal(string[] values)
    {
        if (values.Length == 4)
        {
            Simple simpleGoal = new Simple
            {
                _goalName = values[0],
                _goalDescription = values[1],
                _points = int.Parse(values[2]),
                _goalAchieved = bool.Parse(values[3])
            };
            return simpleGoal;
        }
        return null;
    }

    //Method for Eternal goal object from array
    private static Eternal CreateEternalGoal(string[] values)
    {
        if (values.Length == 4)
        {
            Eternal eternalGoal = new Eternal
            {
                _goalName = values[0],
                _goalDescription = values[1],
                _points = int.Parse(values[2]),
                _goalAchieved = bool.Parse(values[3])
            };
            return eternalGoal;
        }
        return null;
    }

    //Method for Checklist goal object from array
    private static Checklist CreateChecklistGoal(string[] values)
    {
        if (values.Length == 6)
        {
            Checklist checklistGoal = new Checklist
            {
                _goalName = values[0],
                _goalDescription = values[1],
                BonusPoints = int.Parse(values[2]),
                GoalCount = int.Parse(values[3]),
                OverallGoals = int.Parse(values[4]),
                _goalAchieved = bool.Parse(values[5])
            };

            //Calculate Points and Bonuspoints if all goals are completed
            if (checklistGoal._goalAchieved)
            {
                // Calculate Points with BonusPoints
                checklistGoal._points = (checklistGoal.GoalCount * checklistGoal.BonusPoints);
            }

            return checklistGoal;
        }
        return null;
    }
}