using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos1
{
    public class DEmpleadoAgrega
    {
        public void Agregar(DEmpleado empleado)
        {
            using var db = new AppDbContext();
            db.Empleados.Add(empleado);
            db.SaveChanges();
        }

        public DEmpleado BuscarPorId(int id)
        {
            using var db = new AppDbContext();
            return db.Empleados.Find(id);
        }

        public DEmpleado BuscarPorIdentificacion(string identificacion)
        {
            using var db = new AppDbContext();
            return db.Empleados.FirstOrDefault(e => e.Identificacion == identificacion);
        }

        public DEmpleado BuscarPorCredenciales(string nombre, string identificacion)
        {
            using var db = new AppDbContext();
            return db.Empleados.FirstOrDefault(e => e.Nombre == nombre && e.Identificacion == identificacion);
        }

        public List<DEmpleado> ObtenerTodos()
        {
            using var db = new AppDbContext();
            return db.Empleados.ToList();
        }

        public List<DEmpleado> ObtenerPorCargo(string cargo)
        {
            using var db = new AppDbContext();
            return db.Empleados.Where(e => e.Cargo == cargo).ToList();
        }

        public void Actualizar(DEmpleado empleado)
        {
            using var db = new AppDbContext();
            db.Empleados.Update(empleado);
            db.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var db = new AppDbContext();
            var empleado = db.Empleados.Find(id);
            if (empleado != null)
            {
                db.Empleados.Remove(empleado);
                db.SaveChanges();
            }
        }
    }
}
