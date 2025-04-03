public class Menu
{


    public void Display(int choice, bool overwrite = true)
    {
        string ch1 = "   ";
        string ch2 = "   ";
        string ch3 = "   ";
        string ch4 = "   ";
        string ch5 = "   ";
        string ch6 = "   ";

        if (choice == 1)
        {
            ch1 = "-->";
        }
        else if (choice == 2)
        {
            ch2 = "-->";
        }
        else if (choice == 3)
        {
            ch3 = "-->";
        }
        else if (choice == 4)
        {
            ch4 = "-->";
        }
        else if (choice == 5)
        {
            ch5 = "-->";
        }
        else if (choice == 6)
        {
            ch6 = "-->";
        }


        if (overwrite)
        {
            int previousLine = Console.CursorTop - 6;
            Console.SetCursorPosition(0, previousLine);
        }

        System.Console.WriteLine($"{ch1}1. Create Goal");
        System.Console.WriteLine($"{ch2}2. List Goals");
        System.Console.WriteLine($"{ch3}3. Complete Goal");
        System.Console.WriteLine($"{ch4}4. Save Goals");
        System.Console.WriteLine($"{ch5}5. Load Goals");
        System.Console.WriteLine($"{ch6}6. Quit");

    }



    public void Goal(int choice)
    {
        string ch1 = "   ";
        string ch2 = "   ";
        string ch3 = "   ";

        if (choice == 1)
        {
            ch1 = "-->";
        }
        else if (choice == 2)
        {
            ch2 = "-->";
        }
        else if (choice == 3)
        {
            ch3 = "-->";
        }


        int previousLine = Console.CursorTop - 7;
        Console.SetCursorPosition(0, previousLine);

        System.Console.WriteLine();
        System.Console.WriteLine("Which Goal would you like to create?");
        System.Console.WriteLine("------------------------------------");
        System.Console.WriteLine($"{ch1} Simple                       ");
        System.Console.WriteLine($"{ch2} Eternal                      ");
        System.Console.WriteLine($"{ch3} Check List                   ");
        System.Console.WriteLine("--------------------hit B for back--");
    }


    public void Complete(List<Goal> goals, int choice)
    {
        int count = goals.Count() -1 ;

        Console.Clear();
        System.Console.WriteLine("||| ⚽ - THE GOAL KEEPER - 🥅 |||");
        System.Console.WriteLine();

        System.Console.WriteLine("--Select the goal to mark complete--");

        for (int i = 0; i <= count; i++)
        {
            if (choice == i)
            {
                System.Console.Write("--> ");
            }
            else
            {
                System.Console.Write("    ");
            }
            goals[i].Display();
        }

        System.Console.WriteLine("------------------hit B to go back--");
    }




}