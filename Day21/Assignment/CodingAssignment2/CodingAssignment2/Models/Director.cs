using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingAssignment2.Models
{
    public class Director
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
