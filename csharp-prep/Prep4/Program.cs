using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int usernumber = -1;

        while (usernumber != 0)
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            usernumber = int.Parse(Console.ReadLine());

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = ((double)sum) / numbers.Count;

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}