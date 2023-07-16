public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private Address _address;

    public Event(string title, string description, string date, string time, string type, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public void ShowStandardDetails(){
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}");
    }

    public void ShowShortDescription(){
        Console.WriteLine($"Event Type: {_type}\nTitle: {_title}\nDate: {_date}");
    }
}