using BEL;
using BLL;
using DemoApp.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace DemoApp.Controllers
{

    [EnableCors("*", "*", "*")]
    public class ProductController : ApiController
    {

        [Route("api/products")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ProductService.Get());
        }
        [Route("api/products/{id}")]
        [HttpGet]
        public HttpResponseMessage ProductById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, ProductService.Get(id));
        }
        [Route("api/products/create")]
        [HttpPost]
        public HttpResponseMessage Create(ProductModel user)
        {
            ProductService.Create(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/products/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(ProductModel user)
        {
            ProductService.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/products/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            ProductService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }


        [Route("api/products/allproduct")]
        [HttpGet]
        public HttpResponseMessage GetAllProduct()
        {
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.GetAllProduct());
        }

        [Route("api/products/cart")]
        [HttpGet]
        public HttpResponseMessage GetCart()
        {
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.GetCart());
        }

        [Route("api/products/orderdetails")]
        [HttpGet]
        public HttpResponseMessage GetOderDetails()
        
        {
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.GetOrderDetailModel());
        }

        [Route("api/products/order")]
        [HttpGet]
        public HttpResponseMessage GetOder()
        {
            return Request.CreateResponse(HttpStatusCode.OK, OrderService.GetOrder());
        }

        [Route("api/products/addtocart")]
        [HttpPost]
        public HttpResponseMessage GetAddToCart(CartModel det)
        {
            OrderService.AddToCart(det);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/products/orderplace")]
        [HttpGet]
        public HttpResponseMessage GetPlaceOrder()
        {
             OrderService.PlaceOrder();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/products/deletecart")]
        [HttpGet]
        public HttpResponseMessage Delcart()
        {
            OrderService.DeleteCart();
            return Request.CreateResponse(HttpStatusCode.OK);
        }


        [Route("api/products/deleteorderde")]
        [HttpGet]
        public HttpResponseMessage Delorderde()
        {
            OrderService.DeleteOrderde();
            return Request.CreateResponse(HttpStatusCode.OK);
        }


        [Route("api/products/deleteorder")]
        [HttpGet]
        public HttpResponseMessage Delorder()
        {
            OrderService.DeleteOrder();
            return Request.CreateResponse(HttpStatusCode.OK);
        }


    }

}
