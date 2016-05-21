using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransportPro.Entities;

namespace TransportPro.DA
{
    public class LineaDA
    {
        #region "SINGLETON"
        public static LineaDA _instance;

        private LineaDA() { }

        public static LineaDA GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LineaDA();
            }
            return _instance;
        }
        #endregion

        #region "METODOS"
        public Linea GetLinea()
        {
            return new Linea()
            {
                Empresa = new Empresa() { Nombre = "Buses A1" },
                Paraderos = ParaderoDA.GetInstance().GetParadas().ToArray()
            };
        }
        public Linea[] GetLinea(Paradero paradero)
        {
            return new[] { GetLinea() };
        }
        #endregion
    }
}
