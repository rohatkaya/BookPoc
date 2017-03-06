using System.Data;
using System.Data.SqlClient;

namespace BookPoc.Domain.Infrastructure.Base
{
    
    public class ConnectionFactory
    {
        private const string ConnectionString =
            "Data Source=.; Initial Catalog=BookDb;Integrated Security=SSPI;MultipleActiveResultSets=True";
        private static IDbConnection _connection;

        private static ConnectionFactory _instance;

        private ConnectionFactory() { }

        public static ConnectionFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnectionFactory();
                }
                return _instance;
            }
        }

        public IDbConnection GetConnection()
        {
            if (null == _connection)
                _connection = new SqlConnection(ConnectionString);

            return _connection;
        }
    }
}