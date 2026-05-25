using Bibliotec.Models;

namespace Bibliotec.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario?> AutenticarUsuario(string email, string senha);

    }
}