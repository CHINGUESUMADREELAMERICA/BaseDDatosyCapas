using CapaDatos1;
using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class NCliente
    {
        private DClienteAgrega d = new DClienteAgrega();

        public List<DCliente> ObtenerTodos() => d.ObtenerTodos();

        public DCliente ObtenerPorFolio(string folio)
        {
            if (string.IsNullOrWhiteSpace(folio)) throw new Exception("El folio no puede estar vacío.");
            return d.BuscarPorFolio(folio);
        }

        public DCliente ValidarAcceso(string identificacion, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(identificacion) || string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("Identificación y contraseña son requeridas.");
            return d.BuscarPorCredenciales(identificacion, contrasena);
        }

        public void Agregar(DCliente c)
        {
            Validar(c);
            d.Agregar(c);
        }

        public void Modificar(DCliente c)
        {
            Validar(c);
            d.Actualizar(c);
        }

        public void Eliminar(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            d.Eliminar(id);
        }

        private void Validar(DCliente c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre)) throw new Exception("El nombre es requerido.");
            if (string.IsNullOrWhiteSpace(c.Apellidos)) throw new Exception("Los apellidos son requeridos.");
            if (string.IsNullOrWhiteSpace(c.Identificacion)) throw new Exception("La identificación es requerida.");
            if (string.IsNullOrWhiteSpace(c.Contrasena)) throw new Exception("La contraseña es requerida.");
        }
    }
}