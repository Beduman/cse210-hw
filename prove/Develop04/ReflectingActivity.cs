using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    // Initialize _prompts with some prompts
    // Initialize _questions with some prompts
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity "+ 
                                       "will help you reflect on times in your "+
                                       "life when you have shown strength and "+ 
                                       "resilience. This will help you recognize "+
                                       "the power you have and how you can use "+
                                       "it in other aspects of your life.")
    {

    }
    
    // Add the run, GetRandomPrompt, GetRandomQuestion, 
    // DisplayPrompt, and DisplayQuestion functions
    public void Run()
    {
        Console.WriteLine(_name + ": " + _description);
        _duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(futureTime >= startTime)
        {
            GetRandomPrompt();
        }

    }

    public string GetRandomPrompt()
    {
        string returnPrompt = "";
        int totalCount = _prompts.Count();
        Random random = new Random();

        int wordsToHideCount = random.Next(1, totalCount);
        foreach (string i in _prompts)
        {
            int spot = _prompts.IndexOf(i);
            if (wordsToHideCount == spot)
            {   
                returnPrompt = i;
            }
        }

        return returnPrompt;
    }

}