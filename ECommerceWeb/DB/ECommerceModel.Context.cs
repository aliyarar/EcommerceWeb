﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ECommerceEntities : DbContext
    {
        public ECommerceEntities()
            : base("name=ECommerceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MessageReplies> MessageReplies { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
    }
}