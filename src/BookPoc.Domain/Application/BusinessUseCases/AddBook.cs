using System;
using BookPoc.Domain.Application.Model.RequestModel;
using BookPoc.Domain.Infrastructure;
using BookPoc.Domain.Model;

namespace BookPoc.Domain.Application.BusinessUseCases
{
    public class AddBook
    {
        private IBookRepository _bookRepository;
        private IAuthorRepository _authorRepository;

        public AddBook(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public bool Add(AddBookRequest request)
        {
            var author = _authorRepository.FindBy(request.AuthorId);
            if (null == author)
                throw new Exception($"Author id: {request.AuthorId} is not found.");

            var book = new Book(request.Name, request.Description, author);

            return _bookRepository.Add(book);
        }
    }
}