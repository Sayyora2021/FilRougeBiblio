using FilRougeBiblio.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRougeBiblio.Core.Seedwork;

namespace FilRougeBiblio.Infrastructure.Data 
{
    public class LivreRepository : ILivreRepository
    {
        private FilRougeBiblioContext Context { get; }
        public LivreRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        public async Task Create(Livre livre)
        {
            await Context.Livres.AddAsync(livre);
            await Context.SaveChangesAsync();
        }
        public async Task Update(Livre livre)
        {
            Context.Livres.Update(livre);
            await Context.SaveChangesAsync();

        }
        public async Task Delete(Livre livre)
        {
            Context.Livres.Remove(livre);
            await Context.SaveChangesAsync();

        }
        public async Task<List<Livre>> ListAll()
        {
            return await Context.Livres.ToListAsync();
        }
        public async Task<Livre> GetById(int id)
        {
            return await Context.Livres.Include(c => c.Auteurs).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.Livres.AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.Livres == null;
        }
    }
}
