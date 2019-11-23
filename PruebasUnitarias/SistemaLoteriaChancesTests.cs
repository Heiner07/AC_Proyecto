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
            //Error
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            Boolean verificar = sistemaLoteriaChances.CrearSorteo(new Sorteo());
            Assert.AreEqual(false, verificar);
        }

        [TestMethod()]
        public void GenerarReporteResultadosSorteoTest()
        {
            //Error
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            Boolean verificar = sistemaLoteriaChances.GenerarReporteResultadosSorteo(new Sorteo());
            Assert.AreEqual(false, verificar);
        }

        [TestMethod()]
        public void GenerarReportePlanPremiosSorteoTest()
        {
            //Error
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            Boolean verificar = sistemaLoteriaChances.GenerarReportePlanPremiosSorteo(new Sorteo());
            Assert.AreEqual(false, verificar);
        }

        [TestMethod()]
        public void ObtenerTopNumerosPrimerPremioTest()
        {
            //Error
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            List<Resultado> verificar = sistemaLoteriaChances.ObtenerTopNumerosPrimerPremio("");
            Assert.AreNotEqual(verificar, null);
        }

        [TestMethod()]
        public void ObtenerTopNumerosMasDineroRepartidoTest()
        {
            //Error
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            List<Resultado> verificar = sistemaLoteriaChances.ObtenerTopNumerosMasDineroRepartido("");
            Assert.AreNotEqual(verificar, null);
        }

        [TestMethod()]
        public void ObtenerTopNumerosMasJugadosTest()
        {
            //Error
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            List<Resultado> verificar = sistemaLoteriaChances.ObtenerTopNumerosMasJugados("");
            Assert.AreNotEqual(verificar, null);
        }

        [TestMethod()]
        public void ObtenerPorcentajeAparicionNumerosTest()
        {
            SistemaLoteriaChances sistemaLoteriaChances = new SistemaLoteriaChances();
            List<PorcentajeNumeros> verificar = sistemaLoteriaChances.ObtenerPorcentajeAparicionNumeros();
            Assert.AreNotEqual(null, verificar);
        }
    }
}