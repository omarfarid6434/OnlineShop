using Microsoft.EntityFrameworkCore;
using OnlineShop.Model;

namespace OnlineShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderMain> OrderMain { get; set; }
        public DbSet<OrderSub> OrderSubOrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.Items)
                .HasForeignKey(ci => ci.CartId);

            modelBuilder.Entity<OrderSub>()
                .HasOne(oi => oi.OrderMain)
                .WithMany(o => o.Items)
                .HasForeignKey(oi => oi.OrderId);
        }
    }
}
