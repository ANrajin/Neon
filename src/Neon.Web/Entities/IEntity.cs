namespace Neon.Web.Entities
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }
}
