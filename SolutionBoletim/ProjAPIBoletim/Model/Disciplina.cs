﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjAPIBoletim.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int QtdAulasPorsemana { get; set; }
    }
}
