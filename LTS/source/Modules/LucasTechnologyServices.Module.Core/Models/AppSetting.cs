using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class AppSetting : EntityBaseWithTypedId<string>
    {
        public AppSetting(string id)
        {
            Id = Id;
        }

        
        [StringLength(100)]
        public string Value { get; set; }


        [StringLength(100)]
        public string Module { get; set; }

        public bool IsVisibleInCommonSettingPage { get; set; }
    }
}