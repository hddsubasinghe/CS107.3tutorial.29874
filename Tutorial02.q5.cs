using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titorial02q5
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Available = true;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, book '{Title}' by {Author} is currently not available.");
            }
        }
    }

    class LibrarySystem
    {
        static void Main()
        {
           
            LibraryBook book1 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald");
            LibraryBook book2 = new LibraryBook("To Kill a Mockingbird", "Harper Lee");
            LibraryBook book3 = new LibraryBook("1984", "George Orwell");

            
            DisplayLibraryStatus(book1, book2, book3);

            
            book1.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();

            
            DisplayLibraryStatus(book1, book2, book3);
        }

        static void DisplayLibraryStatus(params LibraryBook[] books)
        {
            Console.WriteLine("\nLibrary Status:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} - Available: {book.Available}");
            }
            Console.WriteLine();
        }
    }
    
}
