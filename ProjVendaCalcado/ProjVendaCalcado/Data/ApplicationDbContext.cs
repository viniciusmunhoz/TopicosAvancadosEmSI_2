using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjVendaCalcado.Models;

namespace ProjVendaCalcado.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjVendaCalcado.Models.Calcado> Calcado { get; set; }
        public DbSet<ProjVendaCalcado.Models.Cliente> Cliente { get; set; }
        public DbSet<ProjVendaCalcado.Models.Loja> Loja { get; set; }
        public DbSet<ProjVendaCalcado.Models.Vendedor> Vendedor { get; set; }
        public DbSet<ProjVendaCalcado.Models.Venda> Venda { get; set; }
    }
}
