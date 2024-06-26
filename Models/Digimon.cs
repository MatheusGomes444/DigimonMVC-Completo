using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigimonMvc.Models
{
    public class ClasseDigimon
    {
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public int Nivel { get; set; }
        public string ImagemUrl { get; set; } = string.Empty;

    }
}