using BookPoc.Domain.Application.BusinessUseCases;
using BookPoc.Domain.Application.Queries;

namespace BookPoc.Domain.Application
{
    public class BookAppService
    {
        public AddBook AddBook { get; set; }
        public AddAuthor AddAuthor { get; set; }
        public FindBook FindBook { get; set; }
        public GetAllAuthors GetAllAuthors { get; set; }
        public GetAllBooks GetAllBooks { get; set; }

        public BookAppService(AddBook addBook,AddAuthor addAuthor ,FindBook findBook, GetAllAuthors getAllAuthors, GetAllBooks getAllBooks)
        {
            AddBook = addBook;
            AddAuthor = addAuthor;
            FindBook = findBook;
            GetAllAuthors = getAllAuthors;
            GetAllBooks = getAllBooks;
        }
    }
}