using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Time_framework.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Time_framework.Migrations.Configuration>());
            
        }

        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public DbSet<AppUsersModel> AppUsersModel { get; set; }
        public DbSet<CommentModel> CommentModel { get; set; }
        public DbSet<CongVietSubModel> CongVietSubModel { get; set; }
        public DbSet<CongViecModel> CongViecModel { get; set; }

        public DbSet<DuAnModel> DuAnModel { get; set; }
        public DbSet<FileDinhKemModel> FileDinhKemModel { get; set; }
        public DbSet<LichModel> LichModel { get; set; }
        public DbSet<LichSuModel> LichSuModel { get; set; }

        public DbSet<PhongBanModel> PhongBanModel { get; set; }
        public DbSet<TrangThaiModel> TrangThaiModel { get; set; }

        public DbSet<CongviecInCongviecsub> CongviecInCongviecsub { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
    }
}