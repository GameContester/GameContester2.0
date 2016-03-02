using System.Data.Entity;
using GameContester.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GameContester.DataAccess
{
    public class GameContesterDbContext : IdentityDbContext<User>
    {
        public GameContesterDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new {r.RoleId, r.UserId});

            //modelBuilder.Entity<User>()
            //    .HasMany(x => x.Subscriptions)
            //    .WithMany(r => r.Subscribers).

        }
    }
}
