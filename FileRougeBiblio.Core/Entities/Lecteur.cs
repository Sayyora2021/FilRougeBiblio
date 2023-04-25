using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Lecteur : Entity
    {
        public string Nom { get; set;  } = null!;

        public string Prenom { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telephone { get; set; } = null!;

        public string Adresse { get; set; } = null!;
        
        public List<Emprunt> ListEmprunts { get; set; } = null!;
    }
}
