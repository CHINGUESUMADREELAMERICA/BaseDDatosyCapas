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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                //si quieren construirlo en sus bases de datos solo cambien el nombre del servidor y
                //en la consola de herramientas nuget ponen Add-Migration Inicial y luego Update-Database
                //"Server=(localdb)\\MSSQLLocalDB; Database=TerrenosDB; Trusted_Connection = True;TrustServerCertificate=true;"//Diana
                //"Server=Maquiavelica1\\SQLEXPRESS;Database=TerrenosDB; Trusted_Connection = True;TrustServerCertificate=true;"//Camila
            );
        }
    }
}
