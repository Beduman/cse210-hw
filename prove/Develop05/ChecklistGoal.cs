public class ChecklistGoal
{
    int _amountCompleted;
    int _target;
    int _bonus;
    public void RecordEvent()
    {
        Console.WriteLine("Please record your goal");
        string fileName = "myGoals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string outputInput = Console.ReadLine();
            outputFile.WriteLine(outputInput);
        }
        Console.WriteLine("How many times can you complete this goal?");
    }
    public bool IsComplete()
    {
        bool completed;
        if (_amountCompleted >= _target)
        {
            completed = true;
        }
        else
        {
            completed = false;
        }
    
        return completed;
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}