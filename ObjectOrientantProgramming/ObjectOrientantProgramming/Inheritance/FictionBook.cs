using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.Inheritance
{
     class FictionBook : Book
     {
        //Property
        public string Genre { get; set; } = string.Empty;

        //Paramiterized Constructor
        public FictionBook(string title, string author, double price, string description, string genre)
            :base(title, author, price, description)
        {
            Genre = genre;
        }

        //Override Method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre:{Genre}");
        }




     }
}
