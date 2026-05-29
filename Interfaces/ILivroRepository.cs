using Bibliotec.Models;

namespace Bibliotec.Interfaces
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> BuscarLivrosAsync();
    }
}