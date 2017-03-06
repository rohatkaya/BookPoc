using System.Collections.Generic;
using System.Data;
using System.Linq;
using BookPoc.Domain.Infrastructure.Base;
using BookPoc.Domain.Infrastructure.Base.Extensions;
using BookPoc.Domain.Model;
using Dapper;

namespace BookPoc.Domain.Infrastructure
{
    public class AuthorRepository : RepositoryBase, IAuthorRepository
    {
        public AuthorRepository(IDbConnection conn) : base(conn)
        {
        }

        public Author FindBy(int id)
        {
            string sql = @"Select * From Author Where Id=@Id;
                            Select * From Book Where AuthorId IN (Select Id From Author Where Id=@Id);";

            
            var mapped = Db.QueryMultiple(sql,new {Id = id})
            .Map<Author, Book, int>(
            author => author.Id,
            book => book.AuthorId,
            (author, books) => { author.Books = books; }
            );
            return mapped.SingleOrDefault();
        }

        public IList<Author> GelAll()
        {
            string sql = @"Select * From Author
                            Select * From Book Where AuthorId IN (Select Id From Author)";


            var mapped = Db.QueryMultiple(sql)
            .Map<Author, Book, int>(
            author => author.Id,
            book => book.AuthorId,
            (author, books) => { author.Books = books; }
            );
            return mapped.ToList();
        }

        public bool Add(Author author)
        {
            string sql = @"Insert INTO [Author]([Name]) values (@Name)";

            int rowsAffected = Db.Execute(sql, new { Name = author.Name });
            return rowsAffected > 0;
        }
    }
}