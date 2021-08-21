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
        public List<SalesData> GetSalesData()
        {
        var result =    DataAccess.SelectQuery<SalesData>(@"select COUNT(*) 'NoOfSales', SalesmanUsername from invoice group by SalesmanUsername");
            return result;
        }
    }
}
