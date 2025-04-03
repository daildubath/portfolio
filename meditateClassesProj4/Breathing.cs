public class Breathing : Activity
{

    public Breathing() :base("Breathing", "You will be prompted on the screen to either breathe in or out. As you do you will see a bar rise and fall. \n-Note that before the program ends it will finish your current breath.")
    {

    }

    public void Start()
    {
        StartActivity();
        RelaxType("Ready?");
        DisplayAnimation(3);
        Console.Clear();

        DisplayAnimation(0, true, true);

        Console.Clear();

        EndActivity();
    }




}