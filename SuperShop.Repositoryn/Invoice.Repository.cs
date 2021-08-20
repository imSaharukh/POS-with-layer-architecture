using Dapper;
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

            //var ProductUnitID = DataAccess.SelectQuery<ProductUnit>("select * from productUnits where ProductUnitName = @ProductUnitName",
            //new { product.ProductUnit.ProductUnitName })[0].ProductUnitID;

            //var productCategoryID = DataAccess.SelectQuery<ProductCategory>("select * from productCategories where " +
            //    "productCategoryName = @productCategoryName", new { product.productCategory.productCategoryName })[0].productCategoryID;
            var invoiceID = Guid.NewGuid().ToString();

            foreach (var item in invoice.InvoiceItems)
            {
                DataAccess.DrmQuery(@"insert into invoiceItems (invoiceID,productID,qty) 
                values (@invoiceID,@productID,@qty);", 
                new { invoiceID, item.productID,item.qty });
            }

            var PurchaseDate = invoice.PurchaseDate.ToShortDateString();
            var result = DataAccess.sqlcon.Execute(@"insert into invoice (invoiceID,SubTotal,TotalPrice,Discount,SalesmanUsername,PurchaseDate) 
                values 
               (@invoiceID,@SubTotal,@TotalPrice,@Discount,@SalesmanUsername,@PurchaseDate);",
                new {
                    invoiceID,  invoice.SubTotal,invoice.TotalPrice,invoice.Discount,invoice.SalesmanUsername,
                    PurchaseDate
                });


            return result;


        }
    }
}
