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
    public class DTerreno
    {
        [Key]                          // llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // autoincremental
        public int Id { get; set; }

        public string NoTerreno { get; set; }
        public string Direccion { get; set; }
        public string Colindancias { get; set; }
        public string Medidas { get; set; }
        public bool EnVenta { get; set; }

        // Pagos simplificados
        public decimal MontoTotal { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Saldo => MontoTotal - MontoPagado;

        // Info de venta
        public DateTime? FechaCompra { get; set; }
        public int? DiasDePago { get; set; }
        public string? Estado { get; set; }

        // Documentos
        public bool EscrituraPublica { get; set; }
        public bool BoletaPredial { get; set; }
        public bool PlanoTerreno { get; set; }

        // Relación con cliente
        public int? ClienteId { get; set; }
        public DCliente? Cliente { get; set; }
    }
}
