using System.ComponentModel.DataAnnotations;

namespace CodingAssignment1.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>(); // One-to-Many Relationship
    }
}
