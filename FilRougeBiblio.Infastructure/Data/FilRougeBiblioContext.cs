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
        DbSet<Lecteur> Lecteurs => Set<Lecteur>();
        DbSet<MotClef> MotsClefs => Set<MotClef>();
        DbSet<Exemplaire> Exemplaires => Set<Exemplaire>();
        DbSet<Livre> Livres => Set<Livre>();
        DbSet<Emprunt> Emprunts => Set<Emprunt>();
        DbSet<Bibliothecaire> Bibliothecaires => Set<Bibliothecaire>();
        DbSet<Auteur> Auteurs => Set<Auteur>();
        DbSet<Theme> Themes => Set<Theme>();

        public FilRougeBiblioContext(DbContextOptions options) : base(options) { }


    }
}
