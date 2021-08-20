﻿using Dapper;
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

            var options = new GenerationOptions
            {
                Length = 9
            };
            string invoiceID = ShortId.Generate(options);
            invoice.PurchaseDate = DateTime.Now;
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

       public List<Invoice> GetAll()
        {
            var result = DataAccess.sqlcon.Query<Invoice>(@"select * from invoice;").Distinct()
             .ToList();
            return result;
        }

        public List<Invoice> SearchByUserName(string search)
        {
            search = "%" +search +"%";
            var result = DataAccess.sqlcon.Query<Invoice>(@"select * from invoice where SelsmanUsername like @search;" , new { search}).Distinct()
             .ToList();
            return result;
        }
    }
}
