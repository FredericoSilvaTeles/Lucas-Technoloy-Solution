using LucasTechnologyService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyService.Infrastructure.Localization
{
    public class Culture : EntityBaseWithTypedId<string>
    {

        public Culture(string id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100)]
        public string Name { get; private set; }
        public IList<Resource> Resources { get; private set; }
    }
}
