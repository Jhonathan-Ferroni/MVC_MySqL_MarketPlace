using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(3,100, ErrorMessage = "O nome do produto deve conter entre 3 e 100 caracteres.")]
        public string Name { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser um valor positivo.")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque deve ser um valor não negativo.")]
        public string Stock { get; set; }
        [Required]
        [Range(10, 1000, ErrorMessage = "A descrição do produto deve conter entre 10 e 1000 caracteres.")]
        public string Description { get; set; }

    }
}
