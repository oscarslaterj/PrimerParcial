using System;
using PrimerParcial.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using PrimerParcial.DAL;

namespace PrimerParcial.BLL
{
    public class VendedoresBLL
    {
        public static bool Guardar(Vendedores vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Vendedores.Add(vendedor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Modificar(Vendedores vendedor)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(vendedor).State = System.Data.Entity.EntityState.Modified;
                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Vendedores.Find(id);
                db.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        public static Vendedores Buscar(int id)
        {
            Contexto db = new Contexto();
            Vendedores vendedor = new Vendedores();
            try
            {
                vendedor = db.Vendedores.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vendedor;
        }


        public static List<Vendedores> GetList(Expression<Func<Vendedores, bool>> persona)
        {
            List<Vendedores> people = new List<Vendedores>();
            Contexto db = new Contexto();
            try
            {
                people = db.Vendedores.Where(persona).ToList();
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return people;
        }

    }
}
