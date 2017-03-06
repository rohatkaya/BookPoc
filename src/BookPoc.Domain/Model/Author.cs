using System;
using System.Collections.Generic;

namespace BookPoc.Domain.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Book> Books { get; set; }

        protected Author() { }

        public Author(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }
    }
}