using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Emprunt : Entity
    {
        public Exemplaire Exemplaire { get; set; } = null!;
        public Lecteur Lecteur { get; set; } = null!;

        public DateTime? DateEmprunt { get; set; }

        public DateTime? DateRetour { get; set; }

        public DateTime? DateRetourReel { get; set; }

        
    }
}
