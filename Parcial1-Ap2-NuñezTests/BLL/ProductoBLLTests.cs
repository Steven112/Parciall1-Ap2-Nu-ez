using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_Ap2_Nuñez.BLL;
using Parcial1_Ap2_Nuñez.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1_Ap2_Nuñez.BLL.Tests
{
    [TestClass()]
    public class ProductoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Producto producto = new Producto();
            producto.ArticulosId = 5;
            producto.Descripcion = "Manzanas";
            producto.Existencia = 4;
            producto.Costo =Convert.ToDecimal(25.00);
            producto.ValorInventario = producto.Existencia * producto.Costo;
            paso = ProductoBLL.Guardar(producto);
            Assert.AreEqual(paso,true);
        }


       

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Producto producto = new Producto();
            producto.ArticulosId = 4;
            producto.Descripcion = "Manzanas";
            producto.Existencia = 3;
            producto.Costo = Convert.ToDecimal(25.00);
            producto.ValorInventario = producto.Existencia * producto.Costo;
            paso = ProductoBLL.Modificar(producto);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var paso = ProductoBLL.Buscar(5);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            var paso = ProductoBLL.Eliminar(4);
            Assert.AreEqual(paso, true);
        }

       
    }
}