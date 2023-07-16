public abstract class Activity{
    private string _date;
    private double _length;
    private string _type;

    public Activity(string date, double length){
        _date = date;
        _length = length;
        _type = "";
    }

    public void SetType(string type){
        _type = type;
    }

    public double GetLenght(){
        return _length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public void GetSummary(){
        Console.WriteLine($"{_date} {_type} ({_length} min)- Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km");
    }

}