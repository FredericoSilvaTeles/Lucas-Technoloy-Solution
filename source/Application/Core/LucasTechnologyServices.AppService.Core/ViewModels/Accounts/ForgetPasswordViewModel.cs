using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.AppService.Core.ViewModels.Accounts
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
