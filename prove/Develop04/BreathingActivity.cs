using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "With this activity, "+
                                    "you will breathe in and out for a set period of time.", 10)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(futureTime >= startTime)
        {
            Console.WriteLine("Breath in");
            //animation
            ShowCountdown(5);
            startTime = DateTime.Now;
            Console.WriteLine("Breath out");
            //animation
            ShowCountdown(5);

            startTime = DateTime.Now;
        }

    }

}