using System;

namespace BookPoc.Domain.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        protected Book() { }
        public Book(string name, string description, Author author)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(description))
                throw new ArgumentNullException(nameof(description));

            if (null == author)
                throw new ArgumentNullException(nameof(author));


            Name = name;
            Description = description;
            Author = author;
            AuthorId = author.Id;
        }

    }
}