using System.Data;
using System.Data.SqlClient;
using BookPoc.Domain.Infrastructure.Base;

namespace BookPoc.Domain.BootstrapperTest
{
    public  class ConnectionContext : IConnectionContext
    {
        private const string ConnectionString =
            "Data Source=.; Initial Catalog=BookDb;Integrated Security=SSPI;MultipleActiveResultSets=True";
        private  IDbConnection _connection;

        public IDbConnection OpenConnection()
        {
            if (null == _connection)
                _connection = new SqlConnection(ConnectionString);

            return _connection;
        }
    }
}