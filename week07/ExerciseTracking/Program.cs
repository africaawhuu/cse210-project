using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold different activity objects
        List<Activity> activities = new List<Activity>();

        // Instantiate at least one of each activity type
        Running run = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycle = new Cycling("03 Nov 2022", 45, 15.0);
        Swimming swim = new Swimming("03 Nov 2022", 40, 20);

        // Add them to the list
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        // Iterate through the list and display the summary for each activity polymorphically
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}