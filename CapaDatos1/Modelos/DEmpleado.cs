using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos1.Modelos
{
    public class DEmpleado
    {
        [Key]                          // llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // autoincremental
        public int Id { get; set; }

        public string Cargo { get; set; }       // "Empleado" o "Administrador"
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal SueldoSemanal { get; set; }
        public string Turno { get; set; }       // "Matutino" o "Vespertino"
        public string Contraseña { get; set; }      // agregado para login

    }
}
