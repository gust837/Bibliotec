using Bibliotec.Models;

namespace Bibliotec.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> BuscarPorEmailSenha(string email, string senha);
    }
}