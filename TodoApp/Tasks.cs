using System;
using System.Collections.Generic;
using System.IO;


namespace TodoApp
{
    class Tasks
    {

        private string path = @"C:\Users\urban\OneDrive\Plocha\greenfox\MatUrb2_todo-app\TodoApp\TaskFile.txt";


        public Tasks()
        {

        }
        public void AddTask(string input)
        {

            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));
            try
            {

                listOfTasks.Add(input);
                File.WriteAllLines(path, listOfTasks);




            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write into file: TaskFile.txt");
            }
        }

        public void ReadTasks()
        {
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));

            if (listOfTasks.Count ==0 )
            {
                Console.WriteLine("No more todos for today :) ");
            }
            else
            {
                try
                {
                    for (int i = 0; i < listOfTasks.Count; i++)
                    {
                        Console.WriteLine( i+1+" - "+listOfTasks[i]);
                    }
                        
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to readfile: TaskFile.txt");
                }

            }
            
        }

        public void RemoveTask()
        {
            Console.WriteLine("What task would you like to remove?");
            int input = Convert.ToInt32(Console.ReadLine());
            List<string> listOfTasks = new List<string>(File.ReadAllLines(path));

            listOfTasks.RemoveAt(input-1);
            File.WriteAllLines(path, listOfTasks);


        }









    }
}
