using LucasTechnologyService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyService.Infrastructure.Localization
{
    public class LocalizedContentProperty : EntityBase
    {
        public long EntityId { get; private set; }

        [StringLength(40)]
        public string Entitytype { get; private set; }

        [Required]
        public string CultureId { get; private set; }
        
        public Culture Culture { get; private set; }

        [Required]
        [StringLength(450)]
        public string PropertyName { get; private set; }
        public string Value { get; private set; }
    }
}
