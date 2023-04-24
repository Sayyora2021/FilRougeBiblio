using FilRougeBiblio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface IThemeRepository
    {
        Task Create(Theme theme);
        Task Delete(Theme theme);
        Task<Theme> GetById(int id);
        Task<List<Theme>> ListAll();
        Task Update(Theme theme);
        Task<bool> Exists(int id);
        Task<bool> IsEmpty();
    }
}
