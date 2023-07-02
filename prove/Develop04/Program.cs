using System;

class Program
{
    static void Main(string[] args)
    {
        int menuOption = 0;

        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        Activity activity = new Activity();

        while (menuOption != 5)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Show activity logs for this session");
            Console.WriteLine("5. Quit");

            menuOption = int.Parse(Console.ReadLine());

            if (menuOption == 1)
            {
                breathingActivity.DisplayStartingMessage();
                Console.Clear();
                breathingActivity.Run();
            }
            else if(menuOption == 2)
            {
                reflectingActivity.DisplayStartingMessage();
                Console.Clear();
                reflectingActivity.Run();
            }
            else if(menuOption == 3)
            {
                listingActivity.DisplayStartingMessage();
                Console.Clear();
                listingActivity.Run();
            }
            else if(menuOption == 4){
                activity.ShowActivityLog(breathingActivity,reflectingActivity,listingActivity);
            }
            else if(menuOption == 5){
                Environment.Exit(0);
            }

        }

    }
}