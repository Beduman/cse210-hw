using System.IO; 

public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;


    Goal(string name, string description, string points)
    {

    }

    virtual public void RecordEvent()
    {
        Console.WriteLine("Please record your goal");
        string fileName = "myGoals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string outputInput = Console.ReadLine();
            outputFile.WriteLine(outputInput);
        }
    }
    public bool IsComplete()
    {
        bool example = false;

        return example;
    }
    public string GetDetailsString()
    {
        return "";
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}