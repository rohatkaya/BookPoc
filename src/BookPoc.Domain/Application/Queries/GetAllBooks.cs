using System.Collections.Generic;
using BookPoc.Domain.Infrastructure;
using BookPoc.Domain.Model;

namespace BookPoc.Domain.Application.Queries
{
    public class GetAllBooks
    {
        private IBookRepository _bookRepository;

        public GetAllBooks(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IList<Book> GetAll()
        {
            return _bookRepository.GelAll();
        }
    }
}