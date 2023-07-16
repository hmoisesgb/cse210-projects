public class Outdoor:Event
{
    private string _weatherStatement;
    public Outdoor(string title, string description, string date, string time, string type, Address address, string weatherStatement):base(title, description, date, time, type, address){
        _weatherStatement = weatherStatement;
    }
    public void ShowFullDetails(){
        ShowStandardDetails();
        Console.WriteLine(_weatherStatement);
    }

}