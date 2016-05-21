using TransportPro.DA;
using TransportPro.Entities;

namespace TransportPro.BC
{
    public class LineaBC
    {
        public Linea[] DameLineas(Paradero paradero)
        {
            return LineaDA.GetInstance().GetLinea(paradero);
        }
    }
}