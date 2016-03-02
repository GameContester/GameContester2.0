using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using GameContester.DataAccess.Repository;
using GameContester.Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using GameContester.DataAccess.Managers;

namespace GameContester.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<GameContesterDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(GameContesterDbContext context)
        {
            SeedGameContester(context);
        }
        private void SeedGameContester(GameContesterDbContext context)
        {


            User user = new User();
            CreateRole("Admin", context);
            CreateRole("User", context);
            AddInitialAdmin("admin@admin.com", "admin", "admin", "Qwerty1#", context);

        }

        private void CreateRole(string roleName, GameContesterDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var role = new IdentityRole();
            if (!roleManager.RoleExists(roleName))
            {
                role = new IdentityRole();
                role.Name = roleName;
                roleManager.Create(role);
            }
        }

        private void AddInitialAdmin(string email, string firstname, string lastname, string password, GameContesterDbContext context)
        {
            var userManager = new UserManager(context);
            var admin = new User { Email = email, UserName = email, Role = "Admin", FirstName = firstname, SecondName = lastname };
            if (userManager.FindByEmail(email) == null)
            {
                userManager.Create(admin, password);
                userManager.AddToRole(admin.Id, "Admin");
            }
        }

        
        private User AddUser(int index, GameContesterDbContext context)
        {
            var userManager = new UserManager(context);
            User user = new User
            {
                FirstName = "John-" + index,
                SecondName = "Doe-" + index,
                Email = "Username-" + index + "@GameContester.com",
                EmailConfirmed = true,
                UserName = "Username-" + index + "@GameContester.com",
                About =
                    @"I'm just a test user. My whole life story:\nLorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. ",
                PasswordHash = "AEPu4Rln+Qak4i79daRuRlcAe70OQ+uvYDJreFYyoudb0iWaorIkAV/crymPqTpV6w==", //1234qwerQ_
                SecurityStamp = "b56fd8f5-0dac-4360-9def-175f9dab8aaf",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                IsBanned = index%2==0,
                AccessFailedCount = 0
            };

            user = context.Users.Add(user);
            context.SaveChanges();
            user.Role = "User";
            userManager.AddToRole(user.Id, "User");
            return user;
        }
    }
}
