using LucasTechnologyService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Document : EntityBase
    {

        public Document(long id)
        {
            Id = id;
        }
        [Required(ErrorMessage = "The {0} filed is required")]
        [StringLength(20)]
        public string Number { get; private set; }


    }
}
