﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbModelContainer : DbContext
    {
        public DbModelContainer()
            : base("name=DbModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Index> Indices { get; set; }
        public virtual DbSet<TrackedFolder> TrackedFolders { get; set; }
        public virtual DbSet<TrackedFile> TrackedFiles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SearchJob> SearchJobs { get; set; }
    }
}
