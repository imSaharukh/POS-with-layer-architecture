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


        public int? CreateOneProductCatagory(string catagoryName)
        {

            var r = DataAccess.SelectQuery<ProductCategory>(@"select * from productCategories where 
            productCategoryName  = @catagoryName;", new { catagoryName });

            if (r.Count > 0)
            {
                return -1;
            }

            var result = DataAccess.DrmQuery("insert into productCategories (productCategoryName) values (@catagoryName);", new { catagoryName });

            return result;

        }
        public int? CreateOne(Product product)
        {
            //var role = user.userRole.RoleName;
            var ProductUnitID = DataAccess.SelectQuery<ProductUnit>("select * from productUnits where ProductUnitName = @ProductUnitName", 
                new { product.ProductUnit.ProductUnitName })[0].ProductUnitID;

            var productCategoryID = DataAccess.SelectQuery<ProductCategory>("select * from productCategories where " +
                "productCategoryName = @productCategoryName", new { product.productCategory.productCategoryName })[0].productCategoryID;
            var result = DataAccess.sqlcon.Execute(@"insert into products (productName,unitPrice,stock,productCategoryID,purchasePrice,
                expireDate,ProductUnitID) values (@productName,@unitPrice,@stock,@productCategoryID,@purchasePrice,@expireDate,@ProductUnitID);",
                new {product.productName, product.unitPrice, product.stock, productCategoryID,product.purchasePrice,product.expireDate, ProductUnitID });


            return result;
        }

        public List<Product> GetAll()
        {
            var result = DataAccess.sqlcon.Query<Product, ProductCategory,ProductUnit, Product>("select * from products p inner join " +
                "productCategories c on p.productCategoryID = c.productCategoryID inner join productUnits u on p.ProductUnitID = u.ProductUnitID;", 
                (product, catagory,unit) => { product.productCategory = catagory;
                    product.ProductUnit = unit;
                    return product; }, splitOn: "ProductUnitID,productCategoryID").Distinct()
        .ToList();
            return result;
        }
        public List<ProductCategory> GellAllProductCatagory()
        {
            var result = DataAccess.SelectQuery<ProductCategory>("select * from productCategories");

            return result;
        }
        public List<ProductUnit> GellAllProductUnits()
        {
            var result = DataAccess.SelectQuery<ProductUnit>("select * from productUnits");

            return result;
        }


        public int? UpdateOne(Product product)
        {
            Console.WriteLine("productID " + product.productID);
            //var role = user.userRole.RoleName;
            //var id = DataAccess.SelectQuery<UserRole>("select * from userRoles where RoleName = @role", new { role })[0].roleID;
            //@productName,@unitPrice,@stock,@productCategoryID,@purchasePrice,@expireDate,@ProductUnitID
            var ProductUnitID = DataAccess.SelectQuery<ProductUnit>("select * from productUnits where ProductUnitName = @ProductUnitName", 
                new { product.ProductUnit.ProductUnitName })[0].ProductUnitID;
            var productCategoryID = DataAccess.SelectQuery<ProductCategory>("select * from productCategories where " +
                          "productCategoryName = @productCategoryName", new { product.productCategory.productCategoryName })[0].productCategoryID;

            Console.WriteLine(productCategoryID);
            var result = DataAccess.sqlcon.Execute(@"update products set productName = @productName,unitPrice = 
                        @unitPrice,stock = @stock,productCategoryID = @productCategoryID,purchasePrice = @purchasePrice,
                        expireDate = @expireDate,
                        ProductUnitID = @ProductUnitID  where productID = @productID;",
                        new { product.productName, product.unitPrice, product.stock,  product.purchasePrice, 
                        product.expireDate,product.productID, productCategoryID, ProductUnitID }); 



             return result;


        }
        public int  deleteOne(int productid)
        {
            var result = DataAccess.DrmQuery("delete from products where productID = @productid;",new {productid });

            return result;
        }
    
        public List<Product> SearchByProductname(string search)
        {
            search = "%" + search + "%";
            var result = DataAccess.sqlcon.Query<Product, ProductCategory, ProductUnit, Product>(@"select * from products p inner join 
                  productCategories c on p.productCategoryID = c.productCategoryID inner join productUnits u on p.ProductUnitID = u.ProductUnitID where productName like @search;",
                    (product, catagory, unit) => {
                        product.productCategory = catagory;
                        product.ProductUnit = unit;
                        return product;
                    },new { search }, splitOn: "ProductUnitID,productCategoryID").Distinct()
            .ToList();

            return result;
        }
           


    }
}
