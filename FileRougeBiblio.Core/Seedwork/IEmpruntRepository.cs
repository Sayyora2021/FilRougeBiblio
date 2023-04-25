using FilRougeBiblio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Seedwork
{
    public interface IEmpruntRepository
    {

        Task AddBookToLecteur(Emprunt emprunt);
        Task<Emprunt> GetById(int id);
        Task<List<Emprunt>> ListAllBookTaken(int lecteurId);
        Task RemoveBookFromLecteur(Emprunt emprunt);

    }
}
