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
        public List<SalesData> GetSellersData(string DateForm, string DateTo)
        {
        var result = DataAccess.SelectQuery<SalesData>(@"select COUNT(*) 'NoOfSales', SalesmanUsername from invoice  where (PurchaseDate <= @DateTo AND PurchaseDate >= @DateForm)  group by SalesmanUsername", new { DateForm , DateTo });
            return result;
        }

        public List<SealsByDate> GetSealsNumberByDate(string DateForm, string DateTo)
        {
            var result = DataAccess.SelectQuery<SealsByDate>(@"Select SUM(SubTotal) 'TotalSales',PurchaseDate from invoice where (PurchaseDate <= @DateTo AND PurchaseDate >= @DateForm) group by PurchaseDate;", new { DateForm, DateTo });
            return result;
        }
        public double GetSalesAmountByDate(string DateForm, string DateTo)
        {
            var result = DataAccess.SelectQuery<TotalSalesAmount>(@"Select SUM(SubTotal) 'TotalSales' from invoice where (PurchaseDate <= @DateTo AND PurchaseDate >= @DateForm);", new { DateForm, DateTo });
            return result[0].TotalSales;
        }


    }
}
