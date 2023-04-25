using FilRougeBiblio.Core.Entities;
using System.Linq.Expressions;

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
        Task<List<Auteur>> GetList(Expression<Func<Auteur, bool>> criteria);
    }
}