using MvcApplication1.Migrations;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcApplication1.Context
{
    public class Entities : DbContext
    {
        public Entities()
            : base("CodeFirstMigration")
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Standard> Standard { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Entities, Configuration>());
        }
    }
}