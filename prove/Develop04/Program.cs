using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing1 = new BreathingActivity();
        string userInput = " ";
        Console.WriteLine("Welcome to the activity program!");
        Console.WriteLine("In this program you have the option to choose a "+
                        "few activities to help calm you and keep you organized!");
        while(userInput != "4")
        {
            Console.WriteLine("Enter '1' for the breathing activity");
            Console.WriteLine("Enter '2' for the listing activity");
            Console.WriteLine("Enter '3' for the reflecting activity");
            Console.WriteLine("Enter '4' to exit the program");
            userInput = Console.ReadLine();
            if(userInput == "1")
            {
                breathing1.Run();
                userInput = " ";
            }
        }
    }
}