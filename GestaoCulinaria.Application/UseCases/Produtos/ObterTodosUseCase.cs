using GestaoCulinaria.Application.DTOs.Produtos;
using GestaoCulinaria.Domain.Entities;
using GestaoCulinaria.Domain.Repositories;

namespace GestaoCulinaria.Application.UseCases.Produtos;

public class ObterTodosUseCase
{
    private readonly IProdutoRepository _repo;

    public ObterTodosUseCase(IProdutoRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<ProdutoResponse>> Executar()
    {
        var produtos = await _repo.ObterTodosAsync();
        return produtos.Select(p => new ProdutoResponse
        {
            Id = p.Id,
            Nome = p.Nome,
            Preco = p.Preco
        }).ToList();
    }
    
    
}