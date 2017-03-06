using System.Collections.Generic;
using BookPoc.Domain.Model;

namespace BookPoc.Domain.Infrastructure
{
    public interface IBookRepository
    {
        IList<Book> GelAll();

        Book FindBy(int id);

        bool Add(Book book);
    }
}