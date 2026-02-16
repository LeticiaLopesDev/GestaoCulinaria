using GestaoCulinaria.Domain.Entities;

namespace GestaoCulinaria.Domain.Repositories;

public interface IProdutoRepository
{
    Task<List<Produto>> ObterTodosAsync();
    Task AdicionarAsync(Produto produto);
}