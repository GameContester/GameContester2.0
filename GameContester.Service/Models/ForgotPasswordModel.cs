using System.ComponentModel.DataAnnotations;

namespace GameContester.Service.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        public string Host { get; set; }
        public string Response { get; set; }
    }
}