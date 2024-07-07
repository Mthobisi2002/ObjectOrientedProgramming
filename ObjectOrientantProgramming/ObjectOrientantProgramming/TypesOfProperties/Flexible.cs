using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.TypesOfProperties
{
    internal class Flexible
    {
        //Fields
        private int _age;
        private string _name = string.Empty;
        private string _surname = string.Empty;

        //Read and Write Property
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                    _age = value;
                else
                    Console.WriteLine("age can't be negative");
            }
        }

        //Write-Only Property
        public string Name
        {
            set { _name = value; }
        }

        //Read-Only Property
        public string Surname
        {
            get { return _surname; }
        }
    }
}
