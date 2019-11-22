using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Tests
{
    [TestClass()]
    public class SistemaLoteriaChancesTests
    {
        [TestMethod()]
        public void IniciarSesionValoresIncorrectosTest()
        {
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            Usuario usuario = sistemaLoteriaChances.IniciarSesion("admin", "1");
            Assert.AreEqual(-1, usuario.Rol);

            usuario = sistemaLoteriaChances.IniciarSesion("usuario", "admin");
            Assert.AreEqual(-1, usuario.Rol);
        }

        [TestMethod()]
        public void IniciarSesionValoresCorrectosTest()
        {
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            Usuario usuario = sistemaLoteriaChances.IniciarSesion("admin", "admin");
            Assert.AreEqual(1, usuario.Rol);

            usuario = sistemaLoteriaChances.IniciarSesion("usuario", "usuario");
            Assert.AreEqual(0, usuario.Rol);
        }

        [TestMethod()]
        public void CrearSorteoTest()
        {

        }

        [TestMethod()]
        public void GenerarReporteResultadosSorteoTest()
        {

        }

        [TestMethod()]
        public void GenerarReportePlanPremiosSorteoTest()
        {

        }

        [TestMethod()]
        public void ObtenerTopNumerosPrimerPremioTest()
        {

        }

        [TestMethod()]
        public void ObtenerTopNumerosMasDineroRepartidoTest()
        {

        }

        [TestMethod()]
        public void ObtenerTopNumerosMasJugadosTest()
        {

        }

        [TestMethod()]
        public void ObtenerPorcentajeAparicionNumerosTest()
        {

        }
    }
}