using System;
using System.ComponentModel;

//Class: Activity
// Attributes:
// * _activityName : string
// * _activityDescription : string
// * _sessionTime : int
// * _isTimeUp : Bool = false

// Behaviors:
// * Activity(default)
// * SetActivityName(activityName) : void
// * SetActivityDescription(activityDescription) : void
// * GetActivityName(activityName) : string
// * GetActivityDescription(activityDescription) : string
// * StartingMessage() : void
// * EndingMessage() : void
// * Pause(seconds) : void
// * Countdown() : void
// * GenerateRandomItems(List) : string
// * ReadItemsFromFile(filePath, List)

class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _sessionTime;

    //Default Activity constructor
    public Activity()
    {
        
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetActivityName(string name)
    {
        _activityName = name;
    }
    
    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void SetActivityDescription(string description)
    {
        _activityDescription = description;
    }

    public int GetSessionTime()
    {
        return _sessionTime;
    }

    public void SetSessionTime(int time)
    {
        _sessionTime = time;
    }

    //Method to display a starting message for all activity classes
    public void StartingMessage()
    {
        Console.Clear();
        
        Console.WriteLine($"Welcome to the {GetActivityName()}.");
        Console.WriteLine();
        Console.WriteLine($"{GetActivityDescription()}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string temp = Console.ReadLine();
        _sessionTime = int.Parse(temp);

        Console.Clear();
        
        Console.WriteLine("Get ready...");
        Console.WriteLine("");

        Pause(5, 250);
    }    

    //Method for the pause/spinner animation
    public void Pause(int animationTime, int sleepTime)
    {
        // |/-\|/-\|
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(animationTime);

        int i = 0;

        while (DateTime.Now < endTime)
        {
        String s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(sleepTime);
            Console.Write("\b \b");
        i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    //Countdown animation method
    public void Countdown()
    {
        for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    //Method to display an ending message for all activities
    public void EndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");

        Pause(5, 250);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetSessionTime()} seconds of the {GetActivityName()}.");

        Pause(5, 250);
    }

    //Created this method so that it gets random item from a list of items
    //Used for both prompt and ponder text files
    public string GenerateRandomItem(List<string> itemList)
    {
        if (itemList.Count == 0)
        {
            return "No items available.";
        }

        Random random = new Random();
        int index = random.Next(itemList.Count);
        string randomItem = itemList[index];
        return randomItem;
    }

    //Reads all items from a file and creates a list
    public void ReadItemsFromFile(string filePath, List<string> itemList)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                itemList.Add(line);
            }
        }
    }
}