using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIMVIII.Models;

public class Cliente
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo de nome não pode estar vazio")]
    [StringLength(25, ErrorMessage = "O nome deve ter menos de 25 caracteres")]
    [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo de CPF não pode estar vazio")]
    public long CPF { get; set; }

    [Required(ErrorMessage = "O campo de email não pode estar vazio")]
    [EmailAddress(ErrorMessage = "Você deve utilizar um email válido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo de senha não pode estar vazio")]
    [MinLength(6, ErrorMessage = "A senha deve ter no minimo 6 caracteres")]
    public string Senha { get; set; }

    [Required(ErrorMessage = "O campo de endereço não pode estar vazio")]
    public string Endereco { get; set; }
}
