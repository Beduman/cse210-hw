using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "With this activity, "+
                                    "you will breathe in and out for a set period of time.", 10)
    {

    }
    public void Run()
    {
        Console.WriteLine(_name + ": " + _description);
        Console.WriteLine("How long would you like to do this exercise in seconds?");
        _duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(futureTime >= startTime)
        {
            Console.WriteLine("Breath in");
            //animation
            Thread.Sleep(1000);
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("Breath out");
            //animation
            Thread.Sleep(1000);
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("2");
            Thread.Sleep(1000);
            Console.WriteLine ("1");
            Thread.Sleep(1000);

            startTime = DateTime.Now;
        }

    }

}