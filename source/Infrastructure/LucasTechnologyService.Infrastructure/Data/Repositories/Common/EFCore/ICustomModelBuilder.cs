using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyService.Infrastructure.Data.Repositories.Common.EFCore
{
    public interface ICustomModelBuilder
    {
        void build(ICustomModelBuilder modelBuilder);
    }
}
