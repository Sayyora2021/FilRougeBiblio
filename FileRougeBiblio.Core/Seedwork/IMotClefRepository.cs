using FilRougeBiblio.Core.Entities;
using System.Linq.Expressions;

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
        Task<List<MotClef>> GetList(Expression<Func<MotClef, bool>> criteria);
    }
}