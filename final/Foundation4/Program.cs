using System;

class Program
{
    static void Main(string[] args)
    {
        //I have a bug that doesn't clear out my console.
        //google search gave me this solution: https://github.com/dotnet/runtime/issues/28355
        //clears screen and the scrollback buffer
        Console.Clear();
        Console.WriteLine("\x1b[3J");

        //Instance of ActivityTracker
        ActivityTracker tracker = new ActivityTracker();

        //Creating new instances for each exercise activity
        Running newRun = new Running(DateTime.Now, 30, 3.0);
        Cycling newCycle = new Cycling(DateTime.Now, 45, 15.0);
        Swimming newSwim = new Swimming(DateTime.Now, 20, 10);

        //Add each activity to ActivityTracker
        tracker.AddActivity(newRun);
        tracker.AddActivity(newCycle);
        tracker.AddActivity(newSwim);

        //Displaying the summary for all created activities
        Console.WriteLine("****    Polymorphism with Exercise Tracking    ****");
        Console.WriteLine();
        tracker.DisplayActivitySummary();
    }
}