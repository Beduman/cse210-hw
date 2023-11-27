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
        Console.WriteLine(_name + ": " + _description);
        Console.WriteLine("How long do you want this activity to last in seconds?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DiplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountdown(int time)
    {
        int timerUp = 0;
        while (timerUp <= time)
        {
            Thread.Sleep(1000);
            timerUp = timerUp + 1;
            Console.Write(timerUp);
            
        }
        Console.WriteLine();
    }
}