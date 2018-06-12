using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Developer : Worker
    {
        public Developer(string surname, string headSurname, List<string> subSurname, List<string> duties) : base(surname, headSurname, subSurname)
        {
            Duties = duties;
        }
        public List<string> Duties { get; set; }
    }
}
