using FilRougeBiblio.Core.Entities;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface IMotClefRepository
    {
        Task Create(MotClef motclef);
        Task Delete(MotClef motclef);
        Task<MotClef> GetById(int id);
        Task<List<MotClef>> ListAll();
        Task Update(MotClef motclef);
        Task<bool> Exists(int id);
        Task<bool> IsEmpty();
    }
}