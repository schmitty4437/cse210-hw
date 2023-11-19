using System;

class Program
{
    private ManageGoals manageGoal;

    static void Main()
    {
        Console.Clear();
        //Instance of program class is created
        Program program = new Program();
        program.Start();
    }

    public Program()
    {
        //Instantiate ManageGaols object and assign manageGoal to it
        manageGoal = new ManageGoals();
    }

    public void Start()
    {
        while (true)
        {            
            // User score
            Console.WriteLine($"You have {manageGoal.TotalScore} points.\n");

            // Main Menu Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);

            switch (choice)
            {
                case 1:
                    manageGoal.CreateNewGoal();
                    break;
                case 2:
                    manageGoal.DisplayGoals();
                    break;
                case 3:
                    manageGoal.SaveGoals();
                    break;
                case 4:
                    manageGoal.LoadGoals();
                    break;
                case 5:
                    manageGoal.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Thank you for using Eternal Quest Program");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}