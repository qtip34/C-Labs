using System;
using System.Collections.Generic;


namespace lab2
{
    internal static class Program
    {
        public static void Main()
        {

            var workers = new List<Worker>();

            List<string> kk = new List<string>() { "Один", "Ни одного", "Много" };
            List<string> ss = new List<string>() { "lol", "lol", "lol" };
            workers.Add(new Manager("hhjkhjk", "hjkhjk",kk,ss));
            
            //var airPort = new AirPort(airCrafts);
            //airPort.PrintAirPort();
        }
    }
}