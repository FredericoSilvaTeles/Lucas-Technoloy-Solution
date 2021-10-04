using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace LucasTechnologyServices.Services.Api.ViewModels.Manage
{
    public class IndexViewmodel
    {
        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public string PhoneNumber { get; set; }

        public bool TwoFactor { get; set; }

        public bool BrowserRemembered { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
    }
}
