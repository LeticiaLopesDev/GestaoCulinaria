using GestaoCulinaria.Application.DTOs.Produtos;
using GestaoCulinaria.Domain.Entities;
using GestaoCulinaria.Domain.Repositories;

namespace GestaoCulinaria.Application.UseCases.Produtos;

public class CriarProdutoUseCase
{
    private readonly IProdutoRepository _repo;

    public CriarProdutoUseCase(IProdutoRepository repo)
    {
        _repo = repo;
    }

    public async Task Executar(ProdutoRequest request)
    {
        var produto = new Produto(request.Nome, request.Preco);

        await _repo.AdicionarAsync(produto);
    }
    
}