using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
