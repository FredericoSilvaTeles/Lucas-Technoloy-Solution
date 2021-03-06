using LucasTechnologyService.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class EntityType : EntityBaseWithTypedId<string>
    {
        public EntityType()
        {

        }

        public EntityType(string id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get { return Id; } }

        public bool IsMenuable { get; private set; }

        [StringLength(450)]
        public string AreaName { get; private set; }

        [StringLength(450)]
        public string RoutingController { get; private set; }

        [StringLength(450)]
        public string RoutingAction { get; private set; }

    }
}