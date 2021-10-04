using LucasTechnologyService.Infrastructure.Data;
using LucasTechnologyService.Infrastructure.Models;
using LucasTechnologyServices.Module.Core.Data.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Data.Common
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
        where T : class, IEntityWithTypedId<long>
    {
        public Repository(LTS1DbCbContext context) : base(context)
        {
        }
    }
}
