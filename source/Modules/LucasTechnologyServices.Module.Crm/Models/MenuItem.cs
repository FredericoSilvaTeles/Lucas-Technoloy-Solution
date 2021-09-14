using LucasTechnologyService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Crm.Models
{
    public class MenuItem : EntityBase
    {
        public long? ParentId { get; private set; }
        public MenuItem Parent { get; private set; }
        
        
    }
}
