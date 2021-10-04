using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class StateOrProvince : EntityBase
    {
        public string CountryId { get; private set; }
        public Country Country { get; private set; }
        
        [StringLength(20)]
        public string Code { get; private set; }
        
        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100)]
        public string Name { get; private set; }

        
        [StringLength(20)]
        public string Type { get; private set; }

    }
}