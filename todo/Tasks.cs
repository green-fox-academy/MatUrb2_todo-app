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
        public bool isComplete = false;
        int args;



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
        public void ShowList()
        {
            FunctionListToTask();

            if (FunctionListToTask().Count == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < FunctionListToTask().Count; i++)
                {
                    if (i == args)
                    {
                        Console.WriteLine(i + 1 + " - " + FunctionListToTask()[i]);
                    }
                    else
                    {
                        Console.WriteLine(i + 1 + " - " + FunctionListToTask()[i]);
                    }
                }

            }
        }


        public void AddTask(string args)
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));
            listOfTasks.Add(args + " - False");
            File.WriteAllLines(path, listOfTasks);

        }

        public void DeleteTask(int args)
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));

            listOfTasks.RemoveAt(args - 1);
            File.WriteAllLines(path, listOfTasks);
        }

        public int TaskListCount()
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));
            int result = listOfTasks.Count();
            return result;
        }

        public void CompleteTheTask(int args)
        {

            var list = FunctionListToTask();
            if (list[args - 1].isComplete == false)
            {
                list[args - 1].isComplete = true;
            }
            else
            {
                list[args - 1].isComplete = false;
            }
            FromTaskListToString(list);


        }




        public List<Task> FunctionListToTask()
        {
            List<string> listOfString = new List<string>(File.ReadAllLines(path));
            List<Task> listOfTasks = new List<Task>();

            for (int i = 0; i < listOfString.Count; i++)
            {
                var splited = listOfString[i].Split('-');

                listOfTasks.Add(new Task(splited[0], splited[1]));
            }
            return listOfTasks;
        }


        public void FromTaskListToString(List<Task> list)
        {

            List<string> listOfString = new List<string>();
            foreach (var item in list)
            {
                listOfString.Add($"{item.name} - {item.isComplete}");
            }
            File.WriteAllLines(path, listOfString);

        }

    }
}
