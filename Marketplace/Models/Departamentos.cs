using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class Departamentos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
