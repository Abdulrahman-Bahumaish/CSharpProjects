using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.VisualBasic;
using System.Configuration;
namespace ToDoApp
{
    static class TaskManager
    {
        // Initiolization ArryList
        private static ArrayList Tasked = new ArrayList();
        
        //The Definition Of A Function Add New Task
        public static void AddTask(Tasking NewTask)
        {
            Tasked.Add(NewTask);
            Console.WriteLine("Task added: " + NewTask.Name);
        }

        //The Definition Of A Function Delete Task
        public static void DeleteTask(Tasking TaskToDelete)
        {
            if (Tasked.Contains(TaskToDelete))
            {
                Tasked.Remove(TaskToDelete);
                Console.WriteLine("Task Deleted: " + TaskToDelete.Name);
            }
            else
            {
                Console.WriteLine("Task Not Found In Task List !! ");
            }
        }

        //The Definition Of A Function To Search For The Task
        public static int SearchForTask(Tasking TaskToSearchFor)
        {
            int Index = Tasked.IndexOf(TaskToSearchFor);
            if (Index != -1)
            {
                Console.WriteLine("Task Found At Index :" + Index);
            }
            else
            {
                Console.WriteLine("Task Not Found In Task List !!");

            }
                return -1;
        }
    }
}
