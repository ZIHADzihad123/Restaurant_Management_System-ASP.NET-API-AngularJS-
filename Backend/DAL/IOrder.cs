using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IOrder<T1,T2,T3>
    {
        List<T1> GetAllProduct();
        List<T2> GetCart();
        List<T3> OrdersDetails();
        List<Order> Order();
        void Addtocart(T2 dl);
        void PlaceOrder();
        void DeleteCart();
        void DeleteOrderde();
        void DeleteOrder();



    }
}
