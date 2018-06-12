using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace lab2
{

    public abstract class Worker
    {
        
        protected Worker(string surname, string headSurname, List<string> subSurname)
        {
            
            ////change
            Surname = surname;
            HeadSurname = headSurname;
            SubSurname = subSurname;
            //Duties = duties;
        }
        

        public string Surname { get; set; }
        public string HeadSurname { get; set; }
        public List<string> SubSurname{ get; set; }
       // public List<string> Duties { get; set; }
        public virtual void ShowInfo() //объявление виртуального метода
        {
            Console.WriteLine("Worker\nИмя: " + Surname);
        }
    }
   
}