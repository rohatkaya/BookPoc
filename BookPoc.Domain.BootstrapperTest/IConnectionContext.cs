using System.Data;

namespace BookPoc.Domain.BootstrapperTest
{
    public interface IConnectionContext
    {
        IDbConnection OpenConnection();
    }
}