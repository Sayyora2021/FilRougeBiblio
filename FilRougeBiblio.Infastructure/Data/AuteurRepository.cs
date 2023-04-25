using FilRougeBiblio.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRougeBiblio.Core.Seedwork;
using System.Linq.Expressions;

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
            return await Context.Auteurs.Include(t=>t.Livres).ToListAsync();
           
        }
        public async Task<Auteur> GetById(int id)
        {
            return await Context.Auteurs.Include(c => c.Livres).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.Auteurs.AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.Auteurs == null;
        }

        public async Task<List<Auteur>> GetList(Expression<Func<Auteur, bool>> criteria)
        {
            return await Context.Auteurs.Include(t=>t.Livres).Where(criteria).ToListAsync();
            
        }

    }
}
