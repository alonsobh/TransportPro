using System.Collections.Generic;

namespace TransportPro.Entities
{
    public class Ruta
    {
        public Empresa Empresa { get; set; }

        public List<Paradero> Paraderos { get; set; }
    }
}