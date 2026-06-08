using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Terreno
    {
        public int IdTerreno { get; set; }
        public string NoTerreno { get; set; }
        public string Direccion { get; set; }
        public string Colindancias { get; set; }
        public string Medidas { get; set; }
        public bool EnVenta { get; set; }       // true = en venta, false = vendido

        // Campos que aplican solo si está vendido
        public string FolioCliente { get; set; }
        public DateTime? FechaCompra { get; set; }
        public int? DiasPago { get; set; }
        public string Estado { get; set; }      // "Liquidado", "En proceso", "Con adeudo"
        public bool DocEscritura { get; set; }
        public bool DocPredial { get; set; }
        public bool DocPlano { get; set; }
    }
}
