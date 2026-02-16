using GestaoCulinaria.Application.DTOs.Produtos;
using GestaoCulinaria.Domain.Entities;
using GestaoCulinaria.Domain.Repositories;

namespace GestaoCulinaria.Application.Services;

public class ProdutoService
{
    private readonly IProdutoRepository _repository;

    public ProdutoService(IProdutoRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ProdutoResponse>> ObterTodosAsync()
    {
        var produtos = await _repository.ObterTodosAsync();
        return produtos.Select(p => new ProdutoResponse
        {
            Id = p.Id,
            Nome = p.Nome,
            Preco = p.Preco
        }).ToList();
    }

    public async Task AdicionarAsync(ProdutoRequest request)
    {
        var produto = new Produto(request.Nome, request.Preco);
        await _repository.AdicionarAsync(produto);
    }
}