public class Activity
{

    private string _name;
    private string _description;
    private int _time;
    private int _count = 0;

    public Activity()
    {
        _name = "(No activity selected)";
        _description = "Please try again";
        _time = 0;
    }

    public Activity(string name, string description)
    {

        _name = name;
        _description = description;
        _time = 0;

    }

    public void SetTime()
    {

        try
        {
            _time = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            _count++;
            if (_count == 1)
            {
                RelaxType("Hmmm... that didn't work. Please type the number of seconds again: ");
                SetTime();
            }
            else if (_count == 2)
            {
                RelaxType("Make sure the number is an integer (like 30 or 60) and try again: ");
                SetTime();
            }
            else
            {
                RelaxType("I'm sorry. I'll set the time to one minute for you.");
                _time = 60;
            }
        }
        


    }


    public void StartActivity()
    {
        Console.Clear();
        RelaxType($"Welcome to the {_name} activity.\n");
        DisplayAnimation(2);
        RelaxType(_description);
        DisplayAnimation(3);
        System.Console.WriteLine("     ");
        RelaxType("How many seconds would you like to do the activity? ");
        SetTime();
        RelaxType("Lets get started...");

    }

    public void EndActivity()
    {
        RelaxType("Great Job.\nYou did wonderful focusing.");
        DisplayAnimation(2);
        RelaxType($"You have completed the {_name} activity.");
        RelaxType($"You meditated a total of {_time} seconds.");
        RelaxType("Have a great day!");
        DisplayAnimation(5);
    }

    public void RelaxType(string message, bool newline = true)
    {
        Console.CursorVisible = false;

        foreach (char character in message)
        {
            System.Console.Write(character);
            if (".?\n".Contains(character))
            {
                Thread.Sleep(500);
            }
            else
            {
                Thread.Sleep(75);
            }
        }
        if (newline)
        {
            System.Console.WriteLine();
        }

        Console.CursorVisible = true;
    }




    public void DisplayAnimation(int time, bool Slow = false, bool breath = false)
    {

        string load = "✶✷✸✹✺❁❂✪✩✫✮✯✭✬✭✯✮✫✩✪❂❁✺✹✸✷";
        int animateTime = 85;
        bool breathIn = true;

        if (time == 0)
        {
            time = _time;
        }

        if (Slow)
        {
            animateTime = 400;
            load = "▂▃▄▅▆▇█▇▆▅▄▃▂▁";
        }

        if(breath)
        {
            System.Console.WriteLine("Breath In \n");
        }

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(time);
        Console.CursorVisible = false;

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;

            foreach (char character in load)
            {

                for (int i = 0; i < 5; i++)
                {
                    System.Console.Write(character);
                }
                Thread.Sleep(animateTime);

                

                if (character == Convert.ToChar("█") || character == Convert.ToChar("▁"))
                    {
                        Thread.Sleep(500);

                        if (breath)
                        {

                            int previousLine = Console.CursorTop - 2;
                            Console.SetCursorPosition(0, previousLine);


                            breathIn = !breathIn;

                            if (breathIn)
                            {
                                System.Console.WriteLine("Breath In \n");
                            }

                            if (!breathIn)
                            {
                                System.Console.WriteLine("Breath Out\n");
                            }

                        }
                    }


                for (int i = 0; i < 5; i++)
                {
                    System.Console.Write("\b");
                }


            }

        }

        Console.CursorVisible = true;

    }

    public int GetTime()
    {
        return _time;
    }


}