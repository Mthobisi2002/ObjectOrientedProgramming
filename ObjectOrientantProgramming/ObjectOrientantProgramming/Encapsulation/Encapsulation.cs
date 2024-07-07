using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.Encapsulation
{
    public class Encapsulation
    {
        //Fields
        private string name = string.Empty;
        private string surname = string.Empty;
        private int age;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //Paramiterized Constructor
        public Encapsulation(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
