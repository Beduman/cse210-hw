using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {


        Job job1 = new Job();

        job1._title = "Software Developer";
        job1._company = "Microsoft";
        job1._startdate = 2019;
        job1._enddate = 2023;

        Job job2 = new Job();
        
        job2._title = "Human Resources";
        job2._company = "Microsoft";
        job2._startdate = 2015;
        job2._enddate = 2019;

        //for testing
        Console.WriteLine(job1._title);

    }
}