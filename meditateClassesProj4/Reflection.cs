public class Reflection : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you brightened someones day."
                                            ,"Think of a time you successfully did something difficult."
                                            ,"Think of a time you stood up for what was right."
                                            ,"Think of a time you did something selfless and holy."
                                            ,"Think of a time you brought the spirit into someone else's life."};
    private List<string> _questions = new List<string>{"Have you ever done this before in a different way?"
                                              ,"How did you know to act?"
                                              ,"How did you emmulate the character of Christ in your actions?"
                                              ,"What do you think Christ thought of you in that moment?"
                                              ,"How did you feel?"
                                              ,"What makes this particular experience stick in your memory?"
                                              ,"Why did you make that choice?"
                                              ,"What can you learn about yourself from this experience?"
                                              ,"How would others remember this experience?"
                                              ,"What did the Lord do to make this experience possible?"
                                              ,"How does this experience demonstrate the love of God for you?"
                                              ,"Are there any scripture stories that demonstrate a similar attribute or experience?"
                                              ,"Had you not made that choice, what could have happened?"
                                              ,"Based off this experience, how might the Lord see you in ways you don't?"};
    private Random random = new Random();
     
    public Reflection() : base("Reflection", "This activity is an opportunity to reflect on times in your life that demonstrated desirable traits. Do your best to follow the reflective questions and focus on the positive.")
    {

    }

    public void Start()
    {
        StartActivity();

        RelaxType("You've got this.");
        DisplayAnimation(2);

        List<string> prompts = new List<string>(_prompts);
        List<string> questions = new List<string>(_questions);

        int promptIndex = random.Next(prompts.Count);

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetTime());

        RelaxType("Your prompt is:");
        RelaxType(prompts[promptIndex]);
        prompts.Remove(prompts[promptIndex]);

        DisplayAnimation(5, true);

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;

            if (prompts.Count < 2)
            {
                System.Console.WriteLine("Please continue reflecting as time runs out.");
                while (currentTime < futureTime)
                {
                    currentTime = DateTime.Now;
                    DisplayAnimation(1, true);
                }

            }
            else if (questions.Count < 2)
            {   

                Console.Clear();

                promptIndex = random.Next(prompts.Count);
                RelaxType("Here is your new prompt: ");
                RelaxType(prompts[promptIndex]);
                prompts.Remove(prompts[promptIndex]);
                questions = _questions;
                DisplayAnimation(5, true);
                
            }
            else
            {
                int questionsIndex = random.Next(questions.Count);
                RelaxType(questions[questionsIndex]);
                questions.Remove(questions[questionsIndex]);
                DisplayAnimation(5, true);
                

            }

        }

        Console.Clear();
        EndActivity();
            
    }



}