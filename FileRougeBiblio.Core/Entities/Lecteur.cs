﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        
        public List<Emprunt> ListEmprunts { get; set; } = null!;
        public bool Cotisation { get; set; }
    }
}
