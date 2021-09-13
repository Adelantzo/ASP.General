namespace Adel.Asp.General.Domain.Entities
{
    public class Entity: IEntity
    {
        
    }

    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; }

        public Entity(TKey id)
        {
            Id = id;
        }

        public Entity()
        {
            Id = GenerateId();
        }

        public abstract TKey GenerateId();
    }
}