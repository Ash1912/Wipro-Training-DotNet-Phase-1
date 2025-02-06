using System.ComponentModel.DataAnnotations;

namespace Day9Assignment1.Models
{
    public class AccountViewModel
    {
        [Required]
        public required string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
