using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name = "";
    
    // Initialize the list immediately upon declaration
    public List<Job> _jobs = new List<Job>();

    // Method to display the name and loop through all job entries
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            // Call the Display method on each Job instance
            job.Display();
        }
    }
}
