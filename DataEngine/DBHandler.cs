using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataEngine
{
    public class DBHandler
    {
        public SqlConnection connection;
        public Exception connectException;
        public string ServerName;
        public string Database;
        public string UserName;
        public string Pwd;
        public bool DomainAuth;

        private string GetConnectionString()
        {
            if (DomainAuth)
            {
                return "server=" + ServerName + "; Integrated Security=true; database=" + Database + "; connection timeout=30";
            }
            else
            {
                return "user id=" + UserName + ";password=" + Pwd + "; server=" + ServerName + "; Trusted_Connection=false; database=" + Database + "; connection timeout=30";
            };
        }

        public bool Connect()
        {
            string connectionString = GetConnectionString();
            connection.ConnectionString = connectionString;
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                connectException = e;
                return false;
            }
            return true;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DBHandler()
        {
            connection = new SqlConnection();
        }

    }
}
