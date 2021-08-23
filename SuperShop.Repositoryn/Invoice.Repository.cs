using Dapper;
using shortid;
using shortid.Configuration;
using SuperShop.Data;
using SuperShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Repository
{
  public  class InvoiceRepository
    {
        public int? CreateOne(Invoice invoice) {

            //var invoiceID = Guid.NewGuid().ToString();

      
            invoice.PurchaseDate = DateTime.Now;
            foreach (var item in invoice.InvoiceItems)
            {
                //decrease stock
                DataAccess.DrmQuery("UPDATE products SET stock = stock - @qty WHERE productId = @productId",
                    new { item.productID ,item.qty });


                DataAccess.DrmQuery(@"insert into invoiceItems (invoiceID,productID,qty) 
                values (@invoiceID,@productID,@qty);", 
                new { invoice.invoiceID, item.productID,item.qty });
            }

            var PurchaseDate = invoice.PurchaseDate.ToShortDateString();
            var result = DataAccess.sqlcon.Execute(@"insert into invoice (invoiceID,SubTotal,TotalPrice,Discount,SalesmanUsername,PurchaseDate) 
                values 
               (@invoiceID,@SubTotal,@TotalPrice,@Discount,@SalesmanUsername,@PurchaseDate);",
                new {
                    invoice.  invoiceID,  invoice.SubTotal,invoice.TotalPrice,invoice.Discount,invoice.SalesmanUsername,
                    PurchaseDate
                });


            return result;


        }
        public List<Invoice> GetByUsernameAndDateRange(string username,string DateForm , string DateTo)
        {
            var sql = @"select * from invoice 
            where SalesmanUsername = @username and (PurchaseDate <= @DateTo AND PurchaseDate >= @DateForm) ORDER BY PurchaseDate desc;";

            if (username == "All")
            {
                sql = @"select * from invoice 
            where (PurchaseDate <= @DateTo AND PurchaseDate >= @DateForm) ORDER BY PurchaseDate desc;";

            }
            var result = DataAccess.sqlcon.Query<Invoice>(sql, new { username , DateTo , DateForm }).Distinct()
             .ToList();
            return result;
        }
        public List<Invoice> GetAll(string username =null)
        {
            var sql = "";
            
            Console.WriteLine(username);
            if (username == null)
            {
                sql = "select * from invoice ORDER BY PurchaseDate desc"; 
            }
            else
            {
                sql = "select * from invoice  where SalesmanUsername = '" +
                   username +
               "' ORDER BY PurchaseDate desc;";
            }
            Console.WriteLine(sql);
            var result = DataAccess.sqlcon.Query<Invoice>(sql).Distinct()
             .ToList();

            Console.WriteLine("GetAll --> " +result.Count);
            return result;
        }

        public List<Invoice> SearchByUserName(string search)
        {
           
            var result = DataAccess.sqlcon.Query<Invoice>(@"select * from invoice where SalesmanUsername = @search;", new { search}).Distinct()
             .ToList();

            Console.WriteLine("SearchByUserName --> " + result.Count);
            return result;
        }

        public List<InvoiceProduct> GetAllInvoiceProduct(string invoice)
        {
            var result = DataAccess.sqlcon.Query<InvoiceProduct>("select * from invoiceItems i join products p on i.productID = p.productID where invoiceID = @invoice;" , new { invoice}).Distinct()
        .ToList();
            return result;
        }

        public object GetByUsernameAndDateRangeAndInvoice(string invoiceID,string username, string DateForm, string DateTo)
        {
            invoiceID = "%" + invoiceID + "%";
            var sql = @"select * from invoice 
            where SalesmanUsername = @username and (PurchaseDate <= @DateTo AND PurchaseDate >= @DateForm) and invoiceID like @invoiceID  ORDER BY PurchaseDate desc;";

            if (username == "All")
            {
                sql = @"select * from invoice 
            where (PurchaseDate <= @DateTo AND PurchaseDate >= @DateForm) and invoiceID like @invoiceID ORDER BY PurchaseDate desc;";

            }
            Console.WriteLine(sql);
            var result = DataAccess.sqlcon.Query<Invoice>(sql, new { invoiceID, username, DateTo, DateForm }).Distinct()
             .ToList();
            return result;
        }
    }
}
