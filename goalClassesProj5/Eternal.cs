class Eternal : Goal
{

    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }

    public Eternal(string fileString) : base(fileString.Split(':').ToList()[1], fileString.Split(':').ToList()[2], Convert.ToInt32(fileString.Split(':').ToList()[3]))
    {

    }

    public override void Display()
    {
        System.Console.WriteLine($"∞ {GetDisplay()}");
    }

    public override string Concatinate()
    {
        string mainSection = base.Concatinate();
        return $"Eternal:{mainSection}";
    }

    public override bool IsComplete()
    {
        return false;
    }

}