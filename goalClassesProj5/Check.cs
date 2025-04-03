public class Check : Goal
{

    private int _bonus;
    private int _target;
    private int _complete;

    public Check(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
        _complete = 0;
    }

    public Check(string fileString) : base(fileString.Split(':').ToList()[1], fileString.Split(':').ToList()[2], Convert.ToInt32(fileString.Split(':').ToList()[3]))
    {
        List<string> values = fileString.Split(':').ToList();
        _bonus = Convert.ToInt32(values[4]);
        _target = Convert.ToInt32(values[6]);
        _complete = Convert.ToInt32(values[5]);
    }

    public override string Concatinate()
    {
        string mainSection = base.Concatinate();
        return $"Check:{mainSection}:{_bonus}:{_complete}:{_target}";
    }

    public override void Display()
    {
        string done = "⟳";
        if (_target <= _complete)
        {
            done = "✓";
        }
        System.Console.WriteLine($"{done} {GetDisplay()} - {_complete}/{_target} complete");
    }

    public override int Complete()
    {
        _complete++;
        if (_target <= _complete)
        {
            return base.Complete() + _bonus;
        }
        else
        {
            return base.Complete();
        }
    }

    public override bool IsComplete()
    {
        if (_target <= _complete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}