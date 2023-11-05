using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

//Class: ListingActivity
// Attributes:
// * List<_promptQuestion> : string
// Also inherits attributes from base class Activity.cs

// Behaviors:
// * ListingActivity(string name, string description)
// * DeltaTime() : double
// * Count(int time) : int
// * StartListing(int time) : void
// * DisplayPrompt() : void

class ListingActivity : Activity
{
    //List for the prompt questions
    private List<string> _listingPrompt = new List<string>();

    //Constructor that inherits from the Activity base class
    //Also sets the name and description for the activity. I though it would look cleaner in classes instead of the program.cs
    public ListingActivity() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    //Uses stopwatch to figure out the elapsed time
    private double DeltaTime(Stopwatch sw)
    {
        return sw.Elapsed.TotalMilliseconds;
    }

    //Method counts the number of items the user types during their specified time
    private int Count(int time)
    {
        //Stopwatch will measure the time
        Stopwatch sw = new Stopwatch();
        sw.Start();

        //Initialize variables
        double acc = 0.0;
        int itemCount = 0;
        StringBuilder buffer = new StringBuilder();

        Console.Write("> ");

        //While loop is used to collect the items and measure time
        while (acc <= time * 1000)
        {
            //Elapsed time is calculated
            acc = DeltaTime(sw);

            //Checks if key is available
            if (!Console.KeyAvailable)
            {
                continue;
            }

            //Read the key from the user
            ConsoleKeyInfo key = Console.ReadKey(true);

            //When key is pressed it will increment the count and then move to a new line
            if (key.Key == ConsoleKey.Enter)
            {
                itemCount++;
                Console.WriteLine();
                Console.Write("> ");
                buffer.Append("\n");
            }
            else
            {
                Console.Write(key.KeyChar);
                buffer.Append(key.KeyChar);
            }
        }

        sw.Stop();

        // Get the input from the buffer
        string userInput = buffer.ToString();

        return itemCount;
    }

    //Method starts the listing activity
    public void StartListing(int time)
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();

        string randomPrompt = GenerateRandomItem(_listingPrompt);
        Console.WriteLine($" --- {randomPrompt} ---");

        Console.WriteLine("You may begin in:");
        Countdown();

        //Count items in a specified amount of time
        int itemCount = Count(time);

        Console.WriteLine("");
        Console.Write($"You listed {itemCount} items.");
        Console.WriteLine("");
    }

    //This method will read and create the prompt questions from the text file
    public void DisplayPrompt()
    {
        ReadItemsFromFile("listing-prompts.txt", _listingPrompt);
    }
}