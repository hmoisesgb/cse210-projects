public class ChecklistGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name, description, points){
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted):base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        IsComplete();
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString(){
        
        string details;
        if (IsComplete()==true)
        {
            details=$"[X] {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
        }
        else
        {
            details=$"[] {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
        }
        return details;
    }

    public override int RecordEvent()
    {
        _amountCompleted=_amountCompleted+1;
        if(IsComplete()==true)
        {
            Console.WriteLine($"Congratulations! You have been awarded {GetPoints()} points. \nYou recieved an aditional {_bonus} bonus points for completing the goal!");
            return GetPoints() + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have been awarded {GetPoints()} points.");
            return GetPoints();
        }
    }

    public override string GetStringRepresentation()
    {
        string representation=$"CheckListGoal;{GetName()}~{GetDescription()}~{GetPoints()}~{_target}~{_bonus}~{_amountCompleted}";
        return representation;
    }

}