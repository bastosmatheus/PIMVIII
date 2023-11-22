using Microsoft.AspNetCore.Mvc;
using PIMVIII.Interfaces;
using PIMVIII.Models;

namespace PIMVIII.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarrinhoController : ControllerBase
{
    private readonly IRepository<Carrinho> _carrinhoRepository;

    public CarrinhoController(IRepository<Carrinho> carrinho)
    {
        _carrinhoRepository = carrinho;
    }
    
    [HttpGet]
    public ActionResult<List<Carrinho>> ObterTodos()
    {
        return Ok(_carrinhoRepository.ObterTodos());
    }

    [HttpGet("{id}")]
    public ActionResult<Carrinho> ObterPorId(int id)
    {
        return Ok(_carrinhoRepository.ObterPorId(id));
    }

    [HttpPost]
    public ActionResult Adicionar([FromBody] Carrinho carrinho)
    {
        carrinho.DataPedido = DateTime.Now.ToLocalTime();
        _carrinhoRepository.Adicionar(carrinho);
        return Ok($"O carrinho foi criado com sucesso.");
    }

    [HttpPut]
    public ActionResult Atualizar([FromBody] Carrinho carrinho)
    {
        _carrinhoRepository.Atualizar(carrinho);
        return Ok("O carrinho foi adicionado com sucesso.");
    }

    [HttpDelete]
    public ActionResult Excluir([FromBody] Carrinho carrinho)
    {
        _carrinhoRepository.Excluir(carrinho);
        return Ok("O carrinho foi excluido com sucesso.");
    }
}
