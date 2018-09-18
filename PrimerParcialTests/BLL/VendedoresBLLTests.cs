using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerParcial.Entidades;


namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class VendedoresBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Vendedores vendedor = new Vendedores();
            vendedor.Nombres = "Oscar";
            vendedor.Sueldo = 3000;
            vendedor.Retencion = 4;
            vendedor.PorcRetencion = 10;
            paso = VendedoresBLL.Guardar(vendedor);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {

            bool paso = false;
            Vendedores vendedor = new Vendedores();
            vendedor.VendedorId = 8;
            vendedor.Nombres = "klk";
            vendedor.Sueldo = 10000;
            vendedor.Retencion = 6;
            vendedor.PorcRetencion = 3;
            paso = VendedoresBLL.Modificar(vendedor);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = VendedoresBLL.Eliminar(4);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Vendedores vendedor = new Vendedores();
            vendedor = VendedoresBLL.Buscar(8);
            Assert.IsNotNull(vendedor);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var Lista = VendedoresBLL.GetList(x => true);
            Assert.IsNotNull(Lista);
        }
    }
}