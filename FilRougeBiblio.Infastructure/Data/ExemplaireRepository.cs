using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Core.Seedwork;
using Microsoft.EntityFrameworkCore;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class ExemplaireRepository : IExemplaireRepository
    {
        private FilRougeBiblioContext Context { get; }
        public ExemplaireRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        public async Task Create(Exemplaire exemplaire)
        {
            await Context.Exemplaires.AddAsync(exemplaire);
            await Context.SaveChangesAsync();
        }
        public async Task Update(Exemplaire exemplaire)
        {
            Context.Exemplaires.Update(exemplaire);
            await Context.SaveChangesAsync();
        }
        public async Task Delete(Exemplaire exemplaire)
        {
            Context.Exemplaires.Remove(exemplaire);
            await Context.SaveChangesAsync();
        }
        public async Task<List<Exemplaire>> ListAll()
        {
            return await Context.Exemplaires.Include(t=>t.Id).ToListAsync();
           
        }
        public async Task<Exemplaire> GetById(int id)
        {
            return await Context.Exemplaires.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<bool> Exists(int id)
        {
            return await Context.Exemplaires.AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.Exemplaires == null;
        }

    }
}
