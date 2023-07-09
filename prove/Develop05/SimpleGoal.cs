public class SimpleGoal:Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description,int points):base(name,description,points){
        _isComplete = false;
    }

    public SimpleGoal(string name, string description,int points, bool isComplete):base(name,description,points){
        _isComplete = isComplete;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"SimpleGoal;{GetName()}~{GetDescription()}~{GetPoints()}~{_isComplete}";
        return representation;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete=true;
        Console.WriteLine($"Congratulations! You have been awarded {GetPoints()} points");
        return GetPoints();
    }

}