using System;
using System.Data;
using System.Data.SqlClient;

namespace BloggerDotNet.Data
{
    public abstract class DbBase
    {
        public static string ConnectionString => 
            @"Data Source=.\SQLEXPRESS;Initial Catalog=BloggerDotNet;Integrated Security=True;MultipleActiveResultSets=True"; //TODO: Get from config

        protected SqlConnection _connection;
        protected SqlConnection connection => _connection ?? (_connection = GetOpenConnection());

        public static SqlConnection GetOpenConnection(bool mars = false)
        {
            var cs = ConnectionString;
            if (mars)
            {
                var scsb = new SqlConnectionStringBuilder(cs)
                {
                    MultipleActiveResultSets = true
                };
                cs = scsb.ConnectionString;
            }
            var connection = new SqlConnection(cs);
            connection.Open();
            return connection;
        }

        public SqlConnection GetClosedConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            if (conn.State != ConnectionState.Closed) throw new InvalidOperationException("should be closed!");
            return conn;
        }
    }
}
