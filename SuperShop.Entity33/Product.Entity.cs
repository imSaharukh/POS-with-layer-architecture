using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Entity
{
  public  class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int productCategoryID { get; set; }
        public double unitPrice { get; set; }

        public int stock { get; set; }
        public int categoryID { get; set; }
        public double purchasePrice { get; set; }

        public DateTime expireDate { get; set; }

        public ProductUnit ProductUnit { get; set; }

        public ProductCategory productCategory { get; set; }
    }

    public class ProductCategory
    {
        public string productCategoryName { get; set; }
        public int productCategoryID { get; set; }

        public ICollection<Product> users { get; set; }

        public override string ToString()
        {
            return this.productCategoryName;
        }
    }


    public class ProductUnit
    {
        public string ProductUnitName { get; set; }
        public int ProductUnitID { get; set; }

        public ICollection<Product> users { get; set; }

        public override string ToString()
        {
            return this.ProductUnitName;
        }
    }


    public class InvoiceProduct : Product
    {
     public int qty { get; set; }


    }
}
