using System.ComponentModel.DataAnnotations;

namespace GameContester.Service.Models
{
    public class ProfileViewModel
    {
        [Required]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string About { get; set; }

        public string Picture { get; set; }

        public bool IsBanned { get; set; }
    }
}