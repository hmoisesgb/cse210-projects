using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running a1 = new Running("30 July 2022",60,100);
        Cycling a2 = new Cycling("25 June 2023", 45, 50);
        Swimming a3 = new Swimming("14 July 2023", 20, 20);

        activities.Add(a1);
        activities.Add(a2);
        activities.Add(a3);

        foreach (Activity a in activities)
        {
            a.GetSummary();
        }
    }
}