using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThucHanh3.DAL
{
    public class DBConnection
    {
        private string _server = @"P18M13\SQLExpress";
        //private string _server = "localhost";
        private string _database = "atmsproject";
        private string _user = "sa";
        private string _password = "thanhthinhgh1";

        private SqlConnection _connection;

        private string GetTrustedConnectionString()
        {
            return String.Format("Data source = {0}; Initial Catalog = {1}; Integrated Security = True", _server, _database);
        }

        private string GetConnectionString()
        {
            return String.Format("Data Source={0};Initial Catalog = {1}; UID = {2}; PWD = {3}", _server, _database, _user, _password);
        }


        public DBConnection()
        {
            _connection = new SqlConnection(GetConnectionString());
        }

        public DBConnection(bool trustedConnection)
        {
            if (trustedConnection)
            {
                _connection = new SqlConnection(GetTrustedConnectionString());
            }
            else
            {
                _connection = new SqlConnection(GetConnectionString());
            }
        }

        public void ConnectDB()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    _connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        public void Close()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                try
                {
                    _connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Cannot close the database connection properly. " + ex.Message);
                }
            }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public SqlDataReader ExecuteReader(SqlCommand command)
        {
            SqlDataReader dr;

            command.Connection = _connection;
            dr = command.ExecuteReader();

            return dr;
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            ConnectDB();
            SqlDataReader dr;
            SqlCommand command = new SqlCommand(sql, _connection);
            dr = command.ExecuteReader();
            return dr;
        }

        public SqlDataReader ExecuteReader(string sql, ParameterPair[] param)
        {
            ConnectDB();
            SqlDataReader dr;
            SqlCommand command = new SqlCommand(sql, _connection);
            SqlParameter p;
            for (int i = 0; i < param.Length; i++)
            {
                ParameterPair pp = param[i];
                p = new SqlParameter(pp.ParameterName, pp.Value);
                command.Parameters.Add(p);
            }

            dr = command.ExecuteReader();
            return dr;
        }

        public int ExecuteScalar(SqlCommand command)
        {
            int result = 0;
            ConnectDB();
            try
            {
                command.Connection = _connection;
                result = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return 0;
            }

            return result;
        }

        public int ExecuteScalar(string sql, ParameterPair[] param)
        {
            int result = 0;
            ConnectDB();
            try
            {
                ConnectDB();
                SqlCommand command = new SqlCommand(sql, _connection);
                SqlParameter p;
                for (int i = 0; i < param.Length; i++)
                {
                    ParameterPair pp = param[i];
                    p = new SqlParameter(pp.ParameterName, pp.Value);
                    command.Parameters.Add(p);
                }

                result = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

            return result;
        }

        public int ExecuteNonQuery(string sql)
        {
            int result = 0;
            ConnectDB();
            try
            {

                SqlCommand command = new SqlCommand(sql, _connection);
                result = (int)command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return result;
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            int result = 0;
            ConnectDB();

            try
            {
                command.Connection = _connection;

                result = (int)command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

            return result;
        }

        public int ExecuteNonQuery(SqlCommand command, ParameterPair[] param)
        {
            int result = 0;
            ConnectDB();
            try
            {
                SqlParameter p;
                for (int i = 0; i < param.Length; i++)
                {
                    ParameterPair pp = param[i];
                    p = new SqlParameter(pp.ParameterName, pp.Value);
                    command.Parameters.Add(p);
                }

                result = (int)command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

            return result;
        }

        public int ExecuteNonQuery(string sql, ParameterPair[] param)
        {
            int result = 0;
            ConnectDB();

            try
            {

                SqlCommand command = new SqlCommand(sql, _connection);

                SqlParameter p;
                for (int i = 0; i < param.Length; i++)
                {
                    ParameterPair pp = param[i];
                    p = new SqlParameter(pp.ParameterName, pp.Value);
                    command.Parameters.Add(p);
                }

                result = (int)command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteNonQuery() exception: " + ex.Message);
                return 0;
            }

            return result;
        }

        public DataSet GetDatasetResut(SqlCommand command)
        {
            ConnectDB();
            DataSet ds = new DataSet();
            command.Connection = _connection;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);

            return ds;
        }

        public DataSet GetDatasetResut(SqlCommand command, string tableName)
        {
            ConnectDB();
            DataSet ds = new DataSet();
            command.Connection = _connection;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, tableName);

            return ds;
        }

        public DataSet GetDatasetResut(string sql)
        {
            ConnectDB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sql, _connection);
            da.Fill(ds);

            return ds;
        }

        public DataSet GetDatasetResut(string sql, string tableName)
        {
            ConnectDB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sql, _connection);
            da.Fill(ds, tableName);

            return ds;
        }

        public DataSet GetDatasetResut(string sql, ParameterPair[] param)
        {
            DataSet ds = new DataSet();
            ConnectDB();
            SqlCommand command = new SqlCommand(sql, _connection);
            SqlParameter p;
            for (int i = 0; i < param.Length; i++)
            {
                ParameterPair pp = param[i];
                p = new SqlParameter(pp.ParameterName, pp.Value);
                command.Parameters.Add(p);
            }

            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);

            return ds;
        }

        public DataSet GetDatasetResut(string sql, ParameterPair[] param, string tableName)
        {
            DataSet ds = new DataSet();
            ConnectDB();
            SqlCommand command = new SqlCommand(sql, _connection);
            SqlParameter p;
            for (int i = 0; i < param.Length; i++)
            {
                ParameterPair pp = param[i];
                p = new SqlParameter(pp.ParameterName, pp.Value);
                command.Parameters.Add(p);
            }

            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, tableName);

            return ds;
        }
    }
}
