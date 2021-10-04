using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Services._1_Interfaces
{
    public interface IEntityService
    {
        string ToSafeSlug(string slug, long entityId, string entityTypeId);
        
        IEntityService Get(long entityId, string entitytypeId);
        
        void Add(string name, string slug, long entityId, string entityTypeId);
        
        void Update(string newName, string newSlug, long entityid, string entityTypeId);
        
        void Remove(long entityId, string entityTypeId);
    }
}
