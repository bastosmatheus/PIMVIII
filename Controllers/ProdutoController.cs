using Microsoft.AspNetCore.Mvc;
using PIMVIII.Interfaces;
using PIMVIII.Models;

namespace PIMVIII.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IRepository<Produto> _produtoRepository;

    public ProdutoController(IRepository<Produto> produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet]
    public ActionResult<List<Produto>> ObterTodos()
    {
        return Ok(_produtoRepository.ObterTodos());
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> ObterPorId([FromRoute] int id)
    {
        return Ok(_produtoRepository.ObterPorId(id));
    }

    [HttpPost]
    public ActionResult Adicionar([FromBody] Produto produto)
    {
        _produtoRepository.Adicionar(produto);
        return Ok("O produto foi adicionado com sucesso.");
    }

    [HttpPut]
    public ActionResult Atualizar([FromBody] Produto produto)
    {
        _produtoRepository.Atualizar(produto);
        return Ok("O produto foi atualizado com sucesso.");
    }

    [HttpDelete]
    public ActionResult Excluir([FromBody] Produto produto)
    {
        _produtoRepository.Excluir(produto);
        return Ok("O produto foi removido com sucesso.");
    }
}
