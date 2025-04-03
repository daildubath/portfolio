public abstract class Goal
{

    private string _name;
    private string _description;
    private int _points;

    public Goal()
    {
        _name = "";
        _points = 0;
        _description = "";
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public Goal(string fileString)
    {
        _name = "Error: ";
        _description = "Goal unable to load properly.";
        _points = 0;
    }

    public abstract void Display();

    protected string GetDisplay()
    {
        return $"{_name}: {_description} for {_points}";
    }

    public virtual string Concatinate()
    {
        return $"{_name}:{_description}:{_points}";
    }
    
    public virtual int Complete()
    {
        return _points;
    }

    public abstract bool IsComplete();

}