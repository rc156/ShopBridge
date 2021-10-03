using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ShopBridge.Web.Models.DAL
{
    public class SqlHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }
    }
}