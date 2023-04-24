using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FilRougeBiblio.Core.Entities
{
    public class Livre : Entity
    {

        public string ISBN { get; set; } = null!;
        public string Titre { get; set; } = null!;

        public List<Theme> Themes { get; set; }

        public List<MotClef> Tags { get; set; }

        public List<Auteur> Auteurs { get; set;}
    }
}
