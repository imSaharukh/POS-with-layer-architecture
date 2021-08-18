using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Entity
{
    class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }

        public float unitPrice { get; set; }

        public int stock { get; set; }
        public int categoryID { get; set; }
        public float purchasePrice { get; set; }

        public DateTime expireDate { get; set; }

        public int unit { get; set; }

        public ProductCategory productCategoryID { get; set; }
    }

    class ProductCategory
    {
        public string productCategoryName { get; set; }
        public int productCategoryID { get; set; }

        public ICollection<Product> users { get; set; }
    } 
}
