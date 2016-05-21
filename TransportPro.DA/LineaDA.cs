using System.Linq;
using TransportPro.Entities;

namespace TransportPro.DA
{
    public class LineaDA
    {
        #region "SINGLETON"
        private static LineaDA _instance;

        public static LineaDA GetInstance()
        {
            return _instance ?? (_instance = new LineaDA());
        }

        #endregion

        #region "METODOS"

        public LineaDA()
        {
            lineas = new[]
            {
                 new Linea {Codigo = "Linea 1",Empresa = new Empresa { Nombre = "Buses A1" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea1()} ,
                 new Linea {Codigo = "Linea 2",Empresa = new Empresa { Nombre = "Buses A2" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea2()},
                 new Linea {Codigo = "Linea 3",Empresa = new Empresa { Nombre = "Buses A3" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea3()},
                 new Linea {Codigo = "Linea 4",Empresa = new Empresa { Nombre = "Buses A4" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea4()},
                 new Linea {Codigo = "Linea 5",Empresa = new Empresa { Nombre = "Buses A5" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea5()},
                 new Linea {Codigo = "Linea 11",Empresa = new Empresa { Nombre = "Buses A1" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea11()},
                 new Linea {Codigo = "Linea 12",Empresa = new Empresa { Nombre = "Buses A2" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea12()},
                 new Linea {Codigo = "Linea 13",Empresa = new Empresa { Nombre = "Buses A3" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea13()},
                 new Linea {Codigo = "Linea 14",Empresa = new Empresa { Nombre = "Buses A4" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea14()},
                 new Linea {Codigo = "Linea 15",Empresa = new Empresa { Nombre = "Buses A5" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea15()},
            };
        }



        public Linea[] GetLinea(Paradero paradero)
        {
            return lineas.Where(l => l.Paraderos.Any(p => p.Codigo == paradero.Codigo)).ToArray();
        }

        public readonly Linea[] lineas;

        #endregion
    }
}
