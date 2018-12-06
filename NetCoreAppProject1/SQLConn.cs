using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NetCoreAppProject1
{
    public class SQLConn
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestingLocalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public SqlConnection Con { get => con;  }
    }
}
