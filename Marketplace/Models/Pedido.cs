using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Data {  get; set; }
        [Required]
        public string IdComprador { get; set; }
        [Required]
        public string IdVendedor { get; set; }
        [Required]
        // Status do pedido: 0 - Pendente, 1 - Em andamento, 2 - Concluído, 3 - Cancelado
        public int status { get; set; }


    }
}
