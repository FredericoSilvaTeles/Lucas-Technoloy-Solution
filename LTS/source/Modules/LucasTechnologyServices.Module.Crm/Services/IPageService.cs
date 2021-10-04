using LucasTechnologyServices.Module.Crm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Crm.Services
{
    public interface IPageService
    {
        Task Create(Page page);
        Task Update(Page page);
        Task Delete(Page page);
    }
}
