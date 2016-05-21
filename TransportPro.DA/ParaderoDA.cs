using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransportPro.Entities;

namespace TransportPro.DA
{
    public class ParaderoDA
    {
        Paradero[] a;

        #region "SINGLETON"
        public static ParaderoDA _instance;

        private ParaderoDA() { a = llenarParadero(); }

        public static ParaderoDA GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ParaderoDA();
            }
            return _instance;
        }
        #endregion



        #region "METODOS"
        public static Paradero[] llenarParadero() 
        {
            return new Paradero[]{ new Paradero(){ Codigo = "01", Coordenada = new Coordenada{Longitud = 17.325,Latitud = 18.569}},
                                   new Paradero(){ Codigo = "02", Coordenada = new Coordenada{Longitud = 20.325,Latitud = 19.569}},
                                   new Paradero() { Codigo = "03", Coordenada = new Coordenada{Longitud = 21.854, Latitud = 20.451}}
            };

        }

        public IEnumerable<Paradero> GetParadas()
        {
            return a;
        }

        #endregion

    }
}
