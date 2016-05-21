using TransportPro.DA;
using TransportPro.Entities;

namespace TransportPro.BC
{
    public class ParaderoBC
    {
        public Paradero ParaderoMasCerca(Coordenada posicion)
        {
            return ParaderoDA.GetInstance().GetParaderoMasCerano(posicion);
        }

        
    }
}