using GameContester.Contracts.Managers;
using GameContester.Contracts.Repositories;
using GameContester.Domain.Entities;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;

namespace GameContester.DataAccess.Repository
{
    public class UserRepository :  Repository<User,string>, IUserRepository
    {
        private readonly IUserManager userManager;

        public UserRepository(GameContesterDbContext context, IUserManager userManager)
            : base(context)
        {
            this.userManager = userManager;
        }
        
        public IdentityResult Register(User user, string password)
        {
            var result = userManager.Create(user, password);
            if (result.Succeeded)
            {
                result = userManager.AddToRole(user.Id, "user");
            }

            return result;
        }

        public User Login(string email, string password)
        {
            return userManager.Find(email, password);
        }

        public string ForgotPassword(string id)
        {
            return userManager.GeneratePasswordResetToken(id);
        }

        public IdentityResult ChangePassword(string oldPassword, string newPassword, string id)
        {
            return userManager.ChangePassword(id, oldPassword, newPassword);
        }

        public User GetUserByEmail(string email)
        {
            return userManager.FindByEmail(email);
        }

        public IdentityResult ResetPassword(string id, string code, string password)
        {
            return userManager.ResetPassword(id, code, password);
        }


        public void BanUser(string userId)
        {
            var user = Find(userId);
            user.IsBanned = true;
            Update(user);
        }

        public void UnbanUsers(List<string> userIds)
        {
            User user;
            foreach (var id in userIds)
            {
                if (id != null)
                {
                    user = Find(id);
                    user.IsBanned = false;
                    Update(user);
                }
            }
        }
    }
}
