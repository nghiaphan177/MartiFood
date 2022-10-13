using MartiFood_API.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MartiFood_API.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of MartiFood" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of MartiFood" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of MartiFood" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
            });

            var hasher = new PasswordHasher<AppUser>();
            var admin = new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "phanthanhnghia127@gmail.com",
                NormalizedEmail = "phanthanhnghia127@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "0372401475",
                PhoneNumberConfirmed = true,
                SecurityStamp = string.Empty,
                FirstName = "Nghia",
                LastName = "Phan",
                DOB = new DateTime(2000, 07, 17)
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Password2@");
            modelBuilder.Entity<AppUser>().HasData(admin);
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}