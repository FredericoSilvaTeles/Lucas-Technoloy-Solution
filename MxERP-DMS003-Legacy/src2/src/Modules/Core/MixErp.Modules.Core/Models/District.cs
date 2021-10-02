using MixErp.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixErp.Modules.Core.Models
{
    public class District : EntityBase
    {
        public District() { }
        public District(long id)
        {
            Id = Id;
        }
    
        public long StateOrProvinceId { get; set; }

        public StateOrProvince StateOrProvince { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }

        [StringLength(450)]
        public string Type { get; set; }

        public string Location { get; set; }
    
    }
            
}
