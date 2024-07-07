using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.TypesOfConstructors
{
    public class Fifth
    {
        //Fields
        private string company = string.Empty;
        
        //Property
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        //Parameterized Constructor
        public Fifth(string company)
        {
            Company = company;
        }

        //Copy constructor
        public Fifth(Fifth fourth)
        {
            Company = fourth.Company;
        }

    }
}
