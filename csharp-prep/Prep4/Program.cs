using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        float total = 0;
        int guess = 1;
        int biggestnumber = 0;
        int smallestnumber = 99999;
        List<int> numberlist = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //adding numbers to list
        while (guess != 0)
        {
            Console.WriteLine("Enter a number");
            int newnumber = int.Parse(Console.ReadLine());
            guess = newnumber;
            numberlist.Add(newnumber);
        }

        // the math portion
        foreach (int i in numberlist)
        {
            total = total += i;
        }
        foreach (int i in numberlist)
        {
            if (i > biggestnumber)
            {
                biggestnumber = i;
            }
            if (i < smallestnumber)
            {
                smallestnumber = i;
            }
        }

        float average = total / numberlist.Count;

        Console.WriteLine($"Your average is {average}");
        Console.WriteLine($"Your total is {total}");
        Console.WriteLine($"Your biggest number is {biggestnumber}");
        Console.WriteLine($"Your smallest number is {smallestnumber}");
    }
}