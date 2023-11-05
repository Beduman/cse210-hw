using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string returnname()
        {
            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();
            return name;
        }
        static int returnnumber()
        {
            Console.WriteLine("Choose a number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }



        DisplayMessage();
        string name = returnname();
        int number = returnnumber();
        Console.WriteLine($"Your name is {name}, and your number is {number}");
    }
}