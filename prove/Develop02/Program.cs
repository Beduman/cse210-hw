using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry theEntry = new Entry();
        int menuInput = 10;
        while (menuInput != 0)
        {
            Console.WriteLine("Please input your option.");
            Console.WriteLine("1: Give Prompt");
            Console.WriteLine("2: Write an entry");
            Console.WriteLine("3: View Journal");

            string menustring = Console.ReadLine();
            menuInput = int.Parse(menustring);

            //Give prompt
            if (menuInput == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                Console.WriteLine(prompt);
            }
            // Write an entry
            else if (menuInput == 2)
            {
                theEntry._entryText = Console.ReadLine();
                theEntry.Display();
                theJournal.SaveToFIle(theEntry._entryText);
            }
            //View journal
            else if (menuInput == 3)
            {
                theJournal.DisplayAll();
            }

            else 
            {
                Console.WriteLine("Please try again.");
            }
        }
        
    }
}