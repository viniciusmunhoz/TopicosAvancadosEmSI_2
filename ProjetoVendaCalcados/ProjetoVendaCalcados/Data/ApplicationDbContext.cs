using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVendaCalcados.Models;

namespace ProjetoVendaCalcados.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjetoVendaCalcados.Models.Calcado> Calcado { get; set; }
        public DbSet<ProjetoVendaCalcados.Models.Loja> Loja { get; set; }
        public DbSet<ProjetoVendaCalcados.Models.Vendedor> Vendedor { get; set; }
        public DbSet<ProjetoVendaCalcados.Models.Cliente> Cliente { get; set; }
        public DbSet<ProjetoVendaCalcados.Models.Venda> Venda { get; set; }
    }
}
