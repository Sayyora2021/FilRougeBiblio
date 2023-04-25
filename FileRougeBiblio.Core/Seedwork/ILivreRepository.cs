using FilRougeBiblio.Core.Entities;
using System.Linq.Expressions;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface ILivreRepository
    {
        Task Create(Livre livre);
        Task Delete(Livre livre);
        Task<Livre> GetById(int id);
        Task<List<Livre>> ListAll();
        //Task Update(Livre livre, List<MotClef> motsClefs, List<Auteur> auteurs, List<Theme> themes);
        Task Update(Livre livre, int[] tags, int[] auteurs, int[] themes);
        
        Task<bool> Exists(int id);
        Task<bool> IsEmpty();
        Task<List<Livre>> GetList(Expression<Func<Livre, bool>> criteria);

    }
}