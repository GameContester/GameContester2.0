using System.Data.Entity;
using GameContester.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;


namespace GameContester.DataAccess
{
    public class GameContesterDBContext : IdentityDbContext<User>
    {
        public GameContesterDBContext(): base("DefaultConnection",throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }

    }
}
