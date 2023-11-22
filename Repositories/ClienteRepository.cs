namespace PIMVIII.Repositories;

using Microsoft.EntityFrameworkCore;
using PIMVIII.Data;
using PIMVIII.Interfaces;
using PIMVIII.Models;

public class ClienteRepository : IRepository<Cliente>
{
    private readonly AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Cliente> ObterTodos()
    {
        return _context.Clientes.ToList();
    }

    public Cliente ObterPorId(int id)
    {
        return _context.Clientes.Find(id);
    }

    public void Adicionar(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
    }

    public void Atualizar(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        _context.SaveChanges();
    }

    public void Excluir(Cliente cliente)
    {
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
    }
}
