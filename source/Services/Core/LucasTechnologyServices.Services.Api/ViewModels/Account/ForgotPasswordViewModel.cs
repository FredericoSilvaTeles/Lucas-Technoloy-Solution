using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Services.Api.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        
        [Required(ErrorMessage = "The {0} field is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
