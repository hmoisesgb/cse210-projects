public class Entry
{
    public string _prompt;
    public string _date;
    public string _userEntry;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} \n{_userEntry}");
    }
}