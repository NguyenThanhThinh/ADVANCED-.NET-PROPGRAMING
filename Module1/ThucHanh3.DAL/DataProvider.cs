using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3.DAL
{
    public class Dataprovider:IDataprovider
    {
        private SqlConnection _connection;
        private string _database= "atmsproject";
        private string _password;
        private string _server= @".\SQLExpress";
        private string _user;
        private static bool blnSecurity=false;
    
        public void Close()
        {
            _connection.Close();
        }

        public void ConnectionDb()
        {
            string connection;
            if (blnSecurity == false)
            {
                connection = "Server" + _server + ";Database=" + _database + ";Initial Catalog =" + blnSecurity.ToString() + ";UID=" + _user + ";PWD=" + _password;
                _connection = new SqlConnection(connection);
                _connection.Open();
            }
            else
            {
                connection = "Server" + _server + ";Database=" + _database + ";Initial Catalog =" + blnSecurity.ToString();
                _connection = new SqlConnection(connection);
                _connection.Open();
            }
         

        }

        public void DBConnection()
        {
            throw new NotImplementedException();
        }

        public void DBConnection(bool statusConnection)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader ExecuteReader(SqlCommand sqlCommand)
        {
            throw new NotImplementedException();
        }
        
        public SqlDataReader ExecuteReader(string sql, SqlParameter[] parm)
        {
            throw new NotImplementedException();
        }

        public int ExecuteScalar(SqlCommand sqlCommand)
        {
            throw new NotImplementedException();
        }

        public int ExecuteScalar(string sql, SqlParameter[] parm)
        {
            throw new NotImplementedException();
        }

        public SqlConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        public string GetConnectionString()
        {
            throw new NotImplementedException();
        }

        public DataSet GetDatasetResult(string sql)
        {
            throw new NotImplementedException();
        }

        public DataSet GetDatasetResult(SqlCommand sqlCommand)
        {
            throw new NotImplementedException();
        }

        public DataSet GetDatasetResult(string sql, string tableName)
        {
            throw new NotImplementedException();
        }

        public DataSet GetDatasetResult(string sql, SqlParameter[] parm)
        {
            throw new NotImplementedException();
        }

        public DataSet GetDatasetResult(SqlCommand sqlCommand, string dataTable)
        {
            throw new NotImplementedException();
        }

        public DataSet GetDatasetResult(string sql, SqlParameter[] parm, string tableName)
        {
            throw new NotImplementedException();
        }

        public string GetTrustedConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}
