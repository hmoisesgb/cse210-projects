public class GoalManager
{
    private List<Goal> _goals;
    private int _points;
    private int _level;

    public GoalManager(){
        _goals = new List<Goal>();
        _points = 0;
    }
    public void Start(){

        int option = 0;

        while (option != 6)
        {
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                CreateGoal();
            }
            if(option == 2)
            {
                ListGoals();
            }
            if(option == 3)
            {
                SaveGoals();
            }
            if(option == 4)
            {
                LoadGoals();
            }
            if(option == 5)
            {
                RecordEvent();
            }
            if(option == 6)
            {
                Environment.Exit(0);
            }
        }
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"\nYou have {_points} points and you are level {_level}");
    }

    public void ListGoals(){
        int goalNumber = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetDetailsString()}");
            goalNumber++;
        }
        DisplayPlayerInfo();
    }

    public void CreateGoal(){
        int goalType = 0;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalType = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with your goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
            _goals.Add(simpleGoal);
        }
        else if (goalType == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with your goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(name,description,points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with your goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this list needs to be acomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for acomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checkListGoal = new ChecklistGoal(name,description,points,target,bonus);
            _goals.Add(checkListGoal);
        }
    }

    public void RecordEvent(){
        Console.WriteLine("The goals are:");
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        _points = _points + _goals[goalIndex].RecordEvent();
        int level = _points / 500;
        if (level > _level)
        {
            Console.WriteLine($"Congratulations! , You have level up. Your new level is: {level}");
        }
        _level = level;
        DisplayPlayerInfo();
    }

    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_points},{_level}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"File saved as {fileName}");
    }

    public void LoadGoals(){
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int i = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            string[] scoreAndLevel=parts[0].Split(",");
            if (i == 0)
            {
                _points = int.Parse(scoreAndLevel[0]);
                _level = int.Parse(scoreAndLevel[1]);
            }
            else
            {
                string goalType = parts[0];
                string[] goalInformation = parts[1].Split("~");
                if (goalType == "SimpleGoal")
                {
                    bool isComplete;
                    if (goalInformation[3] == "True")
                    {
                        isComplete = true;
                    }
                    else
                    {
                        isComplete = false;
                    }
                    SimpleGoal simpleGoal = new SimpleGoal(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]), isComplete);
                    _goals.Add(simpleGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]));
                    _goals.Add(eternalGoal);
                }
                else if (goalType == "CheckListGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]), int.Parse(goalInformation[3]), int.Parse(goalInformation[4]), int.Parse(goalInformation[5]));
                    _goals.Add(checklistGoal);
                }
            }
            i++;
        }
        Console.WriteLine($"File {fileName} loaded");

    }


}