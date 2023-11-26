public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity "+ 
                                       "will help you reflect on times in your "+
                                       "life when you have shown strength and "+ 
                                       "resilience. This will help you recognize "+
                                       "the power you have and how you can use "+
                                       "it in other aspects of your life.")
    {
        _duration = 50;
          // Initialize _prompts with some prompts
          // Initialize _questions with some prompts
    }
    // Add the run, GetRandomPrompt, GetRandomQuestion, 
    // DisplayPrompt, and DisplayQuestion functions
}