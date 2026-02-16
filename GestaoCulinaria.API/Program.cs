using GestaoCulinaria.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using GestaoCulinaria.Domain.Repositories;
using GestaoCulinaria.Infrastructure.Persistence.Repositories;
using GestaoCulinaria.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ProdutoService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazor",
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseCors("AllowBlazor");

app.MapControllers();

app.Run();

