using GestaoCulinaria.Application.DTOs.Produtos;
using GestaoCulinaria.Application.UseCases.Produtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestaoCulinaria.API.Controllers;

[ApiController]
[Route("produtos")]
[Authorize]
public class ProdutosController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get([FromServices] ObterTodosUseCase service)
    {
        Task.Delay(2000).Wait(); // Simula um atraso de 2 segundos
        var produtos = await service.Executar();
        return Ok(produtos);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProdutoRequest request, [FromServices] CriarProdutoUseCase service)
    {
        await service.Executar(request);
        return Created();
    }
}