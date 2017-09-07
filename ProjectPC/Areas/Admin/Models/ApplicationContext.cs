using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjectPC.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base() { }

        public DbSet<Product>           Products            { get; set; }
        public DbSet<Category>          Categories          { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}