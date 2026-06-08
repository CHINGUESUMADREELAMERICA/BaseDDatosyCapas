using CapaDatos1;
using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class NEmpleado
    {
        private DEmpleadoAgrega d = new DEmpleadoAgrega();

        public DEmpleado ValidarAcceso(string identificacion, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(identificacion) || string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("Identificación y contraseña son requeridas.");
            return d.BuscarPorCredenciales(identificacion, contrasena);
        }

        public List<DEmpleado> ObtenerTodos() => d.ObtenerTodos();

        public void Agregar(DEmpleado e)
        {
            Validar(e);
            d.Agregar(e);
        }

        public void Modificar(DEmpleado e)
        {
            Validar(e);
            d.Actualizar(e);
        }

        public void Eliminar(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            d.Eliminar(id);
        }

        private void Validar(DEmpleado e)
        {
            if (string.IsNullOrWhiteSpace(e.Nombre)) throw new Exception("El nombre es requerido.");
            if (string.IsNullOrWhiteSpace(e.Apellidos)) throw new Exception("Los apellidos son requeridos.");
            if (string.IsNullOrWhiteSpace(e.Identificacion)) throw new Exception("La identificación es requerida.");
            if (string.IsNullOrWhiteSpace(e.Cargo)) throw new Exception("El cargo es requerido.");
            if (string.IsNullOrWhiteSpace(e.Contraseña)) throw new Exception("La contraseña es requerida.");
        }
    }
}

