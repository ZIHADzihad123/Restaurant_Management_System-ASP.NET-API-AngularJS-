using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        static OrderService()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Product, ProductModel>();
                cfg.CreateMap<ProductModel, Product>();
                cfg.CreateMap<OrderDetailModel, OrdersDetail>();
                cfg.CreateMap<OrdersDetail, OrderDetailModel>();
                
                cfg.CreateMap<CartModel, Cart>();
                cfg.CreateMap<Cart, CartModel>();
                
                cfg.CreateMap<Order, OrderModel>();
                cfg.CreateMap<OrderModel, Order>();
            });
        }

        public static List<ProductModel> GetAllProduct()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductModel>());
            var data = AutoMapper.Mapper.Map<List<ProductModel>>(DataAccessFactory.OrderDataAccess().GetAllProduct());
            return data;
        }

        public static List<CartModel> GetCart()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Cart, CartModel>());
            var data = AutoMapper.Mapper.Map<List<CartModel>>(DataAccessFactory.OrderDataAccess().GetCart());
            return data;
        }
        public static List<OrderModel> GetOrder()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderModel>());
            var data = AutoMapper.Mapper.Map<List<OrderModel>>(DataAccessFactory.OrderDataAccess().Order());
            return data;
        }

        public static List<OrderDetailModel> GetOrderDetailModel()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<OrdersDetail, OrderDetailModel>());
            var data = Mapper.Map<List<OrderDetailModel>>(DataAccessFactory.OrderDataAccess().OrdersDetails());
            return data;
        }

        public static void AddToCart(CartModel des)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CartModel, Cart>());
            var data = Mapper.Map<Cart>(des);
            DataAccessFactory.OrderDataAccess().Addtocart(data);
        }

        public static void PlaceOrder()
        {
            DataAccessFactory.OrderDataAccess().PlaceOrder();
        }
        public static void DeleteCart()
        {
            DataAccessFactory.OrderDataAccess().DeleteCart();
        }
        public static void DeleteOrderde()
        {
            DataAccessFactory.OrderDataAccess().DeleteOrderde();
        }
        public static void DeleteOrder()
        {
            DataAccessFactory.OrderDataAccess().DeleteOrder();
        }
    }
}
