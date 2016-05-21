namespace TransportPro.Entities
{
    public class Linea
    {
        public string  Codigo{ get; set; }

        public Empresa Empresa { get; set; }

        public Paradero[] Paraderos { get; set; }
    }
}