using GestaoCulinaria.Domain.Entities;
using GestaoCulinaria.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GestaoCulinaria.Infrastructure.Persistence.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Produto>> ObterTodosAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task AdicionarAsync(Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
    }
}