using Microsoft.EntityFrameworkCore;
using PIMVIII.Data;
using PIMVIII.Interfaces;
using PIMVIII.Models;

namespace PIMVIII.Repositories;

public class ProdutoRepository : IRepository<Produto>
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Produto> ObterTodos()
    {
        return _context.Produtos.ToList();
    }

    public Produto ObterPorId(int id)
    {
        return _context.Produtos.Find(id);
    } 

    public void Adicionar(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
    }

    public void Atualizar(Produto produto)
    {
        _context.Produtos.Update(produto);
        _context.SaveChanges();
    }

    public void Excluir(Produto produto) 
    { 
        _context.Produtos.Remove(produto); 
        _context.SaveChanges();
    }
}
