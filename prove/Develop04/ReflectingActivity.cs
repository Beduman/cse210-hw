using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    // Initialize _prompts with some prompts
    // Initialize _questions with some prompts
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", 
    "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?", 
    "What is your favorite thing about this experience?", "Have you ever done anything like this before?", 
    "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    private string _prompt;
    private string _question;

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
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(futureTime >= startTime)
        {
            _prompt = GetRandomPrompt();
            DisplayPrompt();
            startTime = DateTime.Now;
            _question = GetRandomQuestion();
            DisplayQuestion();
            startTime = DateTime.Now;
        }

    }

    string GetRandomPrompt()
    {
        string returnPrompt = "";
        int totalCount = _prompts.Count();
        Random random = new Random();

        int choose = random.Next(1, totalCount);
        foreach (string i in _prompts)
        {
            int spot = _prompts.IndexOf(i);
            if (choose == spot)
            {   
                returnPrompt = i;
            }
        }

        return returnPrompt;
    }

    string GetRandomQuestion()
    {
        string returnQuestion = "";
        int totalCount = _questions.Count();
        Random random = new Random();

        int choose = random.Next(1, totalCount);
        foreach (string i in _questions)
        {
            int spot = _questions.IndexOf(i);
            if (choose == spot)
            {   
                returnQuestion = i;
            }
        }
        return returnQuestion;
    }

    void DisplayPrompt()
    {
        Console.WriteLine(_prompt);
        ShowCountdown(6);
    }
        void DisplayQuestion()
    {
        Console.WriteLine(_question);
        ShowCountdown(7);
    }
}