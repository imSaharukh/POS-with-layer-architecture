using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using SuperShop.App;

namespace SuperShop.Data
{
    public static class DataAccess
    {
        public static IDbConnection sqlcon = new SqlConnection(DBConnectionString.dbString);

        public static List<T> SelectQuery<T>(string quary, object p = null)
        {
            var result = sqlcon.Query<T>(quary, p).ToList();
            return result;
        }

        public static int DrmQuery(string sql, object p = null)
        {
            //string sql = "INSERT INTO Customers (CustomerName) Values (@CustomerName);";
            try
            {
                var affectedRows = sqlcon.Execute(sql, p);
                return affectedRows;
            }
            catch (Exception)
            {

                return 0;
            }
            

        }

    }
}
