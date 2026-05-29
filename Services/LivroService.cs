using Bibliotec.Interfaces;
using Bibliotec.Models;
using Bibliotec.Repositories;

namespace Bibliotec.Services
{
    public class LivroService : ILivroService
    {

        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task<IEnumerable<Livro>> BuscarLivrosComCat()
        {
            return await _livroRepository.BuscarLivrosAsync();
        }
    }
}