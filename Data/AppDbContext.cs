using Microsoft.EntityFrameworkCore;
using PIMVIII.Models;

namespace PIMVIII.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Carrinho> Carrinhos { get; set; }

    public DbSet<Vendedor> Vendedores { get; set; }

    public DbSet<Produto> Produtos { get; set; }

    public DbSet<Cliente> Clientes { get; set; }
}
