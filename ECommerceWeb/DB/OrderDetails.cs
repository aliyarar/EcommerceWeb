//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerceWeb.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetails
    {
        public System.Guid Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public byte Discount { get; set; }
        public System.Guid Order_Id { get; set; }
        public int Product_Id { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
    }
}
