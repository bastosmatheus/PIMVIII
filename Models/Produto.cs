using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIMVIII.Models;

public class Produto
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo de descrição não pode estar vazio")]
    [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
    [MinLength(5, ErrorMessage = "A descrição deve ter pelo menos 5 caracteres")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Defina um preço")]
    [Range(1, 1000, ErrorMessage = "O preço deve estar no range de 5~1000R$")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "O campo de imagem não pode estar vazio")]
    [Url(ErrorMessage = "É permitido apenas URL's no campo de imagem")]
    public string Imagem { get; set; }

    [Required(ErrorMessage = "O campo de status não pode estar vazio")]
    [StringLength(20, ErrorMessage = "O status deve ter no máximo 20 caracteres")]
    [MinLength(3, ErrorMessage = "O status deve ter pelo menos 3 caracteres")]
    public string Status { get; set; }

    [Required]
    public Vendedor Vendedor { get; set; }

    [Required(ErrorMessage = "Defina uma categoria para o produto")]
    [StringLength(50, ErrorMessage = "A categoria não pode ultrapassar 50 caracteres")]
    [MinLength(2, ErrorMessage = "O status deve ter pelo menos 2 caracteres")]
    public string Categoria { get; set; }
}
