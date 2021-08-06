using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace SuperShop.Data
{
    public static class DataAccess
    {
        private static IDbConnection sqlcon = new SqlConnection(@"Server=tcp:supershop.database.windows.net,1433;Database=supershoplow;User ID=supershop;Password=Saharukh123##;Trusted_Connection=False;Encrypt=True;");

        public static List<T> SelectQuery<T>(string quary, object p = null)
        {
            var result = sqlcon.Query<T>(quary,p).ToList();
            return result;
        }

     public   static int DrmQuery(string sql,object p = null)
        {
            //string sql = "INSERT INTO Customers (CustomerName) Values (@CustomerName);";
            var affectedRows = sqlcon.Execute(sql,p);
            return affectedRows;

        }
    }
}
