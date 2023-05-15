using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Core.Seedwork;
using Microsoft.EntityFrameworkCore;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class LecteurRepository : ILecteurRepository
    {

        private FilRougeBiblioContext Context { get; }
        public LecteurRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        public async Task Create(Lecteur lecteur)
        {
            await Context.Lecteurs.AddAsync(lecteur);
            await Context.SaveChangesAsync();
        }
        public async Task Update(Lecteur lecteur)
        {
            Context.Lecteurs.Update(lecteur);
            await Context.SaveChangesAsync();

        }
        public async Task Delete(Lecteur lecteur)
        {
            Context.Lecteurs.Remove(lecteur);
            await Context.SaveChangesAsync();

        }
        public async Task<List<Lecteur>> ListAll()
        {
            return await Context.Lecteurs.Include(t=>t.ListEmprunts).ToListAsync();
           
        }
        public async Task<Lecteur> GetById(int id)
        {
            return await Context.Lecteurs.Include(t => t.ListEmprunts).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.Lecteurs.Include(t => t.ListEmprunts).AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.Lecteurs == null;
        }

       
    }
}
