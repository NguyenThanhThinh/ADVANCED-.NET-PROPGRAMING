using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucHanh3.DTO;

namespace ThucHanh3.DAL
{
   public class AirportDAL
    {
        private DBConnection _dbconnection;
        public AirportDAL()
        {
            _dbconnection = new DBConnection();
        }

        public AirportEntity GetAirportByCode(string code)
        {
            string sql = "SELECT [code], [name], [city], [state], [country], [utc_time],[deleted], [openning] ";
            sql += " FROM airport WHERE [code]=@CODE";

            SqlDataReader dr = _dbconnection.ExecuteReader(sql, new ParameterPair[] { new ParameterPair("@CODE", code) });
            AirportEntity ae;
            if (dr.Read())
            {
                ae = new AirportEntity(dr["code"].ToString(), dr["name"].ToString(), dr["city"].ToString(),
                                    dr["state"].ToString(), dr["country"].ToString(),
                                    dr["utc_time"].ToString(), bool.Parse(dr["deleted"].ToString()),
                                    bool.Parse(dr["openning"].ToString()));

                return ae;
            }
            else
            {
                return null;
            }

        }

        public List<AirportEntity> GetAirportList()
        {

            List<AirportEntity> list = new List<AirportEntity>();

            string sql = "SELECT [code], [name], [city], [state], [country], [utc_time],[deleted], [openning] ";
            sql += " FROM airport ";

            SqlDataReader dr = _dbconnection.ExecuteReader(sql);
            AirportEntity ae;
            while (dr.Read())
            {
                ae = new AirportEntity(dr["code"].ToString(), dr["name"].ToString(), dr["city"].ToString(),
                                    dr["state"].ToString(), dr["country"].ToString(),
                                    dr["utc_time"].ToString(), bool.Parse(dr["deleted"].ToString()),
                                    bool.Parse(dr["openning"].ToString()));

                list.Add(ae);

            }

            return list;
        }

        public DataSet GetAirportDataset()
        {
            string sql = "SELECT [code], [name], [city], [state], [country], [utc_time],[deleted], [openning] ";
            sql += " FROM airport ";

            DataSet ds;
            ds = _dbconnection.GetDatasetResut(sql, "Airport");
            return ds;
        }

        public DataSet GetAirportByCountryDataset(string country)
        {
            string sql = "SELECT [code], [name], [city], [state], [country], [utc_time],[deleted], [openning] ";
            sql += " FROM airport WHERE [country]=@country";

            DataSet ds;
            ds = _dbconnection.GetDatasetResut(sql, new ParameterPair[] { new ParameterPair("@country", country) }, "Airport");
            return ds;
        }

        public DataSet GetUniqueCountryDataset()
        {
            string sql = "SELECT DISTINCT [country] FROM airport";
            DataSet ds;
            ds = _dbconnection.GetDatasetResut(sql, "Country");
            return ds;

        }

        public bool DeleteAirport(string code)
        {
            int result;
            string sql = "DELETE FROM airport WHERE [code]=@code";
            ParameterPair[] p = new ParameterPair[] { new ParameterPair("@code", code) };
            result = _dbconnection.ExecuteNonQuery(sql, p);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddNewAirport(AirportEntity ae)
        {
            int result;

            string sql = "INSERT INTO airport([code], [name], [city], [state], [country], [utc_time],[deleted], [openning]) ";
            sql += "VALUES(@code, @name, @city, @state, @country, @utc_time,@deleted, @openning)";

            ParameterPair[] p = new ParameterPair[8];

            p[0] = new ParameterPair("@code", ae.Code);
            p[1] = new ParameterPair("@name", ae.Name);
            p[2] = new ParameterPair("@city", ae.City);
            p[3] = new ParameterPair("@state", ae.State);
            p[4] = new ParameterPair("@country", ae.Country);
            p[5] = new ParameterPair("@utc_time", ae.UtcTime);
            p[6] = new ParameterPair("@deleted", ae.Deleted.ToString());
            p[7] = new ParameterPair("@openning", ae.Openning.ToString());

            result = _dbconnection.ExecuteNonQuery(sql, p);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
