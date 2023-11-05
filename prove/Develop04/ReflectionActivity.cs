using System;
using System.Collections.Generic;

//Class: ReflectionActivity
// Attributes:
// * List<_promptQuestion> : string
// * List<_ponderQuestions> : string
// Also inherits attributes from base class Activity.cs

// Behaviors:
// * ReflectionActivity(string name, string description)
// * StartReflection(int time) : void
// * GenerateQuestion() : void
// * DisplayPrompt(List : prompt) : void
// * DisplayPonder(List : ponder) : void

class ReflectionActivity : Activity
{
    private List<string> _promptQuestion = new List<string>();
    private List<string> _ponderQuestion = new List<string>();

    //Constructor that inherits from base Activity.cs
    public ReflectionActivity() : base()
    {
        //Setting values for name and description of reflection activity
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    //Initiate reflection activity
    public void StartReflection(int time)
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        DisplayPrompt();
        //Random prompt
        string randomPrompt = GenerateRandomItem(_promptQuestion);
        Console.WriteLine();
        Console.Write(" --- ");
        Console.Write(randomPrompt);
        Console.Write(" --- ");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown();

        Console.Clear();
        //Gets the random questions
        GenerateQuestions();
    }

    //Generate and display the random ponder questions
    public void GenerateQuestions()
    {
        Console.WriteLine();

        //Gets the users session time
        int sessionTime = GetSessionTime();
        int remainingTime = sessionTime;

        while (remainingTime >= 15)
        {
            DisplayQuestions();
            string randomQuestion = GenerateRandomItem(_ponderQuestion);
            Console.Write("> ");
            Console.Write(randomQuestion);
            Console.Write(" "); 

            int animationTime = 15;
            Pause(animationTime, 250);

            remainingTime -= animationTime;

            Console.WriteLine();
        }

        if (remainingTime > 0)
        {
            
            DisplayQuestions();
            string randomQuestion = GenerateRandomItem(_ponderQuestion);
            Console.Write("> ");
            Console.Write(randomQuestion);
            Console.Write(" "); 

            Pause(remainingTime, 250);

            Console.WriteLine();
        }
    }

    //This method will read and create the prompt questions from the text file
    public void DisplayPrompt()
    {
        ReadItemsFromFile("prompt-questions.txt", _promptQuestion);
    }

    //This method will read and create the ponder questions from the text file
    public void DisplayQuestions()
    {
        ReadItemsFromFile("ponder-questions.txt", _ponderQuestion);
    }
}