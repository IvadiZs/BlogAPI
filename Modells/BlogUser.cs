using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _231130API.Modells {
    public class BlogUser {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? UserName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? UserEmail { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Password { get; set;}

        public DateTime CreatedTime { get; set; }
    }
}
