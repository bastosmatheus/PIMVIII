using Microsoft.EntityFrameworkCore;
using PIMVIII.Data;
using PIMVIII.Interfaces;
using PIMVIII.Models;

namespace PIMVIII.Repositories;

public class VendedorRepository : IRepository<Vendedor>
{
    private readonly AppDbContext _context;

    public VendedorRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Vendedor> ObterTodos()
    {
        return _context.Vendedores.ToList();
    }

    public Vendedor ObterPorId(int id)
    {
        return _context.Vendedores.Find(id);
    }

    public void Adicionar(Vendedor vendedor)
    {
        _context.Vendedores.Add(vendedor);
        _context.SaveChanges();
    }

    public void Atualizar(Vendedor vendedor)
    {
        _context.Vendedores.Update(vendedor);
        _context.SaveChanges();
    }

    public void Excluir(Vendedor vendedor)
    {
        _context.Vendedores.Remove(vendedor);
        _context.SaveChanges();
    }
}
