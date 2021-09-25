using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjMvcBoletim.Models;

namespace ProjMvcBoletim.Data
{
    public class ProjMvcBoletimContext : DbContext
    {
        public ProjMvcBoletimContext (DbContextOptions<ProjMvcBoletimContext> options)
            : base(options)
        {
        }

        public DbSet<ProjMvcBoletim.Models.Aluno> Aluno { get; set; }

        public DbSet<ProjMvcBoletim.Models.Curso> Curso { get; set; }

        public DbSet<ProjMvcBoletim.Models.Disciplina> Disciplina { get; set; }

        public DbSet<ProjMvcBoletim.Models.Professor> Professor { get; set; }

        public DbSet<ProjMvcBoletim.Models.Boletim> Boletim { get; set; }
    }
}
