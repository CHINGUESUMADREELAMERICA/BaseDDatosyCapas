using CapaDatos1;
using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class NTerreno
    {
        private DTerrenoAgrega d = new DTerrenoAgrega();

        public List<DTerreno> ObtenerTodos() => d.ObtenerTodos();
        public List<DTerreno> ObtenerEnVenta() => d.ObtenerEnVenta();
        public List<DTerreno> ObtenerPorCliente(int id) => d.ObtenerPorCliente(id);
        public List<DTerreno> ObtenerPorFolioCliente(string folio) => d.ObtenerPorFolioCliente(folio);

        public void Agregar(DTerreno t)
        {
            Validar(t);
            d.Agregar(t);
        }

        public void Modificar(DTerreno t)
        {
            Validar(t);
            d.Actualizar(t);
        }

        // Solo para Empleado: días de pago, propietario (ClienteId) y fecha de compra
        public void ModificarEmpleado(int id, int? diasDePago, int? clienteId, DateTime? fechaCompra)
        {
            if (id <= 0) throw new Exception("Selecciona un terreno válido.");
            d.ActualizarEmpleado(id, diasDePago, clienteId, fechaCompra);
        }

        public void Eliminar(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            d.Eliminar(id);
        }

        private void Validar(DTerreno t)
        {
            if (string.IsNullOrWhiteSpace(t.NoTerreno)) throw new Exception("El número de terreno es requerido.");
        }
    }
}