using System.IO; 
public class GoalManager
{

    public void Run ()
    {
        private string _fileName = "myGoals.txt";

        private string[] _lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in _lines)
            {
                string[] goalIndex = line.Split(",");

            }
    }
}

