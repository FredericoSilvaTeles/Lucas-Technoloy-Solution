using LucasTechnologyServices.Module.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

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
        public string Number { get; set; }
    }
}
