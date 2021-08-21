using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Entity
{
   public class Invoice
    {
        public string invoiceID { get; set; }
        public double SubTotal { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { set; get; }
        public string SalesmanUsername { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }

    }
    public class InvoiceItem
    {
        public int InvoiceItemsID { get; set; }
        public string invoiceID { get; set; }
        public int productID { get; set; }
        public int qty { get; set; }
        public Product Product { get; set; }
    }
}
