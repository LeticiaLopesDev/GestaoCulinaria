using GestaoCulinaria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestaoCulinaria.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos => Set<Produto>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}