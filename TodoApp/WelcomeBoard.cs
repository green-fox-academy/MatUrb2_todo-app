using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class WelcomeBoard
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Command Line Todo application\n=============================\n" +
                "Command line arguments:\n" +
                "\t -l   Lists all the tasks\n" +
                "\t -a   Adds a new task\n" +
                "\t -r   Removes an task\n" +
                "\t -c   Completes an task\n" + 
                "Please, select what would you like to do");
                
                
        }
    }
}
