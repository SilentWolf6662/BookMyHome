namespace BookMyHome.Domain
{
    public abstract class AggregateRoot
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
    }
}