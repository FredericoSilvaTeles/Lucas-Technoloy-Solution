namespace LucasTechnologyServices.Module.Infrastructure.Models
{
    public abstract class EntityBaseWithTypedId<TID> : ValidatableObject, IEntityWithTypedId<TID>
    {
        public virtual TID Id { get; protected set; }
    }
}
