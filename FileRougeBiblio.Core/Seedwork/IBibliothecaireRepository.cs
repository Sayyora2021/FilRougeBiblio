using FilRougeBiblio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface IBibliothecaireRepository
    {

        Task Create(Bibliothecaire bibliothecaire);
        Task Delete(Bibliothecaire bibliothecaire);
        Task<bool> Exists(int id);
        Task<Bibliothecaire> GetById(int id);
        Task<bool> IsEmpty();
        Task<List<Bibliothecaire>> ListAll();
        Task Update(Bibliothecaire bibliothecaire);

    }
}
