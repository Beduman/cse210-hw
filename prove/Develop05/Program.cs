using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = " ";
        int points = 0;
        Console.WriteLine("Welcome to the activity program!");
        Console.WriteLine("In this program you have the option to choose a "+
                        "few activities to help calm you and keep you organized!");
        EternalGoal eternalGoal1 = new EternalGoal();
        ChecklistGoal checklistGoal1 = new ChecklistGoal();
        SimpleGoal simpleGoal1 = new SimpleGoal();
        GoalManager goalManager1 = new GoalManager();
        
        while(userInput != "4")
        {
            Console.WriteLine("You have " + points + " points");
            Console.WriteLine();
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3 Load goals");
            Console.WriteLine("Enter '4' to exit the program");
            userInput = Console.ReadLine();
            if(userInput == "1")
            {
                goalManager1.CreateGoal();
                userInput = " ";
            }
            else if(userInput == "2")
            {
                goalManager1.RetrieveGoals();
                userInput = " ";
            }
            else if(userInput == "3")
            {
                
                userInput = " ";
            }
            else if(userInput == "4")
            {

            }
            else
            {
                Console.WriteLine("Please input one number through 1 and 4");
            }
            
        }
    }
}