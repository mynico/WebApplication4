﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebApplication4
{
    
    
    public partial class press2009Entities : DbContext
    {
        public press2009Entities()
            : base("name=press2009Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<extrawyken2> extrawyken2 { get; set; }
        public DbSet<persgroep> persgroep { get; set; }
        public DbSet<persgroepoverzicht> persgroepoverzicht { get; set; }
    }
}
