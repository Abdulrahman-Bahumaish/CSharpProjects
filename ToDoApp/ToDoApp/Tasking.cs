using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToDoApp
{
    internal class Tasking
    {
        public string Name { get; set; }
        public void PrintTask()
        {
            Console.WriteLine("Task: " + Name);
        }
    }
}
