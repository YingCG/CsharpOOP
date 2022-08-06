using System.Collections.Generic;

namespace MiniLibrary
{
    internal class User
    {
        public int Id { get; }
        public string Name { get; set; }
        public IList<Book> BorrowedBooks { get; }
        public int BooksCount
        {
            get { return BorrowedBooks.Count; }
        }

        private static int miniLibraryIdSeed = 20220806;

        public User(string name)
        {
            this.Name = name;
            this.Id = miniLibraryIdSeed;
            miniLibraryIdSeed++;
            BorrowedBooks = new List<Book>();
        }

    }
}