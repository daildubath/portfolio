// Built for the class Programming with Classes to demonstrate inheritance
// A personal added focus I gave when building was the look and feel.
// I wanted the program to be uplifting and relaxing, and easy to use.
class Program
{
    static void Main(string[] args)
    {


        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        Breathing breathing = new Breathing();
        bool meditate = true;
        string input = "";

        Console.Clear();

        breathing.RelaxType("Seems like its time to take a break.\r", false);
        System.Console.Write("                                    \r");

        while (meditate)
        {
            breathing.RelaxType("Which activity would like to do?");
            Thread.Sleep(300);
            System.Console.WriteLine("1. Breathing");
            Thread.Sleep(300);
            System.Console.WriteLine("2. Reflection");
            Thread.Sleep(300);
            System.Console.WriteLine("3. Listing");
            Thread.Sleep(300);
            System.Console.WriteLine("4. I'm done for now");
            Thread.Sleep(300);
            breathing.RelaxType(":", false);
            
            input = System.Console.ReadLine();

            Console.Clear();

            if (input == "1")
            {
                breathing.Start();
            }
            else if (input == "2")
            {
                reflection.Start();
            }
            else if (input == "3")
            {
                listing.Start();
            }
            else if (input == "4")
            {
                meditate = false;
            }
            else
            {
                breathing.RelaxType("Hmm... Had a mistype?");
            }

        }

        breathing.RelaxType("I hate to see you go.\nI wish you well until next time.");


    }
    
}