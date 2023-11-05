using System;

class Program
{
    static void Main(string[] args)
    {
        //Activity myActivity = new Activity();
        string response = ""; 

        //Loop to get the user to pick a correct selection
        while (response != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            //Get users choice
            Console.Write("Select a choice from the menu:  ");
            response = Console.ReadLine();
            switch(response)
            {
                //Breathing Activity choice
                case "1": 
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartingMessage();
                    breathingActivity.StartBreathe(breathingActivity.GetSessionTime());
                    breathingActivity.EndingMessage();
                    break;

                case "2":
                    ReflectionActivity reflectActivity = new ReflectionActivity();
                    reflectActivity.StartingMessage();
                    reflectActivity.StartReflection(reflectActivity.GetSessionTime());
                    reflectActivity.EndingMessage();
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.StartingMessage();
                    listingActivity.StartListing(listingActivity.GetSessionTime());
                    listingActivity.EndingMessage();
                    break;
                
                case "4":
                    break;
            }
        }
    }
}