using FilRougeBiblio.Core.Entities;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface ILecteurRepository
    {
        Task Create(Lecteur lecteur);
        Task Delete(Lecteur lecteur);
        Task<bool> Exists(int id);
        Task<Lecteur> GetById(int id);
        Task<bool> IsEmpty();
        Task<List<Lecteur>> ListAll();
        Task Update(Lecteur lecteur);
        
    }
}