using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Neon.Web.Models.AccountModels
{
    public class SigninModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
    }
}
