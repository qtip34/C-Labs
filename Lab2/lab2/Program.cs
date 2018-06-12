using System;
using System.Collections.Generic;


namespace lab2
{
    internal static class Program
    {
        public static void Main()
        {

            var workers = new List<Worker>();
            List<string> subr = new List<string>() { "Один", "Ни одного", "Много" };
            List<string> duty = new List<string>() { "lol", "lol", "lol" };
            workers.Add(new Developer("Popova", "Smith",subr, duty));
            var group = new Group(workers);
            group.PrintGroup();


        }
    }
}