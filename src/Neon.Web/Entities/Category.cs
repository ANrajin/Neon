namespace Neon.Web.Entities
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string UrlTitle { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
