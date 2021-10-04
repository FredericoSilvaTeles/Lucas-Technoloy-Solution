using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Events
{
    public class EntityDeleting : INotification
    {
        public long Entityid { get; set; }
    }
}
