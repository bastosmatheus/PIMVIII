namespace PIMVIII.Repositories;

using Microsoft.EntityFrameworkCore;
using PIMVIII.Data;
using PIMVIII.Interfaces;
using PIMVIII.Models;

public class CarrinhoRepository : IRepository<Carrinho>
{
    private readonly AppDbContext _context;

    public CarrinhoRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Adicionar(Carrinho entidade)
    {
        
    }

    public void Atualizar(Carrinho entidade)
    {
        throw new NotImplementedException();
    }

    public void Excluir(Carrinho entidade)
    {
        throw new NotImplementedException();
    }

    public void ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Carrinho> ObterTodos()
    {
        throw new NotImplementedException();
    }
}
