using LucasTechnologyServices.Module.Infrastructure.Models;


namespace LucasTechnologyServices.Module.Infrastructure.Data
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long> where T : IEntityWithTypedId<long>
    {
    }
}
