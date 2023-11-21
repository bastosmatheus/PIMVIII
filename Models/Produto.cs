using System.ComponentModel.DataAnnotations;

namespace PIMVIII.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }

    public string Descricao { get; set; }

    public decimal Preco { get; set; }

    public string Imagem { get; set; }

    public string Status { get; set; }

    public Vendedor Vendedor { get; set; }

    public string Categoria { get; set; }
}
