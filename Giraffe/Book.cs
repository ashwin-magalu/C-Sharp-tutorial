using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book ()
        {
            Console.WriteLine("Creating a new book without parameters");
        }


        //Constructors
        public Book(string title, string author, int pages)
        {
            Console.WriteLine("Creating a new book with parameters");
            this.title = title;
            this.author = author;
            this.pages = pages;
        }
    }
}
