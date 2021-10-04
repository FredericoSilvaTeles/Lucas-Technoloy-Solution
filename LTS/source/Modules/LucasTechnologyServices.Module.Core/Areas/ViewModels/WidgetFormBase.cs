using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Areas.ViewModels
{
    public class WidgetFormBase
    {
        public long Id { get; set; }
        
        [Required(ErrorMessage = "The {0} field is required")]
        public string Name { get; set; }

        public long WidgetZoneid { get; set; }
        public DateTimeOffset? PublishStart { get; set; }
        public DateTimeOffset? PublishEnd { get; set; }

    }
}
