using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos1.Modelos
{
    public class DCliente
    {
        [Key]                          // llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // autoincremental
        public int Id { get; set; }           // PK autoincremental

        public string Folio { get; set; }     // folio asignado
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string? Correo { get; set; }         // opcional
        public string Contrasena { get; set; }

        // Relación: un cliente puede tener varios terrenos
        public ICollection<DTerreno> Terrenos { get; set; }
    }
}
