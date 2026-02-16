using GestaoCulinaria.Blazor.Models;

namespace GestaoCulinaria.Blazor.Services;

public class ProdutoApiService
{
    private readonly IHttpClientFactory _httpFactory;

    public ProdutoApiService(IHttpClientFactory httpFactory)
    {
        _httpFactory = httpFactory;
    }

    public async Task<List<ProdutoModel>> ObterTodosAsync()
    {
        var client = _httpFactory.CreateClient("api");

        var produtos = await client.GetFromJsonAsync<List<ProdutoModel>>("produtos");

        return produtos ?? new List<ProdutoModel>();
    }
}