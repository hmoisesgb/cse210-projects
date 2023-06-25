using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        Scripture scripture = new Scripture();

        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.HideRandomWords();
            if (scripture.IsCompletelyHidden() == true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Environment.Exit(0);
            }
        }
    }
}