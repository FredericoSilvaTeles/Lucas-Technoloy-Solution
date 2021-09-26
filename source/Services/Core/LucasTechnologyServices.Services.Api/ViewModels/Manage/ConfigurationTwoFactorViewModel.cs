using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LucasTechnologyServices.Services.Api.ViewModels.Manage
{
    public class ConfigurationTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        
    }
}
