using BookPoc.Domain.Infrastructure;
using BookPoc.Domain.Model;

namespace BookPoc.Domain.Application.BusinessUseCases
{
    public class AddAuthor
    {
        private IAuthorRepository _authorRepository;
        public AddAuthor(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public bool Add(string name)
        {
            var author = new Author(name);

            return _authorRepository.Add(author);
        }
    }
}