using System;
using System.Collections.Generic;


namespace lab2
{
    internal static class Program
    {
        public static void Main()
        {

            var workers = new List<Worker>();
            List<string> subr = new List<string>() { "Mary", "David"};
            List<string> subr1 = new List<string>() { "Anton" };
            List<string> duty = new List<string>() { "FirstDuty", "SecondDuty" };
            List<string> duty1 = new List<string>() { "AnotherDuty", "OneDuty" };
            workers.Add(new Developer("Popova", "Smith",subr, duty));
            workers.Add(new Manager("Kirichyk", "Lays", subr1, duty1));
            workers.Add(new Coder("Vaschyk", "Andrew", subr1, duty));
            var group = new Group(workers);
            group.PrintGroup();
            Console.WriteLine("/n finding:/n");
            group.FindViaSurname("Popova");


        }
    }
}