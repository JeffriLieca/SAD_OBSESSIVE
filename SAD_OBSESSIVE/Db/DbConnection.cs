using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAD_OBSESSIVE.Db
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_Obsessive";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    
        
    }
}
