public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private int _totalNumberOfTimes=0;
    private int _totalNumberOfSeconds=0;

    public ReflectingActivity(){
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("How did you get started?");
    }

    public int GetTotalNumberOfSeconds()
    {
        return _totalNumberOfSeconds;
    }
    
    public int GetTotalNumberOfTimes()
    {
        return _totalNumberOfTimes;
    }

    public void Run(){
        int duration=GetDuration();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Console.Clear();
        while(DateTime.Now < futureTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(6);
        _totalNumberOfSeconds=_totalNumberOfSeconds+duration;
        _totalNumberOfTimes=_totalNumberOfTimes+1;
    }

    public string GetRandomPrompt(){
        Random random=new Random();
        int randomIndex= random.Next(0,4);
        string randomPrompt= _prompts[randomIndex];
        return randomPrompt;
    }

    public string GetRandomQuestion(){
        Random random=new Random();
        int randomIndex= random.Next(0,8);
        string randomQuestion= _questions[randomIndex];
        return randomQuestion;
    }

    public void DisplayPrompt(){
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} ---");
    }

    public void DisplayQuestions(){
        string question = GetRandomQuestion();
        Console.WriteLine($"{question}");
    }
    
}