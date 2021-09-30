using System;

namespace todo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks task = new Tasks();

            if (args.Length == 0)
            {
                task.ShowInfo();
                Console.ReadLine();
            }
            else
            {
                if (args[0] == "-l" || args[0] == "-a" || args[0] == "-r" || args[0] == "-c")
                {
                    switch (args[0])
                    {
                        case "-l":
                            task.ShowList();
                            break;

                        case "-a":
                            if (args.Length < 2)
                            {
                                Console.WriteLine("Unable to add: no task provided");
                                Console.ReadLine();
                            }
                            else
                            {
                                task.AddTask(args[1]);
                            }
                            break;

                        case "-r":
                            if (args.Length < 2)
                            {
                                Console.WriteLine("Unable to remove: no index provided");
                            }
                            else if (int.TryParse(args[1], out int result))
                            {
                                if (task.TaskListCount() >= result && result > 0)
                                {
                                    task.DeleteTask(result);
                                }
                                else
                                {
                                    Console.WriteLine("Unable to remove: index is out of bound");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Unable to remove: index is not a number");
                            }
                            break;



                        case "-c":
                            if (args.Length < 2)
                            {
                                Console.WriteLine("Unable to remove: no index provided");
                            }
                            else if (int.TryParse(args[1], out int result))
                            {
                                if (task.TaskListCount() >= result && result > 0)
                                {
                                    task.CompleteTheTask(result);
                                }
                                else
                                {
                                    Console.WriteLine("Unable to remove: index is out of bound");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Unable to remove: index is not a number");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unsupported argument");
                }
            }
            Console.ReadLine();
        }
    }
}
