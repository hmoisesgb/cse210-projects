public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private List<Activity> _activityList=new List<Activity>();

    public Activity(){
        _duration = 0;
    }
    public void SetName(string name)
    {
        _name=name;
    }
     public void SetDescription(string description)
    {
        _description=description;
    }

    public void SetDuration(int duration)
    {
        _duration=duration;
    }

    public string GetName(){
        return _name;
    }

    public int GetDuration(){
        return _duration;
    }
    public void DisplayStartingMessage(){

        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage(){

        Console.WriteLine("Well Done!!");
        ShowSpinner(6);
        Console.WriteLine($"You hace completed another {_duration} seconds of the {_name} Activity");

    }

    public void ShowSpinner(int seconds){

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds){

        for(int i=seconds; i > 0;i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public void ShowActivityLog(BreathingActivity breathingActivity, ReflectingActivity reflectingActivity, ListingActivity listingActivity)
    {
            Console.WriteLine("Here is your activity log for this session:");
            Console.WriteLine($"You used the {breathingActivity.GetName()} Activity for a total of {breathingActivity.GetTotalNumberOfSeconds()} seconds, and you used it a total amount of {breathingActivity.GetTotalNumberOfTimes()} times");
            Console.WriteLine($"You used the {reflectingActivity.GetName()} Activity for a total of {reflectingActivity.GetTotalNumberOfSeconds()} seconds, and you used it a total amount of {reflectingActivity.GetTotalNumberOfTimes()} times");
            Console.WriteLine($"You used the {listingActivity.GetName()} Activity for a total of {listingActivity.GetTotalNumberOfSeconds()} seconds, and you used it a total amount of {listingActivity.GetTotalNumberOfTimes()} times");
            Console.WriteLine();
    }
}