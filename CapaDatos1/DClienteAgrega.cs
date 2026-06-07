using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos1
{
    public class DClienteAgrega
    {
        public void Agregar(DCliente cliente)
        {
            using var db = new AppDbContext();
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }

        public DCliente BuscarPorId(int id)
        {
            using var db = new AppDbContext();
            return db.Clientes.Find(id);
        }

        public DCliente BuscarPorFolio(string folio)
        {
            using var db = new AppDbContext();
            return db.Clientes.FirstOrDefault(c => c.Folio == folio);
        }

        public DCliente BuscarPorIdentificacion(string identificacion)
        {
            using var db = new AppDbContext();
            return db.Clientes.FirstOrDefault(c => c.Identificacion == identificacion);
        }

        public DCliente BuscarPorCredenciales(string identificacion, string contrasena)
        {
            using var db = new AppDbContext();
            return db.Clientes.FirstOrDefault(c => c.Identificacion == identificacion && c.Contrasena == contrasena);
        }

        public List<DCliente> ObtenerTodos()
        {
            using var db = new AppDbContext();
            return db.Clientes.ToList();
        }

        public void Actualizar(DCliente cliente)
        {
            using var db = new AppDbContext();
            db.Clientes.Update(cliente);
            db.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var db = new AppDbContext();
            var cliente = db.Clientes.Find(id);
            if (cliente != null)
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
        }
    }
}
