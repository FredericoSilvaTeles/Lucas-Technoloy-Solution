using LucasTechnologyServices.Module.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class AppSetting : EntityBase
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
