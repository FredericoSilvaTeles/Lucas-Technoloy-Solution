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
        public string Value;


        [StringLength(100)]
        public string Module { get; private set; }

        public bool IsVisibleInCommonSettingPage { get; private set; }
    }
}