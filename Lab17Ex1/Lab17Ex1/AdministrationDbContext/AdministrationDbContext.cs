using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17Ex1.AdministrationDbContext
{
    internal class AdministrationDbContext : DbContext
    {
        private const string DbUrl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ionut\source\repos\Lab17Ex1\Lab17Ex1\ProductDb.mdf;Integrated Security=True";
        public DbSet<Product> Products { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public AdministrationDbContext()
        {
            Database.EnsureCreated();
        }
        override void Onconfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(DbUrl);
        }
    }
}
