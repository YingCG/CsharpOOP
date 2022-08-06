using System;
using System.Collections.Generic;

namespace MiniLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Author = "OMA, Rem Koolhaas, Bruce Mau",
                Title = "S,M,L,XL",
                Status = Status.Available
            };

            Book book2 = new Book()
            {
                Author = "AMO, Rem Koolhaas",
                Title = "Countryside",
                Status = Status.Available
            };

            Book book3 = new Book()
            {
                Author = "Flabidou",
                Title = "Shanaga",
                Status = Status.Available
            };

            Library library = new Library(new List<Book> { book1, book2, book3 }); 

            User user1 = new User("Mandy");

            library.BorrowBook(user1, "This book does not exist");
            library.BorrowBook(user1, "S,M,L,XL");
            library.BorrowBook(user1, "Countryside");
            library.ReturnBook(user1, user1.BorrowedBooks[0]);
            library.BorrowBook(user1, "S,M,L,XL");
            library.BorrowBook(user1, "Shanaga");
            library.ReturnBook(user1);
        }
    }
}

