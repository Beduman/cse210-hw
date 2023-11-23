using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        List<Word> words;
        bool scriptureHidden = false;
        Reference theReference = new Reference("James",1,5);
        Scripture theScripture = new Scripture("If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. ");

        string scripture = theReference.GetDisplayText();

        List<string> scripturePhrase = theScripture.GetDisplayText();
        Console.WriteLine(scripture);
        Console.WriteLine(scripturePhrase);
        while (scriptureHidden = false)
        {
            Console.WriteLine("Welcome to the scripture memorizer!");
            Console.WriteLine("Type '1' to hide words, type 'quit' to end the program.");
            Console.WriteLine(theReference);
            Console.WriteLine(scripturePhrase);
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                scripturePhrase = theScripture.GetDisplayText();
                theScripture.HideRandomWords(scripturePhrase);
                Console.WriteLine(scripturePhrase);
                userInput = " ";
            }
            else if (userInput == "quit")
            {
                scriptureHidden = true;
            }
            else
            {
                Console.WriteLine("Please try again.");
            }

            Console.WriteLine("Goodbye");
        }
    }
}