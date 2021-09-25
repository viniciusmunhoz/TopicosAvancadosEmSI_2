using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjMvcBoletim.Models
{
    public class Boletim
    {
        public int Id { get; set; }
        public float Bimestre1 { get; set; }
        public float Bimestre2 { get; set; }
        public float Bimestre3 { get; set; }
        public float Bimestre4 { get; set; }

        public virtual Aluno Aluno { get; set; }
        [NotMapped]
        public virtual List<SelectListItem> Alunos { get; set; }
        
        public virtual Disciplina Disciplina { get; set; }
        [NotMapped]
        public virtual List<SelectListItem> Disciplinas { get; set; }

        public double Soma { get; set; }
        public double Media { get; set; }

        public string Situacao { get; set; }
    }
}
