﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ASSET_MANAGEMENTEntities : DbContext
    {
        public ASSET_MANAGEMENTEntities()
            : base("name=ASSET_MANAGEMENTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ASSET> ASSETs { get; set; }
        public virtual DbSet<ASSET_REQUEST> ASSET_REQUEST { get; set; }
        public virtual DbSet<ASSET_TYPE> ASSET_TYPE { get; set; }
        public virtual DbSet<ASSET_USER_RELATIONSHIP> ASSET_USER_RELATIONSHIP { get; set; }
        public virtual DbSet<HAND_OVER> HAND_OVER { get; set; }
        public virtual DbSet<REQUEST_TYPE> REQUEST_TYPE { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<USER_TYPE> USER_TYPE { get; set; }
    }
}
