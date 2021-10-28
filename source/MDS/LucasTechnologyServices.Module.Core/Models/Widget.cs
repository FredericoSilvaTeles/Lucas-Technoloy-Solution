using LucasTechnologyServices.Module.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Widget : EntityBaseWithTypedId<string>
    {
        public Widget(string id)
        {
            Id = id;
            CreatedOn = DateTimeOffset.Now;
        }

        public string Code
        {
            get
            {
                return Id;
            }
        }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ViewComponentName { get; set; }

        [StringLength(100)]
        public string CreateUrl { get; set; }

        [StringLength(100)]
        public string EditUrl { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public bool IsPublished { get; set; }

    }
}
