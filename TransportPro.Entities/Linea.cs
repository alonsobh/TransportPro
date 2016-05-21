using System.Collections.Generic;

namespace TransportPro.Entities
{
    public class Linea
    {
        public Empresa Empresa { get; set; }

        public Paradero[] Paraderos { get; set; }
    }
}