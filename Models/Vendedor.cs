using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIMVIII.Models;

public class Vendedor
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo de nome fantasia não pode estar vazio.")]
    public string RazaoSocial { get; set; }

    [Required(ErrorMessage = "O campo de nome fantasia não pode estar vazio")]
    public string NomeFantasia { get; set; }

    [Required(ErrorMessage = "O campo de CNPJ não pode estar vazio")]
    [StringLength(14, ErrorMessage = "O CNPJ deve ter 14 caracteres")]
    [MinLength(14, ErrorMessage = "O CNPJ deve ter 14 caracteres")]
    public string CNPJ { get; set; }

    [Required(ErrorMessage = "O campo de email não pode estar vazio")]
    [EmailAddress(ErrorMessage = "Você deve utilizar um email válido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo de senha não pode estar vazio")]
    [MinLength(6, ErrorMessage = "A senha deve ter no minimo 6 caracteres")]
    public string Senha { get; set; }

    [Required(ErrorMessage = "O campo de comissão não pode estar vazio")]
    public decimal Comissao { get; set; }

    [Required(ErrorMessage = "O campo de endereço não pode estar vazio")]
    public string Endereco { get; set; }
}
