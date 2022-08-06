using System;
using System.Collections.Generic;

namespace MiniLibrary
{
    public class Library
    {
        private List<Book> bookCollection;

        public Library(List<Book> books)
        {
            bookCollection = books;
        }

        internal void BorrowBook(User borrower, string title)
        {
            if (borrower.BooksCount >= 2)
            {
                Console.WriteLine("Sorry {0}, each persone can borrow only two books in this library", borrower.Name);
                return;
            }

            Book toBorrow = null;

            foreach (var book in bookCollection)
            {
                if (book.Title == title)
                {
                    toBorrow = book;
                }
            }

            if (toBorrow != null)
            {
                Console.WriteLine("Giving the book {0} to {1}", title, borrower.Name);
                bookCollection.Remove(toBorrow);
                borrower.BorrowedBooks.Add(toBorrow);
            }
            else
            {
                Console.WriteLine("Cannot find the book called {0}", title);
            }
        }

        internal void ReturnBook(User borrower, Book returnedBook)
        {
            Console.WriteLine("Thank you {0} for returning {1}", borrower.Name, returnedBook.Title);
            borrower.BorrowedBooks.Remove(returnedBook);
            bookCollection.Add(returnedBook);
        }

        internal void ReturnBook(User borrower)
        {
            while (borrower.BorrowedBooks.Count != 0)
            {
                ReturnBook(borrower, borrower.BorrowedBooks[0]);
            }
        }
    }
}