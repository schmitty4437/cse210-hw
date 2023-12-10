using System;
using System.Collections.Generic;

public class ActivityTracker
{
    private List<Activity> activities;

    //Constructor initializes the activity list
    public ActivityTracker()
    {
        activities = new List<Activity>();
    }

    //Method adds each activity to the list
    public void AddActivity(Activity activity)
    {
        activities.Add(activity);
    }

    //Method iterates through the list to display them.
    public void DisplayActivitySummary()
    {
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}