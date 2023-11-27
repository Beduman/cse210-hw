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

        Console.WriteLine("How long would you like to do this exercise in seconds?");
        _duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(futureTime >= startTime)
        {
            Console.WriteLine("Breath in");
            //animation
            ShowCountdown();
            Console.WriteLine("Breath out");
            //animation
            ShowCountdown();

            startTime = DateTime.Now;
        }

    }

}