namespace MixErp.Infrastructure.Models
{
    public abstract class EntityBaseWithTypedId<TId>
    {
        public virtual TId Id {get; protected set;}
        
    }
}