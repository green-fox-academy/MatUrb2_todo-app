using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
    class Task
    {
        public bool isComplete = false;
        public string name;

        public Task(string name, bool isComplete)
        {
            this.isComplete = false;
            this.name = name;
        }

        public Task(string name, string completed)
        {
            this.name = name;
            if (completed == " False")
            {
                isComplete = false;
            }
            else if (completed == " True")
            {
                isComplete = true;
            }
        }

        public Task()
        {

        }

        public override string ToString()
        {
            if (isComplete == false)
            {
                return $"[] {name}";
            } else
            {
                return $"[x] {name}";
            }
            
        }
    }


}
