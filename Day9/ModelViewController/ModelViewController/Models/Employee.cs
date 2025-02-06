using System.ComponentModel.DataAnnotations;

namespace ModelViewController.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
