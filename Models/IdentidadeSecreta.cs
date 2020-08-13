using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebApi.Models
{
    public class IdentidadeSecreta
    {
        public int id { get; set; }

        public int NomeReal { get; set; }

        public int HeroiId { get; set; }

        public Heroi Heroi { get; set; }

    }
}
