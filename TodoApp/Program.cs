using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeBoard welcome = new WelcomeBoard();
            Tasks task = new Tasks();
            welcome.PrintWelcome();

            do
            {   
                
                string input = Console.ReadLine();
                switch (input)
                {
                    case "-l":

                        task.ReadTasks();
                        break;

                    case "-a":
                        string inputtask = Console.ReadLine();
                        task.AddTask(inputtask);
                        break;

                    case "-r":
                        task.RemoveTask();
                        break;
                }
            } while (true);
        }
    }
}
