using System;

//Class: BreathingActivity
// Attributes:
// inherits from base class Activity.cs

// Behaviors:
// * BreathingActivity(string name, string description)
// * StartBreathe() : void

//Class BreathingActivity is inheriting from base class Activity
class BreathingActivity : Activity
{
    //Setting values for name and description of breathing activity
    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        //int time = GetSessionTime();
    }

    //Breathe method that accepts the time the user inputs
    public void StartBreathe(int time)
    {
        Console.WriteLine("");
        
        //Set the values for breathing in and out
        int breatheInDuration = 4;
        int breatheOutDuration = 6;

        //While loop used that will continue to loop while there is still time remaining
        while (time > 0)
        {
            //Here I adjust the time if there is not enough time to complete the cycle
            if (time < breatheInDuration + breatheOutDuration)
            {
                breatheInDuration = time / 2;
                breatheOutDuration = time - breatheInDuration;
            }

            Console.Write("Breathe In...");
            //Animation for the countdown
            for (int i = breatheInDuration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");

            Console.Write("Breathe Out...");
            //Animation for the countdown
            for (int i = breatheOutDuration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");

            //Sets how much time is left after each cycle.
            time -= breatheInDuration + breatheOutDuration;
        }
    }    
}