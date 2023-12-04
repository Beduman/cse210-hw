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
}

