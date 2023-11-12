using System;

class Program
{
    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
        int menuInput = 10;
        while (menuInput != 0)
        {
            Console.WriteLine("Please input your option.");
            Console.WriteLine("1: Give Prompt");
            Console.WriteLine("2: Write an entry");
            Console.WriteLine("3: View Journal");

            string menustring = Console.ReadLine();
            menuInput = int.Parse(menustring);

            if (menuInput == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                Console.WriteLine(prompt);
            }
            else if (menuInput == 2)
            {
                Entry entry = new Entry();
            }
            else if (menuInput == 3)
            {
                Journal journal = new Journal();
            }

            else 
            {
                Console.WriteLine("Please try again.");
            }
        }
        
    }
}