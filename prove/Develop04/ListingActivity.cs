public class ListingActivity : Activity
{
    private int _counts;
    private List<string> _prompts = new List<string>{"List things you've done that you've enjoyed this week.", 
    "Who are people that you appreciate?", "What are personal strengths of yours?"};
    private string _prompt;

    public ListingActivity() : base("Listing Activity","In this activity you will create a list in a certain topic.")
    {

    }
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
        void DisplayPrompt()
    {
        Console.WriteLine(_prompt);
        ShowCountdown(10);
    }
}