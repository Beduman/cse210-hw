using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Enter your frade percentage: ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade >= 50)
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed and got a {letter}!");
        }
        else
        {
            Console.WriteLine($"Sorry, you got a {letter} and didn't pass the class.");
        }
    }
}