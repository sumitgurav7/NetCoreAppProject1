using System.Data.SqlClient;

namespace NetCoreAppProject1
{
    public class SqlConn
    {
        private readonly SqlConnection _con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestingLocalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public SqlConnection Con { get => _con;  }
    }
}
