public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        List<int> numberlist = new List<int> {1,2,3,4};
        var randomVar = new Random();
        int randomNumber = randomVar.Next(numberlist.Count);
        string returnValue = "";
        if (randomNumber == 1)
        {
            returnValue = "What was your favorite part about today?";
        }

        else if (randomNumber == 2)
        {
            returnValue = "What Gospel topic has been on your mind?";
        }
        else if (randomNumber == 3)
        {
            returnValue = "How is work?";
        }
        else if (randomNumber == 4)
        {
            returnValue = "What did you do with your family?";
        }
        else 
        {
            returnValue = "What is your favorite color?";
        }

        return returnValue;
    }

}