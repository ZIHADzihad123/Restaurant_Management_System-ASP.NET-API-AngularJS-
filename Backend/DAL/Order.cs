//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrdersDetails = new HashSet<OrdersDetail>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
