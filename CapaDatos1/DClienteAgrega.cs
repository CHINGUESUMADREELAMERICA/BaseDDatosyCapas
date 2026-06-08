using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos1
{
    public class DClienteAgrega
    {
        // ─── AGREGAR ──────────────────────────────────────────────────────────
        public void Agregar(DCliente cliente)
        {
            try
            {
                using var db = new AppDbContext();
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Error al agregar cliente: " + ex.Message); }
        }

        // ─── BUSCAR ───────────────────────────────────────────────────────────
        public DCliente BuscarPorId(int id)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Clientes.Find(id);
            }
            catch (Exception ex) { throw new Exception("Error al buscar cliente: " + ex.Message); }
        }

        public DCliente BuscarPorFolio(string folio)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Clientes.FirstOrDefault(c => c.Folio == folio);
            }
            catch (Exception ex) { throw new Exception("Error al buscar por folio: " + ex.Message); }
        }

        public DCliente BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Clientes.FirstOrDefault(c => c.Identificacion == identificacion);
            }
            catch (Exception ex) { throw new Exception("Error al buscar por identificación: " + ex.Message); }
        }

        public DCliente BuscarPorCredenciales(string identificacion, string contrasena)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Clientes.FirstOrDefault(c =>
                    c.Identificacion == identificacion && c.Contrasena == contrasena);
            }
            catch (Exception ex) { throw new Exception("Error al validar credenciales: " + ex.Message); }
        }

        // ─── OBTENER ──────────────────────────────────────────────────────────
        public List<DCliente> ObtenerTodos()
        {
            try
            {
                using var db = new AppDbContext();
                return db.Clientes.ToList();
            }
            catch (Exception ex) { throw new Exception("Error al obtener clientes: " + ex.Message); }
        }

        public List<DCliente> ObtenerPorFiltro(string filtroFolio)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Clientes
                    .Where(c => c.Folio.Contains(filtroFolio))
                    .ToList();
            }
            catch (Exception ex) { throw new Exception("Error al filtrar clientes: " + ex.Message); }
        }

        // ─── ACTUALIZAR ───────────────────────────────────────────────────────
        public void Actualizar(DCliente cliente)
        {
            try
            {
                using var db = new AppDbContext();
                db.Clientes.Update(cliente);
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Error al actualizar cliente: " + ex.Message); }
        }

        // ─── ELIMINAR ─────────────────────────────────────────────────────────
        public void Eliminar(int id)
        {
            try
            {
                using var db = new AppDbContext();
                var cliente = db.Clientes.Find(id);
                if (cliente != null)
                {
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { throw new Exception("Error al eliminar cliente: " + ex.Message); }
        }
    }
}
