using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPIBoletim.Models;

namespace ProjAPIBoletim.Data
{
    public class ProjAPIBoletimContext : DbContext
    {
        public ProjAPIBoletimContext (DbContextOptions<ProjAPIBoletimContext> options)
            : base(options)
        {
        }

        public DbSet<ProjAPIBoletim.Models.Aluno> Aluno { get; set; }

        public DbSet<ProjAPIBoletim.Models.Curso> Curso { get; set; }

        public DbSet<ProjAPIBoletim.Models.Disciplina> Disciplina { get; set; }

        public DbSet<ProjAPIBoletim.Models.Boletim> Boletim { get; set; }

        public DbSet<ProjAPIBoletim.Models.Professor> Professor { get; set; }
    }
}
