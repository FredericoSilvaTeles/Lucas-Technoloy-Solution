using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Areas.ViewModels
{
    public class WidgetInstanceViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ViewComponentName { get; set; }
        public long WidgetZoneid { get; set; }
        public string Data { get; set; }
        public string HtmlData { get; set; }
        public string WidgetId { get; set; }
    }
}
