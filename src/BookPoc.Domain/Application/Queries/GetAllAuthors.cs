using System.Collections.Generic;
using BookPoc.Domain.Infrastructure;
using BookPoc.Domain.Model;

namespace BookPoc.Domain.Application.Queries
{
    public class GetAllAuthors
    {
        private IAuthorRepository _authorRepository;

        public GetAllAuthors(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public IList<Author> GetAll()
        {
            return _authorRepository.GelAll();
        }
    }
}