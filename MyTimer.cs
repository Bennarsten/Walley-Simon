using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

public class MyTimer
{
    DateTime start;
    DateTime current;
    TimeSpan timeSpan;
    TimeSpan limit = TimeSpan.FromMinutes(60);


    public MyTimer(DateTime startTime) {
        this.start = startTime;
    }  

    public void Current(DateTime date)
    {
        this.current = date;
        timeSpan = current - start;
        if (timeSpan > limit)
        {
            Console.WriteLine("tidsskillnad: " +timeSpan);
            start = current;
        }
    }    
        
    public Boolean withinLastHour() {
        Console.WriteLine("timespan: " + timeSpan);
        if (timeSpan < limit)
        {
            Console.WriteLine("Within last hour - true");
            return true;
        }
        else
            Console.WriteLine("Within last hour - false");
        return false;
    }
}

