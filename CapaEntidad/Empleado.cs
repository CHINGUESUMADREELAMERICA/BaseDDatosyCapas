using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Cargo { get; set; }       // "Empleado" o "Gerente"
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal SueldoSemanal { get; set; }
        public string Turno { get; set; }       // "Matutino" o "Vespertino"
        public string Contrasena { get; set; }
    }
}
