using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _231130API.Modells
{
    public class BlogPosts {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? PostName { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string? PostContent { get; set; }

        public DateTime CreatedTime { get; set; }

        public Guid UserId { get; set; }

        public BlogUser User { get; set; }
    }
}
