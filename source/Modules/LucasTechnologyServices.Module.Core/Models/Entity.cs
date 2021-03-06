using LucasTechnologyService.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Entity : EntityBase
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Slug { get; private set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; private set; }

        public long EntityId { get; private set; }

        [StringLength(450)]
        public string EntityTypeId { get; private set; }

        public EntityType EntityType { get; private set; }



    }
}