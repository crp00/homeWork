using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_1
{
    class Library
    {
        List<Book> BookCollection = new List<Book>();

        public void AddBooksToCollection(Book books)
        {
            BookCollection.Add(books);
        }

        public void ReviewBookCollection()
        {
            foreach (Book books in BookCollection)
            {
                Console.WriteLine(books.ToString());
            }
        }
    }
}
