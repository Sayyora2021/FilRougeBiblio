using FilRougeBiblio.Core.Entities;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface IAuteurRepository
    {
        Task Create(Auteur auteur);
        Task Delete(Auteur auteur);
        Task<Auteur> GetById(int id);
        Task<List<Auteur>> ListAll();
        Task Update(Auteur auteur);
        Task<bool> Exists(int id);
        Task<bool> IsEmpty();
    }
}