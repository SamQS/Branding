using System;
using System.Collections.Generic;
using System.Text;
using branding.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace branding.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dco)
            : base(dco)
        {
        }
        public DbSet<Consulta> Consultas {get ;set; }
        public DbSet<branding.Models.Producto> Producto { get; set; }
        public DbSet<branding.Models.Proforma> Proforma { get; set; }
    }
}
