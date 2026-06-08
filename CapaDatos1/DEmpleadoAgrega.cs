using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos1
{
    public class DEmpleadoAgrega
    {
        // ─── AGREGAR ──────────────────────────────────────────────────────────
        public void Agregar(DEmpleado empleado)
        {
            try
            {
                using var db = new AppDbContext();
                db.Empleados.Add(empleado);
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Error al agregar empleado: " + ex.Message); }
        }

        // ─── BUSCAR ───────────────────────────────────────────────────────────
        public DEmpleado BuscarPorId(int id)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Empleados.Find(id);
            }
            catch (Exception ex) { throw new Exception("Error al buscar empleado: " + ex.Message); }
        }

        public DEmpleado BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Empleados.FirstOrDefault(e => e.Identificacion == identificacion);
            }
            catch (Exception ex) { throw new Exception("Error al buscar por identificación: " + ex.Message); }
        }

        // Login: valida identificación + contraseña
        public DEmpleado BuscarPorCredenciales(string identificacion, string contrasena)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Empleados.FirstOrDefault(e =>
                    e.Identificacion == identificacion && e.Contraseña == contrasena);
            }
            catch (Exception ex) { throw new Exception("Error al validar credenciales: " + ex.Message); }
        }

        // ─── OBTENER ──────────────────────────────────────────────────────────
        public List<DEmpleado> ObtenerTodos()
        {
            try
            {
                using var db = new AppDbContext();
                return db.Empleados.ToList();
            }
            catch (Exception ex) { throw new Exception("Error al obtener empleados: " + ex.Message); }
        }

        public List<DEmpleado> ObtenerPorCargo(string cargo)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Empleados.Where(e => e.Cargo == cargo).ToList();
            }
            catch (Exception ex) { throw new Exception("Error al filtrar por cargo: " + ex.Message); }
        }

        // ─── ACTUALIZAR ───────────────────────────────────────────────────────
        public void Actualizar(DEmpleado empleado)
        {
            try
            {
                using var db = new AppDbContext();
                db.Empleados.Update(empleado);
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Error al actualizar empleado: " + ex.Message); }
        }

        // ─── ELIMINAR ─────────────────────────────────────────────────────────
        public void Eliminar(int id)
        {
            try
            {
                using var db = new AppDbContext();
                var empleado = db.Empleados.Find(id);
                if (empleado != null)
                {
                    db.Empleados.Remove(empleado);
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { throw new Exception("Error al eliminar empleado: " + ex.Message); }
        }
    }
}
