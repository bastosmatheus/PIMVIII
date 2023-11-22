using Microsoft.EntityFrameworkCore;
using PIMVIII.Data;
using PIMVIII.Interfaces;
using PIMVIII.Models;
using PIMVIII.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IRepository<Cliente>, ClienteRepository>();
builder.Services.AddScoped<IRepository<Vendedor>, VendedorRepository>();
builder.Services.AddScoped<IRepository<Produto>, ProdutoRepository>();
builder.Services.AddScoped<IRepository<Carrinho>, CarrinhoRepository>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

