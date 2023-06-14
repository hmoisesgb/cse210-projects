using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "IntouchCX";
        job1._jobTitle = "Customer Service Representative";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Atento";
        job2._jobTitle = "Customer Service Representative";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Haroldo Gonzalez";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}