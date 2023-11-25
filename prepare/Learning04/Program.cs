using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment assignment1 = new Assignment("Benjamin Franklin", "Freedom");
        Console.WriteLine(assignment1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Bill Nye", "Physics", "Section 1.2", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Peter Parker", "History", "The Cold War");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}