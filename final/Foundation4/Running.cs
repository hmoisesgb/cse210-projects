public class Running:Activity
{
    private double _distance;

    public Running(string date, double length, double distance):base(date, length){
        SetType("Running");
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetLenght() * 60;
    }

    public override double GetPace()
    {
        return GetLenght() / _distance;
    }
}