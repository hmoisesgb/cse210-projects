public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private int _totalNumberOfTimes=0;
    private int _totalNumberOfSeconds=0;

    public ListingActivity(){
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run(){
        _count = 0;
        string randomPrompt = GetRandomPrompt();
        int duration=GetDuration();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {randomPrompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Console.WriteLine();
        while(DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(6);
        _totalNumberOfSeconds=_totalNumberOfSeconds+duration;
        _totalNumberOfTimes=_totalNumberOfTimes+1;
    }

    public int GetTotalNumberOfSeconds()
    {
        return _totalNumberOfSeconds;
    }
    
    public int GetTotalNumberOfTimes()
    {
        return _totalNumberOfTimes;
    }

    public string GetRandomPrompt(){
        Random random=new Random();
        int randomIndex= random.Next(0,4);
        string randomPrompt= _prompts[randomIndex];
        return randomPrompt;
    }

    public List<string> GetListFromUser(){

        return _prompts;
    }
}