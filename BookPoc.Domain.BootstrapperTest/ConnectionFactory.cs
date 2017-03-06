namespace BookPoc.Domain.BootstrapperTest
{
    public class ConnectionFactory
    {
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

        public IConnectionContext CreateContext(bool test = false)
        {
            if (test)
                return new InMemoryConnectionContext();

            return new ConnectionContext();
        }
    }
}