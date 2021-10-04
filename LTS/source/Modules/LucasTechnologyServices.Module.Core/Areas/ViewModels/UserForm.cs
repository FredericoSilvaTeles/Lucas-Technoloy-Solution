using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Areas.ViewModels
{
    public class UserForm
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        
        [Required(ErrorMessage = "The {0} field is required.")]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public IList<long> RoleIds { get; set; } = new List<long>();
        public IList<long> CustomerIds { get; set; } = new List<long>();
    }
}
