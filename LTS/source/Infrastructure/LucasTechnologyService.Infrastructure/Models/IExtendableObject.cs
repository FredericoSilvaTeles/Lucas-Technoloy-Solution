using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyService.Infrastructure.Models
{
    public interface IExtendableObject
    {
        string ExtensionData { get; set; }
                
    }
}
