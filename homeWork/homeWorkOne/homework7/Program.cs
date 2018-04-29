using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author someAuthor1 = new Author("James", "Copeland");
            Author someAuthor2 = new Author("Dan", "Brown");

            Book someBook1 = new Book("Bubblegum Thief", "aaaaa", someAuthor1);
            Book someBook2 = new Book("Origin", "bbbb", someAuthor2);

            Library someLibrary = new Library();

            someLibrary.AddBooksToCollection(someBook1);
            someLibrary.AddBooksToCollection(someBook2);

            someLibrary.ReviewBookCollection();
        }
    }
}
