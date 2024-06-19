using Microsoft.EntityFrameworkCore;
using ShopAppGFive.DAL.Entities;

namespace Shop.DAL.Context
{
    public class ShopContext : DbContext
    {
        public DbSet<ConcreteCategory> Categories { get; set; }
        public DbSet<ConcreteCustomer> Customers { get; set; }
        public DbSet<ConcreteEmployee> Employees { get; set; }
        public DbSet<ConcreteOrderDetail> OrderDetails { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar clave primaria para ConcreteCategory
            modelBuilder.Entity<ConcreteCategory>()
                .HasKey(c => c.categoryid);

            // Configurar clave primaria para ConcreteCustomer
            modelBuilder.Entity<ConcreteCustomer>()
                .HasKey(c => c.custid);

            // Configurar clave primaria para ConcreteEmployee
            modelBuilder.Entity<ConcreteEmployee>()
                .HasKey(e => e.empid);

            // Configurar clave primaria para ConcreteOrderDetail
            modelBuilder.Entity<ConcreteOrderDetail>()
                .HasKey(o => o.orderid);

            // Configuración adicional, si es necesaria
        }
    }
}
