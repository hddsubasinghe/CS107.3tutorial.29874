using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02q1
{
    internal class Book
    {
   
            public string Title { get; set; }
            public string Author { get; set; }
        }

        class program
        {
            static void Main()
            {
               
                Book myBook = new Book();

             
                myBook.Title = "The Great Gatsby";
                myBook.Author = "F. Scott Fitzgerald";

                
                Console.WriteLine("Book Information:");
                Console.WriteLine($"Title: {myBook.Title}");
                Console.WriteLine($"Author: {myBook.Author}");

                
                Console.ReadLine();
            }
        }

    }


