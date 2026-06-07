using CapaDatos1.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos1
{
    public class AppDbContext : DbContext
    {
        public DbSet<DCliente> Clientes { get; set; }
        public DbSet<DTerreno> Terrenos { get; set; }
        public DbSet<DEmpleado> Empleados { get; set; }
        //public DbSet<Pago> Pagos { get; set; }
        //public DbSet<Mensaje> Mensajes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB; Database = DatosV; Trusted_Connection = True;TrustServerCertificate=true;"
            );
        }
    }
}
