using GestaoCulinaria.Domain.Entities;

namespace GestaoCulinaria.Domain.Repositories;

public interface IUsuarioRepository
{
    Task<Usuario?> ObterPorEmail(string email);
    Task Adicionar(Usuario usuario);
}