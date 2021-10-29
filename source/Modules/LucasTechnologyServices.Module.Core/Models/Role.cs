using LucasTechnologyService.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public IList<UserRole> Users { get; private set; }
        
    }
}