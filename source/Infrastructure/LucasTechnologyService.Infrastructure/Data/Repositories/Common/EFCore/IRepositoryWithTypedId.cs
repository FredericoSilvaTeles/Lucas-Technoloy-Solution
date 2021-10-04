using LucasTechnologyService.Infrastructure.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyService.Infrastructure.Data.Repositories.Common.EFCore
{
    public interface IRepositoryWithTypedId<T, TId> where T : IEntityWithTypedId<TId>
    {
        
        IQueryable<T> Query();
        
        void Add(T entity);
        
        
        void Addranger(IEnumerable<T> entity);
        IDbContextTransaction Beggintransaction();

        void SaveChanges();

        Task DavechangesAsync();

        void Remove(T entity);
    }
}
