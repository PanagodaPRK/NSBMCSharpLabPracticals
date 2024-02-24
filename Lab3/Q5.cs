using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        class LibraryBook
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public bool Available { get; private set; }

            public LibraryBook(string title, string author, bool available = true)
            {
                Title = title;
                Author = author;
                Available = available;
            }

            public void BorrowBook()
            {
                if (Available)
                {
                    Available = false;
                    Console.WriteLine("Book has been borrowed.");
                }
                else
                {
                    Console.WriteLine("Book by is currently not available for borrowing.");
                }
            }
        }

        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("The Catcher in the Rye", "J.D. Salinger");
            LibraryBook book2 = new LibraryBook("Oliver Twist", "Charles Dickens");
            LibraryBook book3 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald");

            book1.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();

            Console.ReadLine();
        }
    }
}