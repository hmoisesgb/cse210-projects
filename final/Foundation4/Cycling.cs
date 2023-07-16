public class Cycling:Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed):base(date, length){
        SetType("Cycling");
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * GetLenght(); 
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60/_speed;
    }
}