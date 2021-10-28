using LucasTechnologyServices.Module.Infrastructure.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Country : EntityBase
    {
        public Country(long id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsBillingEnabled { get; set; }

        public bool IsShippingEnabled { get; set; }

        public bool IsCityEnabled { get; set; }


        public bool ZipCodeEnabled { get; set; }

        public bool IsDistrictEnabled { get; set; }

        public IList<StateOrProvince> StateOrProvinces { get; set; }
    }
}
