using CapaDatos1.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos1
{
    public class DTerrenoAgrega
    {
        // ─── AGREGAR ──────────────────────────────────────────────────────────
        public void Agregar(DTerreno terreno)
        {
            try
            {
                using var db = new AppDbContext();
                db.Terrenos.Add(terreno);
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Error al agregar terreno: " + ex.Message); }
        }

        // ─── BUSCAR ───────────────────────────────────────────────────────────
        public DTerreno BuscarPorId(int id)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Terrenos.Include(t => t.Cliente).FirstOrDefault(t => t.Id == id);
            }
            catch (Exception ex) { throw new Exception("Error al buscar terreno: " + ex.Message); }
        }

        public DTerreno BuscarPorNoTerreno(string noTerreno)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Terrenos.FirstOrDefault(t => t.NoTerreno == noTerreno);
            }
            catch (Exception ex) { throw new Exception("Error al buscar terreno: " + ex.Message); }
        }

        // ─── OBTENER ──────────────────────────────────────────────────────────
        public List<DTerreno> ObtenerTodos()
        {
            try
            {
                using var db = new AppDbContext();
                return db.Terrenos.Include(t => t.Cliente).ToList();
            }
            catch (Exception ex) { throw new Exception("Error al obtener terrenos: " + ex.Message); }
        }

        public List<DTerreno> ObtenerEnVenta()
        {
            try
            {
                using var db = new AppDbContext();
                return db.Terrenos.Where(t => t.EnVenta).ToList();
            }
            catch (Exception ex) { throw new Exception("Error al obtener terrenos en venta: " + ex.Message); }
        }

        public List<DTerreno> ObtenerPorCliente(int clienteId)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Terrenos.Where(t => t.ClienteId == clienteId).ToList();
            }
            catch (Exception ex) { throw new Exception("Error al obtener terrenos del cliente: " + ex.Message); }
        }

        public List<DTerreno> ObtenerPorFolioCliente(string folio)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Terrenos
                    .Include(t => t.Cliente)
                    .Where(t => t.Cliente != null && t.Cliente.Folio == folio)
                    .ToList();
            }
            catch (Exception ex) { throw new Exception("Error al obtener terrenos por folio: " + ex.Message); }
        }

        // ─── ACTUALIZAR ───────────────────────────────────────────────────────
        public void Actualizar(DTerreno terreno)
        {
            try
            {
                using var db = new AppDbContext();
                db.Terrenos.Update(terreno);
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Error al actualizar terreno: " + ex.Message); }
        }

        // Solo actualiza los campos que el Empleado puede modificar
        public void ActualizarEmpleado(int id, int? diasDePago, int? clienteId, DateTime? fechaCompra)
        {
            try
            {
                using var db = new AppDbContext();
                var terreno = db.Terrenos.Find(id);
                if (terreno == null) throw new Exception("Terreno no encontrado.");

                terreno.DiasDePago = diasDePago;
                terreno.ClienteId = clienteId;
                terreno.FechaCompra = fechaCompra;
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Error al actualizar terreno: " + ex.Message); }
        }

        // ─── ELIMINAR ─────────────────────────────────────────────────────────
        public void Eliminar(int id)
        {
            try
            {
                using var db = new AppDbContext();
                var terreno = db.Terrenos.Find(id);
                if (terreno != null)
                {
                    db.Terrenos.Remove(terreno);
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { throw new Exception("Error al eliminar terreno: " + ex.Message); }
        }
    }
}
