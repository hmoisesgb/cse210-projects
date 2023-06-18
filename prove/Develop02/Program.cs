using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        int menuNumber = -1;
        string fileName = "";

        while (menuNumber != 5)
        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuNumber = int.Parse(Console.ReadLine());

            if (menuNumber == 1)
            {
                Entry newEntry = new Entry();
                newEntry._date = date.ToShortDateString();
                newEntry._prompt = prompt.RandomPrompt();
                Console.WriteLine($"{newEntry._prompt}");
                newEntry._userEntry = Console.ReadLine();
                journal.AddEntry(newEntry);
            }

            else if (menuNumber == 2)
            {
                journal.DisplayAll();
            }

            else if (menuNumber == 3)
            {
                Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                journal._entryList = journal.LoadFromFile(fileName);

            }

            else if (menuNumber == 4)
            {
                Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);

            }

            else if (menuNumber == 5)
            {
                Console.WriteLine("Thank you for using your Journal today!");
            }

            else
            {
                Console.WriteLine("Please select a number from 1 to 5");
            }
        }
    }
}