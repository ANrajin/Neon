#nullable disable

using System.ComponentModel.DataAnnotations.Schema;
using Neon.Web.Enums;

namespace Neon.Web.Entities
{
    public class Post : IEntity<int>
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public Category Category { get; set; }

        public  string Title { get; set; }

        public  string Slug { get; set; }

        public  string Description { get; set; }

        public  string? Image { get; set; }

        public PostStatus Status { get; set; }

        [Column(TypeName = "Date")]
        public DateTime CreatedAt { get; set; }
    }
}
