namespace Avanade.SubTCSE.Projeto.Domain.Aggregates
{
    public abstract record BaseEntity<TId>
    {
        public TId Id { get; init; }
    }
}
