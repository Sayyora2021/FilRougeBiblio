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
            // cotisation ok?
            if(!emprunt.Lecteur.Cotisation) { return; }

            // pas plus de trois livres
            if(emprunt.Lecteur.ListEmprunts.Where(e => e.DateRetourReel == null).ToList().Count >= 3) { return; }

            // exemplaire disponible.
            if(Context.Emprunts.Any(e => e.Exemplaire.Id == e.Exemplaire.Id && e.DateRetourReel == null)) { return; }

            await Context.Emprunts.AddAsync(emprunt);
            await Context.SaveChangesAsync();
        }
        public async Task RemoveBookFromLecteur(Emprunt emprunt)
        {
            
            emprunt.DateRetourReel = DateTime.Now;
            Context.Update(emprunt);
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

        public async Task Create(Emprunt emprunt)
        {
            Context.Emprunts.Add(emprunt);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Emprunt>> ListAll()
        {
            return await Context.Emprunts.Include(c => c.Lecteur).Include(c => c.Exemplaire).Include(c => c.Exemplaire.Livre).ToListAsync();
        }
        
    }
}
