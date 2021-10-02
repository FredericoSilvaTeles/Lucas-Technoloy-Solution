using Microsoft.AspNetCore.Identity;
using MixErp.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixErp.Modules.Core.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
         public IList<UserRole> Users { get; set; } = new List<UserRole>();

        public long id => throw new NotImplementedException();
    }
}
