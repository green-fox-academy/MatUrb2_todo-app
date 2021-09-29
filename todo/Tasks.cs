using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
    class Tasks
    {
        private string path = @"C:\Users\urban\OneDrive\Plocha\greenfox\MatUrb2_todo-app\todo\MyFile.txt";

        public void ShowList()
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));

            if (listOfTasks.Count == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < listOfTasks.Count; i++)
                {
                    Console.WriteLine(i + 1 + " - " + listOfTasks[i]);
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Command Line Todo application\n=============================\n" +
                "Command line arguments:\n" +
                "\t -l   Lists all the tasks\n" +
                "\t -a   Adds a new task\n" +
                "\t -r   Removes an task\n" +
                "\t -c   Completes an task\n");
            Console.ReadLine();
        }

        public void AddTask(string args)
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));
            listOfTasks.Add(args);
            File.WriteAllLines(path, listOfTasks);

        }

        public void DeleteTask(int args) 
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));
            
            listOfTasks.RemoveAt( args - 1);
            File.WriteAllLines(path, listOfTasks);
        }

        public int TaskListCount()
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));
            int result = listOfTasks.Count();
            return result;
        }

        
    }
}
