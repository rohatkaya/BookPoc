using System.Collections.Generic;
using BookPoc.Domain.Model;

namespace BookPoc.Domain.Infrastructure
{
    public interface IAuthorRepository
    {
        Author FindBy(int id);

        IList<Author> GelAll();
        bool Add(Author author);
    }
}