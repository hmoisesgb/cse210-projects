public class BreathingActivity : Activity
{

    private int _totalNumberOfTimes=0;
    private int _totalNumberOfSeconds=0;
    public BreathingActivity(){
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
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

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        int duration=GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
             
        }
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(6);
        _totalNumberOfSeconds=_totalNumberOfSeconds+duration;
        _totalNumberOfTimes=_totalNumberOfTimes+1;

    }
}