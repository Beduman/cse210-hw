using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = " ";
        Console.WriteLine("Welcome to the activity program!");
        Console.WriteLine("In this program you have the option to choose a "+
                        "few activities to help calm you and keep you organized!");
        
        
        while(userInput != "4")
        {
            Console.WriteLine("Enter '1' for the simple goal");
            Console.WriteLine("Enter '2' for the eternal goal");
            Console.WriteLine("Enter '3' for the checklist goal");
            Console.WriteLine("Enter '4' to exit the program");
            userInput = Console.ReadLine();
            if(userInput == "1")
            {
                
                userInput = " ";
            }
            else if(userInput == "2")
            {
                
                userInput = " ";
            }
            else if(userInput == "3")
            {
                
                userInput = " ";
            }
            else
            {
                Console.WriteLine("Please input one number through 1 and 4");
            }
            
        }
    }
}