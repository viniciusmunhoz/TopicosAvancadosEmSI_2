using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjMVC30082021.Models;

namespace ProjMVC30082021.Data
{
    public class ProjMVC30082021Context : DbContext
    {
        public ProjMVC30082021Context (DbContextOptions<ProjMVC30082021Context> options)
            : base(options)
        {
        }

        public DbSet<ProjMVC30082021.Models.Cliente> Cliente { get; set; }

        public DbSet<ProjMVC30082021.Models.Padaria> Padaria { get; set; }

        public DbSet<ProjMVC30082021.Models.Produto> Produto { get; set; }
    }
}
