using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(1,101);
        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess =  int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}