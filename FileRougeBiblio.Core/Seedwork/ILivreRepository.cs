using FilRougeBiblio.Core.Entities;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface ILivreRepository
    {
        Task Create(Livre livre);
        Task Delete(Livre livre);
        Task<Livre> GetById(int id);
        Task<List<Livre>> ListAll();
        Task Update(Livre livre);
        Task<bool> Exists(int id);
        Task<bool> IsEmpty();
    }
}