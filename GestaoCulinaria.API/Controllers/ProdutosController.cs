using GestaoCulinaria.Application.DTOs.Produtos;
using GestaoCulinaria.Application.Services;
using GestaoCulinaria.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestaoCulinaria.API.Controllers;

[ApiController]
[Route("produtos")]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoService _service;
    
    public ProdutosController(ProdutoService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        Task.Delay(2000).Wait(); // Simula um atraso de 2 segundos
        var produtos = await _service.ObterTodosAsync();
        return Ok(produtos);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProdutoRequest request)
    {
        await _service.AdicionarAsync(request);
        return Created();
    }
}