using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Services.Api.ViewModels.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Nome")]
        public string FullName { get; set; }
    }
}
