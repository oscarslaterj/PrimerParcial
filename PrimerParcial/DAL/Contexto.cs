using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;

namespace RegistroArticulos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vendedores> Vendedores { get; set; }

        public Contexto() : base("Constr") { }
    }
}