﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebApi.Models
{
    public class HeroiBatalha
    {
        public int HeroiId  { get; set; }
        public Heroi Heroi { get; set; }
        public int BatalhaId { get; set; }
        public Batalha Batalha { get; set; }
    }
}
