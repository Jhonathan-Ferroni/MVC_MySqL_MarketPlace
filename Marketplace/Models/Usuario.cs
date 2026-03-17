using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class Usuario
    {
        // 0 = Cliente/Vendedor
        // 1 = Administrador
        [Key]
        public string Id { get; set; }
        [Range(0, 1, ErrorMessage = "O tipo de usuário deve ser 0 (Cliente/Vendedor) ou 1 (Administrador).")]
        [Required(ErrorMessage = "O tipo de usuário é obrigatório.")]
        public int Type {  get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Range(3, 100, ErrorMessage = "O nome deve conter entre 3 e 100 caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email deve ser um endereço de email válido.")]
        public string email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Password { get; set; }
        public List<Produto> Products { get; set; }
    }
}
