using System.Data;

namespace BookPoc.Domain.Infrastructure.Base
{
    public abstract class RepositoryBase 
    {
        protected IDbConnection Db;
        protected RepositoryBase(IDbConnection conn)
        {
            Db = conn;
        }
    }
}