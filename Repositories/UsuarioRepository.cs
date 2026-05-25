using Bibliotec.Contexts;
using Bibliotec.Interfaces;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BbDbContext _context;

        public UsuarioRepository(BbDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> BuscarPorEmailSenha(string email, string senha)
        {
           return await _context.Usuario.FirstOrDefaultAsync( u => u.Email == email && u.Senha == senha);
        }
    }
}