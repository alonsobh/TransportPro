using System.Linq;
using TransportPro.Entities;

namespace TransportPro.DA
{
    public class LineaDA
    {
        #region "SINGLETON"
        public static LineaDA _instance;
        
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

        public LineaDA()
        {
            lineas = new []
            {
                new Linea {Codigo = "Linea 1",Empresa = new Empresa { Nombre = "Buses A1" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea1()} ,
                 new Linea {Codigo = "Linea 2",Empresa = new Empresa { Nombre = "Buses A2" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea2()},
                 new Linea {Codigo = "Linea 3",Empresa = new Empresa { Nombre = "Buses A3" }, Paraderos =  ParaderoDA.GetInstance().GetParaderosLinea3()},
            };
        }



        public Linea[] GetLinea(Paradero paradero)
        {
            return lineas.Where(l=>l.Paraderos.Any(p=>p.Codigo == paradero.Codigo)).ToArray();
        }

        public readonly Linea[] lineas;

        #endregion
    }
}
