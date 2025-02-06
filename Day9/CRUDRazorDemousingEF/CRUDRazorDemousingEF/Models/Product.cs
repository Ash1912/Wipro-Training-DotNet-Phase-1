using System.ComponentModel.DataAnnotations;

namespace CRUDRazorDemousingEF.Models
{
    public class Product
    {
        [Key]
        public int ProId { get; set; }
        public string? ProName { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
    }
}
