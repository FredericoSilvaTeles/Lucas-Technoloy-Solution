using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Address : EntityBase
    {
        public Address(long id)
        {
            Id = id;
        }
        
        [StringLength(450)]
        public string ContactName { get; private set; }

        [StringLength(450)]
        public string Phone { get; private set; }

        [StringLength(450)]
        public string AddressLine1 { get; private set; }

        [StringLength(450)]
        public string AddressLine2 { get; private set; }

        [StringLength(450)]
        public string City { get; private set; }

        [StringLength(450)]
        public string ZipCode { get; private set; }

        public long? DistrictId { get; private set; }

        public District District { get; private set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public long StateOrProvinceId { get; private set; }

        public StateOrProvince StateOrProvince { get; private set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string CountryId { get; private set; }

        public Country Country { get; private set; }

    }
        
        
    
}