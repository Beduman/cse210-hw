using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Job
{
    public string _title;
    public string _company;
    public int _startdate;
    public int _enddate;
    public void Display()
    {
        Console.WriteLine($"{_title} , ({_company}) {_startdate}-{_enddate}");
    }
    }
