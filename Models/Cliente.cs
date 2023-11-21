using System.ComponentModel.DataAnnotations;

namespace PIMVIII.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; }

    public long CPF { get; set; }

    public string Email { get; set; }

    public string Senha { get; set; }

    public string Endereco { get; set; }
}
