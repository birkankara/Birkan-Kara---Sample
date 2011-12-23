using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyProductList.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }

    public class MyDatabaseInitializer :
        DropCreateDatabaseIfModelChanges<ProductContext>
    //CreateDatabaseIfNotExists<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>{
            new Product { Name = "Prod 01" },
            new Product { Name = "Prod 02" },
            new Product { Name = "Prod 03" },
            new Product { Name = "Prod 04" },
            new Product { Name = "Prod 05" },
            new Product { Name = "Prod 06" },
            new Product { Name = "Prod 07" },
            new Product { Name = "Prod 08" },
            new Product { Name = "Prod 09" },
            new Product { Name = "Prod 10" }
            };

            products.ForEach(Product => context.Products.Add(Product));
            context.SaveChanges();


        }
    }

}