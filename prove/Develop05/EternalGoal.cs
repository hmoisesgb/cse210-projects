public class EternalGoal:Goal
{
    public EternalGoal(string name, string description, int points):base(name, description, points){
        //Left the constructor empty as there are no values to be set here.
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string representation=$"EternalGoal;{GetName()}~{GetDescription()}~{GetPoints()}";
        return representation;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have been awarded {GetPoints()} points");
        return GetPoints();
    }



}