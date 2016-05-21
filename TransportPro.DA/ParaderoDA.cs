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
            return new []{ new Paradero() { Codigo = "LBrasil1", Coordenada = new Coordenada{Latitud =-12.00109,Longitud = -77.11656}},
new Paradero() { Codigo = "LBrasil2", Coordenada = new Coordenada{Latitud =-12.02177,Longitud = -77.10634}},
new Paradero() { Codigo = "LBrasil3", Coordenada = new Coordenada{Latitud =-12.0399,Longitud = -77.09913}},
new Paradero() { Codigo = "LBrasil4", Coordenada = new Coordenada{Latitud =-12.04771,Longitud = -77.09844}},
new Paradero() { Codigo = "LBrasil5", Coordenada = new Coordenada{Latitud =-12.0619,Longitud = -77.09733}},
new Paradero() { Codigo = "LCommon1", Coordenada = new Coordenada{Latitud =-12.06928,Longitud = -77.09818}},
new Paradero() { Codigo = "LBrasil6", Coordenada = new Coordenada{Latitud =-12.06999,Longitud = -77.09447}},
new Paradero() { Codigo = "LBrasil7", Coordenada = new Coordenada{Latitud =-12.0706,Longitud = -77.0919}},
new Paradero() { Codigo = "LBrasil8", Coordenada = new Coordenada{Latitud =-12.07606,Longitud = -77.09331}},
new Paradero() { Codigo = "LBrasil9", Coordenada = new Coordenada{Latitud =-12.07696,Longitud = -77.09331}},
new Paradero() { Codigo = "LBrasil10", Coordenada = new Coordenada{Latitud =-12.08395,Longitud = -77.09651}},
new Paradero() { Codigo = "LBrasil11", Coordenada = new Coordenada{Latitud =-12.08569,Longitud = -77.09303}},
new Paradero() { Codigo = "LBrasil12", Coordenada = new Coordenada{Latitud =-12.08936,Longitud = -77.08503}},

            };
            //return new []{ new Paradero() { Codigo = "A", Coordenada = new Coordenada{Latitud = -12.0871251,Longitud = -77.0052117}},
            //                       new Paradero() { Codigo = "P1", Coordenada = new Coordenada{Latitud = -12.096093, Longitud = -76.989252}},
            //                       new Paradero() { Codigo = "P2", Coordenada = new Coordenada{Latitud = -12.097644, Longitud =  -76.980133}},
            //                       new Paradero() { Codigo = "P3", Coordenada = new Coordenada{Latitud = -12.099207, Longitud =  -76.969335}},
            //                       new Paradero() { Codigo = "B", Coordenada = new Coordenada{Latitud = -12.103812, Longitud = -76.962198}}
            //};
        }

        public Paradero[] GetParaderosLinea2()
        {
            return new []{new Paradero() { Codigo = "LBrasil13", Coordenada = new Coordenada{Latitud =-12.00109,Longitud = -77.11656}},
new Paradero() { Codigo = "LBrasil14", Coordenada = new Coordenada{Latitud =-12.02177,Longitud = -77.10634}},
new Paradero() { Codigo = "LBrasil15", Coordenada = new Coordenada{Latitud =-12.0399,Longitud = -77.09913}},
new Paradero() { Codigo = "LBrasil16", Coordenada = new Coordenada{Latitud =-12.04771,Longitud = -77.09844}},
new Paradero() { Codigo = "LBrasil17", Coordenada = new Coordenada{Latitud =-12.0619,Longitud = -77.09733}},
new Paradero() { Codigo = "LCommon1", Coordenada = new Coordenada{Latitud =-12.06928,Longitud = -77.09818}},
new Paradero() { Codigo = "LBrasil18", Coordenada = new Coordenada{Latitud =-12.06999,Longitud = -77.09447}},
new Paradero() { Codigo = "LBrasil19", Coordenada = new Coordenada{Latitud =-12.0706,Longitud = -77.0919}},
new Paradero() { Codigo = "LBrasil20", Coordenada = new Coordenada{Latitud =-12.07606,Longitud = -77.09331}},
new Paradero() { Codigo = "LBrasil21", Coordenada = new Coordenada{Latitud =-12.07801,Longitud = -77.08874}},
new Paradero() { Codigo = "LBrasil22", Coordenada = new Coordenada{Latitud =-12.07801,Longitud = -77.08179}},
new Paradero() { Codigo = "LBrasil23", Coordenada = new Coordenada{Latitud =-12.08279,Longitud = -77.06763}},
new Paradero() { Codigo = "LBrasil24", Coordenada = new Coordenada{Latitud =-12.08598,Longitud = -77.06377}},

            };
            //return new []{ new () { Codigo = "C", Coordenada = new Coordenada{Latitud = -12.127784, Longitud = -76.991840}},
            //                       new Paradero() { Codigo = "P4", Coordenada = new Coordenada{Latitud = -12.109805, Longitud = -76.984211}},
            //                       new Paradero() { Codigo = "P2", Coordenada = new Coordenada{Latitud = -12.097644, Longitud =  -76.980133}},
            //                       new Paradero() { Codigo = "P5", Coordenada = new Coordenada{Latitud = -12.063234, Longitud =  -76.961095}},
            //                       new Paradero() { Codigo = "D", Coordenada = new Coordenada{Latitud = -12.006048, Longitud =  -76.911069}}
            //};
        }

        public Paradero[] GetParaderosLinea3()
        {
            return new []{new Paradero() { Codigo = "LBrasil25", Coordenada = new Coordenada{Latitud =-12.00109,Longitud = -77.11656}},
new Paradero() { Codigo = "LBrasil26", Coordenada = new Coordenada{Latitud =-12.02177,Longitud = -77.10634}},
new Paradero() { Codigo = "LBrasil27", Coordenada = new Coordenada{Latitud =-12.0399,Longitud = -77.09913}},
new Paradero() { Codigo = "LBrasil28", Coordenada = new Coordenada{Latitud =-12.04771,Longitud = -77.09844}},
new Paradero() { Codigo = "LBrasil29", Coordenada = new Coordenada{Latitud =-12.0619,Longitud = -77.09733}},
new Paradero() { Codigo = "LCommon1", Coordenada = new Coordenada{Latitud =-12.06928,Longitud = -77.09818}},
new Paradero() { Codigo = "LBrasil30", Coordenada = new Coordenada{Latitud =-12.04922,Longitud = -77.10634}},
new Paradero() { Codigo = "LBrasil31", Coordenada = new Coordenada{Latitud =-12.05451,Longitud = -77.10591}},
new Paradero() { Codigo = "LBrasil32", Coordenada = new Coordenada{Latitud =-12.06282,Longitud = -77.10479}},
new Paradero() { Codigo = "LBrasil33", Coordenada = new Coordenada{Latitud =-12.06827,Longitud = -77.10411}},

            };
        }

        public Paradero GetParaderoMasCerano(Coordenada posicion)
        {
            return LineaDA.GetInstance().lineas.SelectMany(l=>l.Paraderos).OrderBy(p => Distance.GetDistance(p.Coordenada, posicion)).First();
        }

        #endregion

    }
}
