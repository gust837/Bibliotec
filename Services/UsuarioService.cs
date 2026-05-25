using Bibliotec.Interfaces;
using Bibliotec.Models;

namespace Bibliotec.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioReposiotry;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioReposiotry = usuarioRepository;
        }

        public async Task<Usuario?> AutenticarUsuario(string email, string senha)
        {
            return await _usuarioReposiotry.BuscarPorEmailSenha(email,senha);
        }
    }
}