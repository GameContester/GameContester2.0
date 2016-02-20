using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GameContester.Domain.Entities
{
   public class User: IdentityUser, IEntity<string>
    {
        public User() { Id = Guid.NewGuid().ToString(); }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Picture { get; set; }
        public string About { get; set; }
        public string Role { get; set; }
        public bool IsBanned { get; set; }
    }
}
