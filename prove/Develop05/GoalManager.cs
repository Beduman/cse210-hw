using System.IO; 
public class GoalManager
{
    private string _fileName = "myGoals.txt";
    private string[] _lines;
    public void RetrieveGoals ()
    {
        
        _lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in _lines)
            {
                string[] goalIndex = line.Split(",");
                Console.WriteLine(line);
            }
        
    }
    public void CreateEvent()
    {
        Console.WriteLine("Choose a goal to make an event.");
        _lines = System.IO.File.ReadAllLines(_fileName);
        string editGoal;
        foreach (string line in _lines)
            {
                string userInput = "0";
                Console.WriteLine(line);
                Console.WriteLine("Is this the goal you want to edit?");
                Console.WriteLine("1. yes");
                Console.WriteLine("2. no");
                userInput = Console.ReadLine();
                if (userInput == "1" || userInput == "2")
                {
                    editGoal = line;
                    break;
                }
                else{}
            }

    }
    public void CreateGoal()
    {
        string userInput = "";
        Console.WriteLine("1. Checklist Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Simple Goal");
        userInput = Console.ReadLine();

            if(userInput == "1")
            {
                string fileName = "myGoals.txt";
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    string outputInput;
                    outputFile.Write("checklistGoal, ");
                    Console.WriteLine("What is the name of your goal?");
                    outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("Give a description");
                    outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("How many points is this worth?");
                    outputInput = Console.ReadLine();
                    outputFile.WriteLine(outputInput);
                    Console.WriteLine("How many times can you complete this goal?");
                    outputInput = Console.ReadLine();
                    outputFile.WriteLine(outputInput);
                }
            }
            else if (userInput == "2")
            {
                string fileName = "myGoals.txt";
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    string outputInput;
                    outputFile.Write("eternalGoal, ");
                    Console.WriteLine("What is the name of your goal?");
                    outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("Give a description");
                    outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("How many points is this worth?");
                    outputInput = Console.ReadLine();
                    outputFile.WriteLine(outputInput);

                }
            }
            else
            {
                string fileName = "myGoals.txt";
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    string outputInput;
                    outputFile.Write("simpleGoal, ");
                    Console.WriteLine("What is the name of your goal?");
                    outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("Give a description");
                    outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("How many points is this worth?");
                    outputInput = Console.ReadLine();
                    outputFile.WriteLine(outputInput);

                }

            }
        
    }
}

