using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Core.Seedwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class EmpruntRepository : IEmpruntRepository
    {

        private FilRougeBiblioContext Context { get; }
        public EmpruntRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        public async Task AddBookToLecteur(Emprunt emprunt)
        {
            await Context.Emprunts.AddAsync(emprunt);
            await Context.SaveChangesAsync();
        }
        public async Task RemoveBookFromLecteur(Emprunt emprunt)
        {
            Context.Emprunts.Remove(emprunt);
            await Context.SaveChangesAsync();
        }

        public async Task<List<Emprunt>> ListAllBookTaken(int lecteurId)
        {

            return await Context.Emprunts.Where(e => e.Lecteur.Id == lecteurId).ToListAsync();

        }
        public async Task<Emprunt> GetById(int id)
        {
            return await Context.Emprunts.Include(e => e.Exemplaire).Include(e => e.Lecteur).FirstOrDefaultAsync(e => e.Id == id);
        }

        private async Task CalculatePrice()
        {

        }
        
    }
}
