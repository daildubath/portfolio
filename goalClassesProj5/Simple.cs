public class Simple : Goal
{

    private bool _complete;

    public Simple(string name, string description, int points, bool complete = false) : base(name, description, points)
    {
        _complete = complete;
    }

    public Simple(string fileString) : base(fileString.Split(':').ToList()[1], fileString.Split(':').ToList()[2], Convert.ToInt32(fileString.Split(':').ToList()[3]))
    {
        List<string> values = fileString.Split(':').ToList();
        _complete = Convert.ToBoolean(values[4]);
    }

    public override string Concatinate()
    {
        string mainSection = base.Concatinate();
        return $"Simple:{mainSection}:{_complete}";
    }

    public override void Display()
    {
        string done = "⬚";
        if (_complete)
        {
            done = "▣";
        }
        System.Console.WriteLine($"{done} {GetDisplay()}");
    }

    public override int Complete()
    {
        _complete = true;
        return base.Complete();
    }

    public override bool IsComplete()
    {
        return _complete;
    }


}