using System.Linq;
using TransportPro.Entities;
using TransportPro.Entities.Helpers;

namespace TransportPro.DA
{
    public class ParaderoDA
    {
        #region "SINGLETON"
        private static ParaderoDA _instance;

        public static ParaderoDA GetInstance()
        {
            return _instance ?? (_instance = new ParaderoDA());
        }

        #endregion



        #region "METODOS"

        public Paradero[] GetParaderosLinea1()
        {
            return new Paradero[]{ new Paradero() { Codigo = "A", Coordenada = new Coordenada{Latitud = -12.0871251,Longitud = -77.0052117}},
                                   new Paradero() { Codigo = "P1", Coordenada = new Coordenada{Latitud = -12.096093, Longitud = -76.989252}},
                                   new Paradero() { Codigo = "P2", Coordenada = new Coordenada{Latitud = -12.097644, Longitud =  -76.980133}},
                                   new Paradero() { Codigo = "P3", Coordenada = new Coordenada{Latitud = -12.099207, Longitud =  -76.969335}},
                                   new Paradero() { Codigo = "B", Coordenada = new Coordenada{Latitud = -12.103812, Longitud = -76.962198}}
            };
        }

        public Paradero[] GetParaderosLinea2()
        {
            return new Paradero[]{ new Paradero() { Codigo = "C", Coordenada = new Coordenada{Latitud = -12.127784, Longitud = -76.991840}},
                                   new Paradero() { Codigo = "P4", Coordenada = new Coordenada{Latitud = -12.109805, Longitud = -76.984211}},
                                   new Paradero() { Codigo = "P2", Coordenada = new Coordenada{Latitud = -12.097644, Longitud =  -76.980133}},
                                   new Paradero() { Codigo = "P5", Coordenada = new Coordenada{Latitud = -12.063234, Longitud =  -76.961095}},
                                   new Paradero() { Codigo = "D", Coordenada = new Coordenada{Latitud = -12.006048, Longitud =  -76.911069}}
            };
        }

        public Paradero GetParaderoMasCerano(Coordenada posicion)
        {
            var paradero = new Paradero[]{ new Paradero() { Codigo = "A", Coordenada = new Coordenada{Latitud = -12.0871251,Longitud = -77.0052117}},
                                   new Paradero() { Codigo = "B", Coordenada = new Coordenada{Latitud = -12.103812, Longitud = -76.962198}},
                                   new Paradero() { Codigo = "C", Coordenada = new Coordenada{Latitud = -12.127784, Longitud = -76.991840}},
                                   new Paradero() { Codigo = "D", Coordenada = new Coordenada{Latitud = -12.006048, Longitud =  -76.911069}},
                                   new Paradero() { Codigo = "P1", Coordenada = new Coordenada{Latitud = -12.096093, Longitud = -76.989252}},
                                   new Paradero() { Codigo = "P2", Coordenada = new Coordenada{Latitud = -12.097644, Longitud =  -76.980133}},
                                   new Paradero() { Codigo = "P3", Coordenada = new Coordenada{Latitud = -12.099207, Longitud =  -76.969335}},
                                   new Paradero() { Codigo = "P4", Coordenada = new Coordenada{Latitud = -12.109805, Longitud = -76.984211}},
                                   new Paradero() { Codigo = "P5", Coordenada = new Coordenada{Latitud = -12.063234, Longitud =  -76.961095}}
            };

            return paradero.OrderBy(p => Distance.GetDistance(p.Coordenada, posicion)).First();
        }

        #endregion

    }
}
