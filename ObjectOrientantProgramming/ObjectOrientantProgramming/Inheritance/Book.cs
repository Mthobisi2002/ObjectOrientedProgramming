using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.Inheritance
{
    abstract class Book
    {
        //Properties
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Description { get; set; } = string.Empty;

        //Paramiterized Constructor
        public Book(string title, string author, double price, string description)
        {
            Title = title;
            Author = author;
            Price = price;
            Description = description;

        }

        //Method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Description:{Description}");
        }


    }
}
