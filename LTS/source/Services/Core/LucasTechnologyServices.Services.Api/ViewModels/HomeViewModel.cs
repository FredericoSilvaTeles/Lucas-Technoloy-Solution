using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Services.Api.ViewModels
{
    public class HomeViewModel
    {
        public IList<WidgetInstanceViewModel> WidgetInstances { get; set; } = new List<WidgetInstanceViewModel>();
    }
}
