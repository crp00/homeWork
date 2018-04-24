using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_1
{
    class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Text { get; private set; }

        public Book(string _name, string _text, Author author)
        {
            Name = _name;
            Text = _text;
            Author = author.ToString();
        }
    }
}
