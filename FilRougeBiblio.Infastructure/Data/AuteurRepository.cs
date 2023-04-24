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
    public class AuteurRepository : IAuteurRepository
    {
        private FilRougeBiblioContext Context { get; }
        public AuteurRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        public async Task Create(Auteur auteur)
        {
            await Context.Auteurs.AddAsync(auteur);
            await Context.SaveChangesAsync();
        }
        public async Task Update(Auteur auteur)
        {
            Context.Auteurs.Update(auteur);
            await Context.SaveChangesAsync();

        }
        public async Task Delete(Auteur auteur)
        {
            Context.Auteurs.Remove(auteur);
            await Context.SaveChangesAsync();

        }
        public async Task<List<Auteur>> ListAll()
        {
            return await Context.Auteurs.ToListAsync();
        }
        public async Task<Auteur> GetById(int id)
        {
            return await Context.Auteurs.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.Auteurs.AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.Auteurs == null;
        }
    }
}
