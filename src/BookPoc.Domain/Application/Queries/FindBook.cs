using BookPoc.Domain.Infrastructure;
using BookPoc.Domain.Model;

namespace BookPoc.Domain.Application.Queries
{
    public class FindBook
    {
        private IBookRepository _bookRepository;

        public FindBook(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book FindById(int id)
        {
            return _bookRepository.FindBy(id);
        }
    }
}