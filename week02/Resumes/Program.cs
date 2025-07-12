using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Valve";
        job1._startYear = 1996;
        job1._endYear = 2007;

        Job job2 = new Job();
        job2._jobTitle = "Engine Designer";
        job2._company = "ID Software";
        job2._startYear = 1993;
        job2._endYear = 2010;



        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Robbie Bobaway";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}