using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models
{
    public class ApplicationUser : IdentityUser
    {
        // 0 = Cliente/Vendedor
        // 1 = Administrador
        [Range(0, 1, ErrorMessage = "O tipo de usuário deve ser 0 (Cliente/Vendedor) ou 1 (Administrador).")]
        [Required(ErrorMessage = "O tipo de usuário é obrigatório.")]
        public int Type { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Range(3, 100, ErrorMessage = "O nome deve conter entre 3 e 100 caracteres.")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}