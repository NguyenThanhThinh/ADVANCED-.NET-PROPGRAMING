using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3.DAL
{
    public interface IDataprovider: IDisposable
    {
        void Close();
        void ConnectionDb();
        void DBConnection();
        void DBConnection(bool statusConnection);
        SqlDataReader ExecuteReader(SqlCommand sqlCommand);
        SqlDataReader ExecuteReader(string sql);
        SqlDataReader ExecuteReader(string sql, SqlParameter[] parm);
        int ExecuteScalar(SqlCommand sqlCommand);
        int ExecuteScalar(string sql, SqlParameter[] parm);
        SqlConnection GetConnection();
        string GetConnectionString();
        DataSet GetDatasetResult(SqlCommand sqlCommand);
        DataSet GetDatasetResult(SqlCommand sqlCommand,string dataTable);
        DataSet GetDatasetResult(string sql);
        DataSet GetDatasetResult(string sql, SqlParameter[] parm);
        DataSet GetDatasetResult(string sql, SqlParameter[] parm,string tableName);
        DataSet GetDatasetResult(string sql,string tableName);
        string GetTrustedConnectionString();




    }
}
