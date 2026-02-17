using GestaoCulinaria.Application.DTOs.Login;
using GestaoCulinaria.Application.UseCases.Auth;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly LoginUseCase _loginUseCase;

    public AuthController(LoginUseCase loginUseCase)
    {
        _loginUseCase = loginUseCase;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var token = await _loginUseCase.Executar(request.Email, request.Senha);

        if (token == null)
            return Unauthorized("Email ou senha inválidos");

        return Ok(new LoginResponse { Token = token });
    }
}