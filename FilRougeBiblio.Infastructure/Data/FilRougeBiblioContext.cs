using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRougeBiblio.Core.Entities;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class FilRougeBiblioContext : Microsoft.EntityFrameworkCore.DbContext
    {
       public DbSet<Lecteur> Lecteurs => Set<Lecteur>();
     public DbSet<MotClef> MotClefs => Set<MotClef>();
     public   DbSet<Exemplaire> Exemplaires => Set<Exemplaire>();
     public   DbSet<Livre> Livres => Set<Livre>();
     public   DbSet<Emprunt> Emprunts => Set<Emprunt>();
      public  DbSet<Bibliothecaire> Bibliothecaires => Set<Bibliothecaire>();
     public   DbSet<Auteur> Auteurs => Set<Auteur>();
    public  DbSet<Theme> Themes => Set<Theme>();
        

        public FilRougeBiblioContext(DbContextOptions<FilRougeBiblioContext> options) : base(options) { }



    }
}
