using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace lab2
{
    public class Group
    {
        private List<Worker> Workers;
        public Group(List<Worker> workers)
        {
            Workers = workers;
        }
        public Group AddWorker(Worker worker)
        {
            Workers.Add(worker);
            return this;
        }
        public Group RemoveWorker(Worker worker)
        {
            Workers.Remove(worker);
            return this;
        }
        public void PrintGroup()
        {
            var str = JsonConvert.SerializeObject(Workers);
            Console.Write(str);
        }
    }
}
