using Bibliotec.Models;

namespace Bibliotec.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> BuscarLivrosComCat();
    }
}