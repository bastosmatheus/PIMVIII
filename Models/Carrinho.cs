using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIMVIII.Models;

public class Carrinho
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo de data do pedido não pode estar vazio.")]
    public DateTime DataPedido { get; set; }

    [Required(ErrorMessage = "O campo de valor total não pode estar vazio.")]
    public decimal ValorTotal { get; set; }

    [Required(ErrorMessage = "O campo de status do pedido não pode estar vazio.")]
    [StringLength(20, ErrorMessage = "O status deve ter no máximo 20 caracteres.")]
    [MinLength(3, ErrorMessage = "O status deve ter pelo menos 3 caracteres.")]
    public string StatusPedido { get; set; }

    public Cliente Cliente { get; set; }

    public List<Produto> Produtos { get; set; }
}
