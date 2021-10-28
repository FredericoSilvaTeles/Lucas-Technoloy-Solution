using LucasTechnologyServices.Module.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class StateOrProvince : EntityBase
    {
        public string CountryId { get; set; }
        public Country Country { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100)]
        public string Name { get; set; }


        [StringLength(20)]
        public string Type { get; set; }

    }
}
