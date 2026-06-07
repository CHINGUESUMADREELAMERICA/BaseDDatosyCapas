using CapaDatos1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos1
{
    public class DTerrenoAgrega
    {
        public void Agregar(DTerreno terreno)
        {
            using var db = new AppDbContext();
            db.Terrenos.Add(terreno);
            db.SaveChanges();
        }

        public DTerreno BuscarPorId(int id)
        {
            using var db = new AppDbContext();
            return db.Terrenos.Find(id);
        }

        public DTerreno BuscarPorNoTerreno(string noTerreno)
        {
            using var db = new AppDbContext();
            return db.Terrenos.FirstOrDefault(t => t.NoTerreno == noTerreno);
        }

        public List<DTerreno> ObtenerTodos()
        {
            using var db = new AppDbContext();
            return db.Terrenos.ToList();
        }

        public List<DTerreno> ObtenerEnVenta()
        {
            using var db = new AppDbContext();
            return db.Terrenos.Where(t => t.EnVenta == true).ToList();
        }

        public List<DTerreno> ObtenerPorCliente(int clienteId)
        {
            using var db = new AppDbContext();
            return db.Terrenos.Where(t => t.ClienteId == clienteId).ToList();
        }

        public void Actualizar(DTerreno terreno)
        {
            using var db = new AppDbContext();
            db.Terrenos.Update(terreno);
            db.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var db = new AppDbContext();
            var terreno = db.Terrenos.Find(id);
            if (terreno != null)
            {
                db.Terrenos.Remove(terreno);
                db.SaveChanges();
            }
        }
    }
}
