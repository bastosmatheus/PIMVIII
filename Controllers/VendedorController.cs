using Microsoft.AspNetCore.Mvc;
using PIMVIII.Interfaces;
using PIMVIII.Models;

namespace PIMVIII.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VendedorController : ControllerBase
{
    private readonly IRepository<Vendedor> _vendedorRepository;

    public VendedorController(IRepository<Vendedor> vendedor)
    {
        _vendedorRepository = vendedor;
    }

    [HttpGet]
    public ActionResult<List<Vendedor>> ObterTodos()
    {
        return Ok(_vendedorRepository.ObterTodos());
    }

    [HttpGet("{id}")]
    public ActionResult<Vendedor> ObterPorId(int id)
    {
        return Ok(_vendedorRepository.ObterPorId(id));
    }

    [HttpPost]
    public ActionResult Adicionar([FromBody] Vendedor vendedor)
    {
        _vendedorRepository.Adicionar(vendedor);
        return Ok($"O vendedor foi cadastrado com sucesso.");
    }

    [HttpPut]
    public ActionResult Atualizar([FromBody] Vendedor vendedor)
    {
        _vendedorRepository.Atualizar(vendedor);
        return Ok("O vendedor foi adicionado com sucesso.");
    }

    [HttpDelete]
    public ActionResult Excluir([FromBody] Vendedor vendedor)
    {
        _vendedorRepository.Excluir(vendedor);
        return Ok("O vendedor foi excluido com sucesso.");
    }
}
