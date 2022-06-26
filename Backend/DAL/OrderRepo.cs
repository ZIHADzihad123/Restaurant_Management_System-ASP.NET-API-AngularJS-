using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class OrderRepo : IOrder<Product, Cart, OrdersDetail>
    {
        BlogsEntities db;
        public OrderRepo(BlogsEntities db)
        {
            this.db = db;
        }
        public  List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        public  List<Cart> GetCart()
        {
            return db.Carts.ToList();
        }

        public List<OrdersDetail> OrdersDetails()
        {
            return db.OrdersDetails.ToList();
        }
        public List<Order> Order()
        {
            return db.Orders.ToList();
        }

        public void Addtocart(Cart dl)
        {
            var prod = dl.ProductId;
            var uprice = (from s in db.Products
                          where s.Id == prod
                          select s.UnitPrice).FirstOrDefault();
            Cart d = new Cart()
            {
                Id = dl.Id,
                ProductId = dl.ProductId,
                Quantity = dl.Quantity,
                TotalPrice = (int)(dl.Quantity * uprice),
            };
            db.Carts.Add(d);
            db.SaveChanges();
        }

        public void PlaceOrder()
        {
            var cId = 1;
            var Total = 0.0;
            var quantity = 0;
            var did = (from s in db.Carts
                       select s).ToList();
            foreach (var p in did)
            {
                Total += p.TotalPrice;

            }

            foreach (var q in did)
            {
                quantity -= q.Quantity;

            }
            //Add Order
            Order o = new Order();
            o.Price = Total;
            o.CustomerId = cId;
            o.Status = "Ordered";
            db.Orders.Add(o);
            db.SaveChanges();

            List<Cart> cart = db.Carts.ToList();
            foreach (var p in cart)
            {
                OrdersDetail d = new OrdersDetail()
                {
                    ProductId = p.ProductId,
                    OrderId = o.Id,
                    Quantity = p.Quantity,
                    UnitPrice = db.Products.FirstOrDefault(e => e.Id.Equals(p.ProductId)).UnitPrice,
                    TotalPrice = p.TotalPrice
                };
                db.OrdersDetails.Add(d);
                db.SaveChanges();
            }
            //Add New Quantity To InventoryProducts Table
            var dud = (from s in db.Carts
                       select s).ToList();
            foreach (var p in dud)
            {
                var pid = (from i in db.Products
                           where i.Id == p.ProductId
                           select i).FirstOrDefault();
                pid.Quantity += p.Quantity;
                db.Entry(pid).CurrentValues.SetValues(pid);
                db.Entry(pid).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }

            //Delete All From InventoryOrdersDetails Table
            var exist = (from s in db.Carts
                         select s).ToList();

            foreach (var p in exist)
            {
                db.Carts.Remove(db.Carts.FirstOrDefault());
                db.SaveChanges();
            }

        }

        public void DeleteCart()
        {
            var exist = (from s in db.Carts
                         select s).ToList();

            foreach (var p in exist)
            {
                db.Carts.Remove(db.Carts.FirstOrDefault());
                db.SaveChanges();
            }
        }

        public void DeleteOrderde()
        {
            var exist = (from s in db.OrdersDetails
                         select s).ToList();

            foreach (var p in exist)
            {
                db.OrdersDetails.Remove(db.OrdersDetails.FirstOrDefault());
                db.SaveChanges();
            }
        }

        public void DeleteOrder()
        {
            var exist = (from s in db.Orders
                         select s).ToList();

            foreach (var p in exist)
            {
                db.Orders.Remove(db.Orders.FirstOrDefault());
                db.SaveChanges();
            }
        }


        //public static void RecieveOrder(OrdersDetail ol)
        //{
        //    //Order Status Change In InventoryOrdersTotals Table
        //    var u = db.OrdersDetails.FirstOrDefault(en => en.Id == ol.Id);
        //    db.Entry(u).CurrentValues.SetValues(ol);
        //    db.Entry(u).State = System.Data.EntityState.Modified;
        //    db.SaveChanges();

        //    //Add New Quantity To InventoryProducts Table
        //    var did = (from s in db.InventoryOrdersDetails
        //               select s).ToList();
        //    foreach (var p in did)
        //    {
        //        var pid = (from i in db.InventoryProducts
        //                   where i.Id == p.InvProductId
        //                   select i).FirstOrDefault();
        //        pid.RemQuantity += p.Quantity;
        //        db.Entry(pid).CurrentValues.SetValues(pid);
        //        db.Entry(pid).State = System.Data.EntityState.Modified;
        //        db.SaveChanges();
        //    }

        //    //Delete All From InventoryOrdersDetails Table
        //    var exist = (from s in db.InventoryOrdersDetails
        //                 select s).ToList();

        //    foreach (var p in exist)
        //    {
        //        db.InventoryOrdersDetails.Remove(db.InventoryOrdersDetails.FirstOrDefault(e => e.Id == p.Id));
        //        db.SaveChanges();
        //    }
        //}
    }
}
