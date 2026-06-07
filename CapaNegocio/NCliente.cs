using System.Collections.Generic;
using System.Linq;
using System;
using CapaDatos1;
using CapaDatos1.Modelos;


namespace CapaNegocio
{
    public class CN_Cliente
    {
        private DClienteAgrega objCapaDatos = new DClienteAgrega();

        public DCliente ObtenerClientePorId(int ID)
        {
            return objCapaDatos.BuscarPorId(ID);
        }

        public void ActualizarDatosCliente(DCliente cliente)
        {

            objCapaDatos.Actualizar(cliente);
        }
        public List<DTerreno> obtenerTerrenoPorCliente(int IDCliente)
        {
            using var db = new AppDbContext();
            return db.Terrenos.Where(t => t.ClienteId == IDCliente).ToList();
        }
        public bool RegristrarPagoTerreno(int IDTerreno, decimal CantidadAbono, out string mensaje) 
        {
            mensaje = string.Empty;
            if (CantidadAbono <= 0)
            {
                mensaje = "La cantidad a abonar debe ser mayor a cero.";
                return false;
            }
            using var db = new AppDbContext();
            var terreno = db.Terrenos.Find(IDTerreno);
           
            if (terreno == null)
            {
                mensaje = "Terreno no encontrado.";
                return false;
            }
            if(CantidadAbono>terreno.Saldo)
            {
                mensaje = $"No puedes abonar mas del saldo pendiente. Tu saldo actual es:{terreno.Saldo:C}";
                return false;
            }
            terreno.MontoPagado += CantidadAbono;
            if(terreno.Saldo == 0)
            {
                terreno.Estado = "Liquidado";
            }
            db.Terrenos.Update(terreno);
            db.SaveChanges();
            return true;
        }
    }
}
