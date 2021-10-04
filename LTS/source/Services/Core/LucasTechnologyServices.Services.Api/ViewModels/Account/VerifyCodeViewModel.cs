using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Services.Api.ViewModels.Account
{
    public class VerifyCodeViewModel
    {
        
        [Required(ErrorMessage = "The {0} field is required")]
        public string Provider { get; set; }
        
        [Required(ErrorMessage = "The {0} field is required")]
        public string Cide { get; set; }
        
        
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser")]
        public bool RememberBrowser { get; set; }
        
        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
