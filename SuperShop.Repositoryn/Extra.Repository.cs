using SuperShop.Data;
using SuperShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Repository
{
  public class ExtraRepository
    {
        public List<SalesData> GetSellersData()
        {
        var result = DataAccess.SelectQuery<SalesData>(@"select COUNT(*) 'NoOfSales', SalesmanUsername from invoice group by SalesmanUsername");
            return result;
        }

        public List<SealsByDate> GetSealsNumberByDate()
        {
            var result = DataAccess.SelectQuery<SealsByDate>(@"Select SUM(SubTotal) 'TotalSales',PurchaseDate from invoice group by PurchaseDate;");
            return result;
        }
    }
}
