public class Swimming:Activity
{
    private double _laps;

    public Swimming(string date, double length, double laps):base(date, length){
        SetType("Swimming");
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLenght()) * 60;
    }

    public override double GetPace()
    {
        return GetLenght() / GetDistance();
    }
}