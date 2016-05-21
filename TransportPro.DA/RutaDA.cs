using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransportPro.Entities;

namespace TransportPro.DA
{
    public class RutaDA
    {
        #region "SINGLETON"
        public static RutaDA _instance;

        private RutaDA() {}

        public static RutaDA GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RutaDA();
            }
            return _instance;
        }
        #endregion

        #region "METODOS"
        public IEnumerable<Ruta> GetParadas()
        {   
            return null;
        }

    }
}
