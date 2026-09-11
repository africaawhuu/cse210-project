using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create two Job instances
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Step 2: Create a Resume instance
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Step 3: Add jobs to the resume's list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Step 4: Display the entire resume
        myResume.Display();
    }
}
