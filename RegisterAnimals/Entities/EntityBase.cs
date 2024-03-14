namespace RegisterAnimals.Entities
{
    public class EntityBase : IEntity
    {
        public Guid Id { get; set; }
        public string Name {get; set;}
    }
}