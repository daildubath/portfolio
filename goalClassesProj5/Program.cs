// Written for Programming with Classes
// The assignment was to create a goal tracker to demonstrate polymorphism
// I added a personal goal to create a simple gui and user interface
class Program
{
    static void Main(string[] args)
    {

        ConsoleKeyInfo keyInfo;
        Menu menu = new Menu();
        List<Goal> goals = new List<Goal>();
        int selection = 1;
        int points = 0;
        bool running = true;
        string drink = "🥂";
        List<string> drinks = ["🥛", "🫂", "🍻", "🍼", "🥂", "💀"];





        // // --------- TO BE REMOVED AFTER TESTING ---------
        // Simple simple1 = new Simple("Cut hair", "Shorten my hair and inch", 15);
        // Eternal eternal1 = new Eternal("Kiss Kylie", "She's beautiful and deserves it", 32);
        // Check check1 = new Check("jj", "tj", 5, 15, 5);
        // Simple simple2 = new Simple("Wet Dog", "Make my dog soggy", 5, true);
        // Eternal eternal2 = new Eternal("Milk Cow", "Old betsy wants to be empty", 15);
        // Check check2 = new Check("jj mic", "tj mic", 7, 12, 1);
        // Simple simple3 = new Simple("Lick Potato", "Remove the dirt with your tounge", 20);
        // goals.Add(simple1);
        // goals.Add(eternal1);
        // goals.Add(check1);
        // goals.Add(simple2);
        // goals.Add(eternal2);
        // goals.Add(check2);
        // goals.Add(simple3);

        // List<Goal> goals2 = new List<Goal>();

        // foreach (Goal goal in goals)
        // {
        //     string concat = goal.Concatinate();
        //     if (concat[0] == 'S')
        //     {
        //         Simple simple = new Simple(concat);
        //         goals2.Add(simple);
        //     }
        //     else if (concat[0] == 'E')
        //     {
        //         Eternal eternal = new Eternal(concat);
        //         goals2.Add(eternal);
        //     }
        //     else if (concat[0] == 'C')
        //     {
        //         Check check = new Check(concat);
        //         check.Complete();
        //         goals2.Add(check);
        //     }
        // }
        // System.Console.WriteLine("FIRST");
        // foreach (Goal goal in goals)
        // {
        //     goal.Display();
        // }
        // System.Console.WriteLine("SECOND");
        // foreach (Goal goal in goals2)
        // {
        //     goal.Display();
        // }
        // System.Console.Read();
        // // -----------------------------------------------





        while (running)
        {

            Console.Clear();
            System.Console.WriteLine($"||| ⚽ - THE GOAL KEEPER - 🥅 ||| POINTS: {points}");
            System.Console.WriteLine();


            menu.Display(selection, false);
            Console.CursorVisible = false;

            while (running)
            {
                if (selection == 0)
                {
                    selection = 6;
                    menu.Display(selection);
                }
                else if (selection == 7)
                {
                    selection = 1;
                    menu.Display(selection);
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selection--;
                    menu.Display(selection);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selection++;
                    menu.Display(selection);
                }
                else if (keyInfo.Key == ConsoleKey.D)
                {
                    drink = drinks[selection - 1];
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (selection == 1)
                    {
                        CreateGoal();
                        break;
                    }
                    else if (selection == 2)
                    {
                        Console.Clear();
                        foreach (Goal goal in goals)
                        {
                            goal.Display();
                        }
                        System.Console.WriteLine();
                        System.Console.WriteLine("Hit Enter to go back");
                        System.Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else if (selection == 3)
                    {
                        CompleteGoal();
                        break;
                    }
                    else if (selection == 4)
                    {
                        Save();
                        break;
                    }
                    else if (selection == 5)
                    {
                        Load();
                        break;
                    }
                    else if (selection == 6)
                    {
                        System.Console.WriteLine($"To your success: {drink}");
                        running = false;
                    }
                }
            }



        }


        void CreateGoal()
        {
            int goalChoice = 1;
            menu.Goal(goalChoice);
            while (true)
            {
                if (goalChoice == 0)
                {
                    goalChoice = 3;
                    menu.Goal(goalChoice);
                }
                else if (goalChoice == 4)
                {
                    goalChoice = 1;
                    menu.Goal(goalChoice);
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    goalChoice--;
                    menu.Goal(goalChoice);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    goalChoice++;
                    menu.Goal(goalChoice);
                }
                else if (keyInfo.Key == ConsoleKey.B)
                {
                    return;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.CursorVisible = true;
                    Console.Clear();
                    if (goalChoice == 1)
                    {
                        System.Console.Write("What would you like to name the simple goal? ");
                        string name = Console.ReadLine();
                        System.Console.Write("Write a description: ");
                        string description = Console.ReadLine();
                        int goalPoints = GetInt();

                        Simple simple = new Simple(name, description, goalPoints);
                        goals.Add(simple);
                        Console.CursorVisible = false;
                        return;
                    }
                    else if (goalChoice == 2)
                    {
                        System.Console.Write("What would you like to name the eternal goal? ");
                        string name = Console.ReadLine();
                        System.Console.Write("Write a description: ");
                        string description = Console.ReadLine();
                        int goalPoints = GetInt();

                        Eternal eternal = new Eternal(name, description, goalPoints);
                        goals.Add(eternal);
                        Console.CursorVisible = false;
                        return;
                    }
                    else if (goalChoice == 3)
                    {
                        System.Console.Write("What would you like to name the check list goal? ");
                        string name = Console.ReadLine();
                        System.Console.Write("Write a description: ");
                        string description = Console.ReadLine();
                        int target = GetInt("How many times would you like to complete the goal? ");
                        int goalPoints = GetInt("How many points would you like to get per completion? ");
                        int bonusPoints = GetInt($"How many bonus points would you like after completing {target}/{target}? ");

                        Check check = new Check(name, description, goalPoints, bonusPoints, target);
                        goals.Add(check);
                        Console.CursorVisible = false;
                        return;
                    }
                }
            }
        }


        void CompleteGoal()
        {
            List<Goal> iGoals = new List<Goal>();
            List<int> goalIndex = new List<int>();
            int index = 0;

            foreach (Goal goal in goals)
            {
                if (!goal.IsComplete())
                {
                    iGoals.Add(goal);
                    goalIndex.Add(index);
                }
                index++;
            }

            int goalChoice = 0;
            int count = iGoals.Count() - 1;
            menu.Complete(iGoals, goalChoice);
            while (true)
            {
                if (goalChoice < 0)
                {
                    goalChoice = count;
                    menu.Complete(iGoals, goalChoice);
                }
                else if (goalChoice == (count + 1))
                {
                    goalChoice = 0;
                    menu.Complete(iGoals, goalChoice);
                }
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    goalChoice--;
                    menu.Complete(iGoals, goalChoice);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    goalChoice++;
                    menu.Complete(iGoals, goalChoice);
                }
                else if (keyInfo.Key == ConsoleKey.B)
                {
                    return;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    points += goals[goalIndex[goalChoice]].Complete();
                    return;
                }
            }
        }


        void Load()
        {
            Console.CursorVisible = true;
            try
            {
                Console.Clear();
                System.Console.WriteLine("Type 'back' to go back, hit enter for default 'goals.txt'");
                System.Console.Write("What file would you like to pull from? ");
                string textFile = System.Console.ReadLine();


                if (textFile == "")
                {
                    textFile = "goals.txt";
                }
                else if (textFile == "back")
                {
                    return;
                }

                string[] concats = System.IO.File.ReadAllLines(textFile);

                points = Convert.ToInt32(concats[0]);

                goals.Clear();

                foreach (string concat in concats)
                {
                    if (concat[0] == 'S')
                    {
                        Simple simple = new Simple(concat);
                        goals.Add(simple);
                    }
                    else if (concat[0] == 'E')
                    {
                        Eternal eternal = new Eternal(concat);
                        goals.Add(eternal);
                    }
                    else if (concat[0] == 'C')
                    {
                        Check check = new Check(concat);
                        goals.Add(check);
                    }
                }
            }
            catch
            {
                System.Console.WriteLine("File not found. Hit enter to go back.");
                Console.Read();
                Console.CursorVisible = false;
                return;
            }  

            System.Console.WriteLine("Load completed. Hit enter to go back.");
            System.Console.Read();
            Console.CursorVisible = false;
        }


        void Save()
        {
            Console.CursorVisible = true;
            Console.Clear();
            System.Console.WriteLine("Type 'back' to go back, hit enter for default 'goals.txt'");
            System.Console.Write("What file would you like to save to? ");
            string textFile = System.Console.ReadLine();


            if (textFile == "")
            {
                textFile = "goals.txt";
            }
            else if (textFile == "back")
            {
                return;
            }

            using (StreamWriter saveFile = new StreamWriter(textFile))
            {
                saveFile.WriteLine(points);

                foreach (Goal goal in goals)
                {
                    saveFile.WriteLine(goal.Concatinate());
                }
            }
            System.Console.WriteLine("Completed. Hit enter to go back.");
            Console.CursorVisible = false;
            System.Console.Read();
        }

        int GetInt(string prompt = "How many points would you like the goal to be worth? ")
        {
            int count = 0;
            while (count < 6)
            {
                try
                {
                    System.Console.Write(prompt);
                    int goalPoints = Convert.ToInt16(Console.ReadLine());
                    return goalPoints;
                }
                catch
                {
                    count++;
                    System.Console.WriteLine("Couldn't convert to number, try again.");
                }
            }
            System.Console.WriteLine("Sorry, that didn't work.");
            System.Console.Write("The number has been set to 5.");
            System.Console.Read();
            return 5;
        }
    }
}