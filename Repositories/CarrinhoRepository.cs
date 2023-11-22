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

    public List<Carrinho> ObterTodos()
    {
        return _context.Carrinhos.ToList();
    }

    public Carrinho ObterPorId(int id)
    {
        return _context.Carrinhos.Find(id);
    }

    public void Adicionar(Carrinho carrinho)
    {
        _context.Carrinhos.Add(carrinho);
        _context.SaveChanges();
    }

    public void Atualizar(Carrinho carrinho)
    {
        _context.Carrinhos.Update(carrinho);
        _context.SaveChanges();
    }

    public void Excluir(Carrinho carrinho)
    {
        _context.Carrinhos.Remove(carrinho);
        _context.SaveChanges();
    }
}
