using MartiFood_API.Data.Configurations;
using MartiFood_API.Data.Entities;
using MartiFood_API.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MartiFood_API.Data.EF
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Thiet lap lazyloading

            optionsBuilder.UseLazyLoadingProxies();

        }
        public virtual DbSet<Product>? Products { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<AppConfig>? AppConfigs { get; set; }
        public virtual DbSet<Cart>? Carts { get; set; }
        public virtual DbSet<CartDetail>? CartDetails { get; set; }
        public virtual DbSet<CategoryTranslation>? CategoryTranslations { get; set; }
        public virtual DbSet<ProductInCategory>? ProductInCategories { get; set; }
        public virtual DbSet<Contact>? Contacts { get; set; }
        public virtual DbSet<Language>? Languages { get; set; }
        public virtual DbSet<Order>? Orders { get; set; }
        public virtual DbSet<OrderDetail>? OrderDetails { get; set; }
        public virtual DbSet<ProductTranslation>? ProductTranslations { get; set; }
        public virtual DbSet<Promotion>? Promotions { get; set; }
        public virtual DbSet<Transaction>? Transactions { get; set; }
        public virtual DbSet<ProductImage>? ProductImages { get; set; }
        public virtual DbSet<Slide>? Slides { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var efType in modelBuilder.Model.GetEntityTypes())
            {
                var tbName = efType.GetTableName();
                if ((tbName != null) && tbName.StartsWith("AspNet"))
                {
                    efType.SetTableName(tbName.Substring(6));
                }
            }
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CartDetailConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new SlideConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();

        }

    }
}
