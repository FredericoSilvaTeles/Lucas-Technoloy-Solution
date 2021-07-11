using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Models
{
    public class Address : EntityBase
    {

        public Address() { }

        public Address(long id)
        {
            Id = id;
        }


        [StringLength(450)]
        public string ContactName { get; set; }

        [StringLength(450)]
        public string Phone { get; set; }

        [StringLength(450)]
        public string AddressLine1 { get; set; }

        [StringLength(450)]
        public string AddressLine2 { get; set; }
                
        public string CityId { get; set; }
        
        public City City { get; set; }

        [StringLength(450)]
        public string ZipCode { get; set; }

        public long? DistrictId { get; set; }

        public District District { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public StateOrProvince StateOrProvince { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string CountryId { get; set; }

        public Country Country { get; set; }

        

    }
}