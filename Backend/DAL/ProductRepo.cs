using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo : IProduct<Product, int>
    {

        BlogsEntities db;
        public ProductRepo(BlogsEntities db)
        {
            this.db = db;
        }


        public void Add(Product e)
        {
            db.Products.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Products.Remove(db.Products.FirstOrDefault(e => e.Id.Equals(id)));
            db.SaveChanges();
        }

        public Product Edit(Product pml)
        {
           
            var pm = db.Products.FirstOrDefault(e => e.Id.Equals(pml.Id));
           
            db.Entry(pm).CurrentValues.SetValues(pml);
            db.Entry(pm).State = EntityState.Modified;

            db.SaveChanges();
            return pm;
        }

        public Product aEdit(Product pml)
        {

            Product pm = new Product()
            {
                Id = pml.Id,
                ProductName = pml.ProductName,
                Quantity = pml.Quantity,
                UnitPrice = pml.UnitPrice,


            };

            return pm;
        }

        public List<Product> Get()
        {
            var products = new List<Product>();     
            foreach (var p in db.Products)
            {
                Product pm = new Product()     //pm = object of product jetar maddhome protibar product ber kore amra "products" variable e add kortesi
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Quantity = p.Quantity,
                    UnitPrice = p.UnitPrice,

                };
                products.Add(pm);
            }
            return products;
        }

        public Product Get(int id)
        {
            var p = (from pr in db.Products
                     where pr.Id == id
                     select pr).FirstOrDefault();

            Product pm = new Product()
            {
                Id = p.Id,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                UnitPrice = p.UnitPrice,


            };
            return pm;
        }
    }
}
