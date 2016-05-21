using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportPro.BC;
using TransportPro.Entities;

namespace TransportPro.Test
{
    [TestClass]
    public class RutaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var posicionCercaA = new Coordenada { Latitud = -12.0871251, Longitud = -77.0052117 };
            var posicionCercaD = new Coordenada { Latitud = -12.006048, Longitud = -76.911069 };
            var result = RutaBC.DameRuta(posicionCercaA, posicionCercaD);

        }

        private RutaBC RutaBC { get { return _rutaBC ?? (_rutaBC = new RutaBC()); } }
        private RutaBC _rutaBC;
    }
}
