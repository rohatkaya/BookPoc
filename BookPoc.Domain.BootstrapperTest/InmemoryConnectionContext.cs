using System.Data;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;

namespace BookPoc.Domain.BootstrapperTest
{
    public class InMemoryConnectionContext : IConnectionContext
    {
        private readonly OrmLiteConnectionFactory dbFactory =
        new OrmLiteConnectionFactory(":memory:", SqliteOrmLiteDialectProvider.Instance);
        public IDbConnection OpenConnection()
        {
           return this.dbFactory.OpenDbConnection();
        }
    }
}