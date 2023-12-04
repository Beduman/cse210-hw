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

    public void CreateGoal()
    {
        string userInput = "";
        Console.WriteLine("1. Checklist Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Simple Goal");
        userInput = Console.ReadLine();

            if(userInput == "1")
            {

            }
            else if (userInput == "2")
            {

            }
            else
            {
                string fileName = "myGoals.txt";
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.Write("simpleGoal, ");
                    Console.WriteLine("What is the name of your goal?");
                    string outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("Give a description");
                    outputInput = Console.ReadLine();
                    outputFile.Write(outputInput + ", ");
                    Console.WriteLine("How many points is this worth?");
                    outputFile.WriteLine(outputInput);

                }

            }
        
    }
}

