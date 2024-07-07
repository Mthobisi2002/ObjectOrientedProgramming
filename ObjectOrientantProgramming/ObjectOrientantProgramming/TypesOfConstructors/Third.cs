using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.TypesOfConstructors
{
    public class Third
    {
        //Fields
        private string job = string.Empty;

        //properties
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        //Private Constructor
        private Third(string job)
        {
            Job = job;
        }

        //How to make it available outside the class
        public static Third CreateThird(String job)
        {
            return new Third(job);
        }
    }
}
