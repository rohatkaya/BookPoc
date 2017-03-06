using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BookPoc.Domain.Infrastructure.Base;
using BookPoc.Domain.Model;
using Dapper;

namespace BookPoc.Domain.Infrastructure
{
    public class BookRepository : RepositoryBase ,IBookRepository
    {
        public BookRepository(IDbConnection conn) : base(conn)
        {
        }

        public IList<Book> GelAll()
        {
            string sql = @"Select *
                            From Book b
                            inner Join Author a on a.Id = b.AuthorId";

            return Db.Query<Book, Author, Book>(sql, (book, author) => { book.Author = author; return book; }).ToList();

        }

        public Book FindBy(int id)
        {
            string sql = @"Select *
                            From Book b
                            inner Join Author a on a.Id = b.AuthorId
                            Where b.Id = @Id";

            return Db.Query<Book,Author, Book>(sql, (book, author) => { book.Author = author; return book; }, new {Id = id}).SingleOrDefault();

            //return new Book() {Id = 1, Name = "Test", AuthorId = 1, Description = "Test test"};
            //throw new System.NotImplementedException();
        }

        public bool Add(Book book)
        {
            string sql = @"Insert Book([Name],[Description],[AuthorId]) 
                                values (@Name,@Description,@AuthorId)";

            int rowsAffected = Db.Execute(sql, new { Name = book.Name, Description = book.Description, AuthorId = book.AuthorId });

            return rowsAffected > 0;
        }
    }
}