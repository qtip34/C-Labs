using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace lab2
{
    public class Manager : Worker
    {
        public Manager(string surname, string headSurname, List<string> subSurname, List<string> duties) : base(surname, headSurname, subSurname)
        {
            Duties = duties;
        }

        public List<string> Duties { get; set; }
   
    }
}