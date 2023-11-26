public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }
    public Activity(string name, string desc)
    {
        _name = name;
        _description = desc;
    }
    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _description = desc;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {

    }

    public void DiplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountdown()
    {

    }
}