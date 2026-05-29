using Bibliotec.Contexts;
using Bibliotec.Interfaces;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec.Repositories
{
    public class LivroRepository : ILivroRepository
    {

        private readonly BbDbContext _context;

        public LivroRepository(BbDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> BuscarLivrosAsync()
        {
            return await _context.Livro.Include(l => l.LivroCategorias).ThenInclude(lc => lc.Categoria).ToListAsync();
        }
    }
}