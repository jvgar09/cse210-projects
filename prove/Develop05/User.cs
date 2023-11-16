
// User class to manage goals and score
public class User
{
    private List<Goal> _goals;
    private int _score;
    public int Score { get { return _score; } }

    public User()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal()
    {
        Console.WriteLine(" The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Checklist Goals");
        Console.Write("Which type of goal would you like to create? ");

        string goalType = Console.ReadLine();
        //goalType = int.Parse(goalType); 


        switch (goalType)
        {
            case "1":

                Console.WriteLine("What is the name of your Goal? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the Description? ");
                string description = Console.ReadLine();
                Console.WriteLine("How many Points is the goal worth? ");
                int points = int.Parse(Console.ReadLine());

                SimpleGoal simple = new(name, description, points);
                _goals.Add(simple);

                break;

            case "2":

                Console.WriteLine("What is the name of your Goal? ");
                name = Console.ReadLine();
                Console.WriteLine("What is the Description? ");
                description = Console.ReadLine();
                Console.WriteLine("How many Points is the goal worth? ");
                points = int.Parse(Console.ReadLine());

                EternalGoal eternal = new(name, description, points);
                _goals.Add(eternal);

                break;

            case "3":

                Console.WriteLine("What is the name of your Goal? ");
                name = Console.ReadLine();
                Console.WriteLine("What is the Description? ");
                description = Console.ReadLine();
                Console.WriteLine("How many Points is the goal worth? ");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your Target? ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Bouns Points is the goal worth? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklist = new(name, description, points, target, bonus);
                _goals.Add(checklist);

                break;

            default:
                Console.WriteLine("Invaild option. Please try again ");

                break;


        }

    }


    public void RecordEvent()
    {
        DisplayGoals();
        int goal = int.Parse(Console.ReadLine());
        _score += _goals[goal - 1].RecordEvent();
    }

    public void DisplayGoals()
    {
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{counter}) {goal.Display()}");
        }
    }

    public void Save(string path)
    {
        Console.WriteLine("Savig file name...");
        try
        {
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetSaveString());
                }

                outputFile.WriteLine(_score);

            }
        }
        catch
        {
            Console.WriteLine("Unale to save file.");
        }

    }



    public void Load(string path)
    {
        //  string[] lines = File.ReadAllLines( path )
        //  FOREACH line in lines
        //      string[] parts = line.Split("|")
        //      SWITCH parts[0]
        //          CASE "Score"
        //              _score = parts[1]
        //          CASE "SimpleGoal"
        //              Simple simple = new( parts[1], parts[2], parts[3], parts[4] )
        //              BREAK
        //          CASE "EternalGoal"
        //              Eternal eternal = new( parts[1], parts[2], parts[3], parts[4] )
        //              BREAK
        //          CASE "ChecklistGoal"
        //              Checklist checklist = new( parts[1], parts[2], parts[3], parts[4], parts[5], parts[5], parts[7] )
        //              BREAK
    }
}
