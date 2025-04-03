public class Listing : Activity
{

    private List<string> _prompts = new List<string>{"List people you appreciate."
                                            ,"List the personal strengths you have or have demonstrated."
                                            ,"List times you have felt the Holy Ghost."
                                            ,"List miracles you have seen or experienced."
                                            ,"List things you would like to thank God for."};

    private Random random = new Random();

    public Listing() : base("Listing", "You will be prompted to list things that encourage thanks and gratitude. Write as many positive things as you can before the time runs out.")
    {

    }

    public void Start()
    {

        int promptIndex = random.Next(_prompts.Count);

        StartActivity();
        
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetTime());

        RelaxType(_prompts[promptIndex]);
        System.Console.WriteLine();


        Console.CursorVisible = false;
        for (int i = 5; i > 0; i--)
        {
            System.Console.Write($"{Convert.ToString(i)}\r");
            Thread.Sleep(1000);
            System.Console.Write(" \r");
        }
        Console.CursorVisible = true;


        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            System.Console.ReadLine();
        }

        EndActivity();
    }



}