using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Auteur : Entity
    {
        public string Prenom { get; set; } = null!;
        public string Nom { get; set; } = null!;

        public virtual List<Livre> Livres { get; set; }
    }
}
