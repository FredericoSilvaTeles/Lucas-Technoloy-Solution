using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class District : EntityBase
    {
        
        public District(long id)
        {
            Id = id;
        }
        
        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100)]
        public string Name { get; private set; }
        
        [StringLength(50)]
        public string Type { get; private set; }
        public string Location { get; private set; }
        

    }
}