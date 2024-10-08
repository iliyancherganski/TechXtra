using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechXtra.Infrastructures.Data.Models;

namespace TechXtra.Infrastructures.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientOrder> ClientsOrders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<IndividualProduct> IndividualProducts { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductLike> ProductsLikes { get; set; }
        public DbSet<ProductShoppingCart> ProductsShoppingCarts { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<ProductLike>()
                .HasKey(pl => new { pl.ProductId, pl.ClientId });

            builder
                .Entity<ProductShoppingCart>()
                .HasKey(ps => new { ps.ProductId, ps.ClientId });

            builder
                .Entity<ProductLike>()
                .HasOne(pl => pl.Product)
                .WithMany(p => p.ProductLikes)
                .HasForeignKey(pl => pl.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .Entity<ProductLike>()
                .HasOne(pl => pl.Client)
                .WithMany(c => c.ProductLikes)
                .HasForeignKey(pl => pl.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<ProductShoppingCart>()
                .HasOne(pl => pl.Product)
                .WithMany(p => p.ProductShoppingCarts)
                .HasForeignKey(pl => pl.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .Entity<ProductShoppingCart>()
                .HasOne(pl => pl.Client)
                .WithMany(c => c.ProductShoppingCarts)
                .HasForeignKey(pl => pl.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<IndividualProduct>()
                .HasOne(ip => ip.Product)
                .WithMany(p => p.IndividualProducts)
                .HasForeignKey(ip => ip.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .Entity<IndividualProduct>()
                .HasOne(ip => ip.Store)
                .WithMany(s => s.IndividualProducts)
                .HasForeignKey(ip => ip.StoreId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<ClientOrder>()
                .HasOne(co => co.Client)
                .WithMany(c => c.ClientOrders)
                .HasForeignKey(co => co.ClientId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .Entity<ClientOrder>()
                .HasOne(co => co.IndividualProduct)
                .WithMany(ip => ip.ClientOrders)
                .HasForeignKey(co => co.IndividualProductId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }
    }
}
