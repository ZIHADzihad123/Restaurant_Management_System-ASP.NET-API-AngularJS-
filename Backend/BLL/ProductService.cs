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
    public class ProductService
    {
        static ProductService()
        {
            Mapper.Initialize(cfg => {
                
                cfg.CreateMap<ProductModel, Product>();
                cfg.CreateMap<Product, ProductModel>();
            });
        }
        public static List<ProductModel> Get()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductModel>());
            //AutoMapper.Mapper
            var data = Mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().Get());
            return data;
        }
        public static ProductModel Get(int id)
        {

            var data = Mapper.Map<ProductModel>(DataAccessFactory.ProductDataAccess().Get(id)); // for automapper 6.1.1
            return data;
        }
        public static void Create(ProductModel token)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ProductModel, Product>());
            var data = Mapper.Map<Product>(token); // for automapper 6.1.1
            DataAccessFactory.ProductDataAccess().Add(data);

        }
        public static ProductModel Edit(ProductModel pml)
        {

            var data = Mapper.Map<Product>(pml);
            var dat = Mapper.Map<ProductModel>(DataAccessFactory.ProductDataAccess().Edit(data));
            return dat;
            //ProductModel pm = new ProductModel
            //{
            //    Id = pml.Id,
            //    ProductName = pml.ProductName,
            //    Quantity = pml.Quantity,
            //    UnitPrice = pml.UnitPrice,
            //    TotalPrice = pml.Quantity * pml.UnitPrice

            //};
            //return pm;

        }
        public static ProductModel aEdit(ProductModel pml)
        {

            var data = Mapper.Map<Product>(pml);
            var dat = Mapper.Map<ProductModel>(DataAccessFactory.ProductDataAccess().aEdit(data));
            return dat;


        }
        public static void Delete(int id)
        {
            DataAccessFactory.ProductDataAccess().Delete(id);
        }

    }
}
