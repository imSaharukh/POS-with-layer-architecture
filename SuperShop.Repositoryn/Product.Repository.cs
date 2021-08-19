using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SuperShop.Data;
using SuperShop.Entity;
namespace SuperShop.Repository
{
   public class ProductRepository
    {
        public int? CreateOne(Product product)
        {
            //var role = user.userRole.RoleName;
            var ProductUnitID = DataAccess.SelectQuery<ProductUnit>("select * from productUnits where ProductUnitName = @ProductUnitName", new { product.ProductUnit.ProductUnitName })[0].ProductUnitID;


            var result = DataAccess.sqlcon.Execute(@"insert into products (productName,unitPrice,stock,productCategoryID,purchasePrice,expireDate,ProductUnitID) values (@productName,@unitPrice,@stock,@productCategoryID,@purchasePrice,@expireDate,@ProductUnitID);", new {product.productName, product.unitPrice, product.stock, product.productCategoryID,product.purchasePrice,product.expireDate, ProductUnitID });


            return result;
        }

        public List<Product> GetAll()
        {
            var result = DataAccess.sqlcon.Query<Product, ProductCategory,ProductUnit, Product>("select * from products p inner join productCategories c on p.productCategoryID = c.productCategoryID inner join productUnits u on p.ProductUnitID = u.ProductUnitID;", 
                (product, catagory,unit) => { product.productCategory = catagory;
                    product.ProductUnit = unit;
                    return product; }, splitOn: "ProductUnitID,productCategoryID").Distinct()
        .ToList();
            return result;
        }
    }
}
