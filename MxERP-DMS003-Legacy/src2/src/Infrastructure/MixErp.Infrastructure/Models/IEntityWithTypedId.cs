namespace MixErp.Infrastructure.Models
{
    public interface IEntityWithTypedId<TId>
    {
         TId id {get;}
    }
}