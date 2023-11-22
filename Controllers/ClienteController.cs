using Microsoft.AspNetCore.Mvc;
using PIMVIII.Interfaces;
using PIMVIII.Models;

namespace PIMVIII.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IRepository<Cliente> _clienteRepository;

    public ClienteController(IRepository<Cliente> cliente)
    {
        _clienteRepository = cliente;
    }

    [HttpGet]
    public ActionResult<List<Cliente>> ObterTodos()
    {
        return Ok(_clienteRepository.ObterTodos());
    }

    [HttpGet("{id}")]
    public ActionResult<Cliente> ObterPorId([FromRoute] int id)
    {
        return Ok(_clienteRepository.ObterPorId(id));
    }

    [HttpPost]
    public ActionResult Adicionar([FromBody] Cliente cliente)
    {
        _clienteRepository.Adicionar(cliente);
        return Ok($"O cliente foi cadastrado com sucesso.");
    }

    [HttpPut]
    public ActionResult Atualizar([FromBody] Cliente cliente)
    {
        _clienteRepository.Atualizar(cliente);
        return Ok("O cliente foi atualizado com sucesso.");
    }

    [HttpDelete]
    public ActionResult Excluir([FromBody] Cliente cliente)
    {
        _clienteRepository.Excluir(cliente);
        return Ok("O cliente foi removido com sucesso.");
    }
}
