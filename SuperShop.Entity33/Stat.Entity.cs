using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Entity
{
    public class SalesData
    {
        public int NoOfSales{ get; set; }
        public string SalesmanUsername { get; set; }
    }
    public class SealsByDate
    {
        public DateTime PurchaseDate { get; set; }
        public double TotalSales { get; set; }
    }
    public class TotalSalesAmount
    {
        public double TotalSales { get; set; }
    }
}
