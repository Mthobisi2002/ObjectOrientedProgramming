using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.TypesOfConstructors
{
    public class Second
    {
        //Fields
        private string job = string.Empty;
        private string company = string.Empty;
        private string position = string.Empty;
        private int experience;

        //properties
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        //Paramiterized Constructor
        public Second(string job, string company, string position, int experience)
        {
            Job = job;
            Company = company;
            Position = position;
            Experience = experience;
        }
    }
}
