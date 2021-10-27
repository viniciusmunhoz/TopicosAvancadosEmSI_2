using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjVendaCalcados.Models;

namespace ProjVendaCalcados.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjVendaCalcados.Models.Calcado> Calcado { get; set; }
        public DbSet<ProjVendaCalcados.Models.Cliente> Cliente { get; set; }
        public DbSet<ProjVendaCalcados.Models.Loja> Loja { get; set; }
        public DbSet<ProjVendaCalcados.Models.Vendedor> Vendedor { get; set; }
        public DbSet<ProjVendaCalcados.Models.Venda> Venda { get; set; }
    }
}
