namespace TransportPro.Entities
{
    public class Ruta
    {
        public int Distancia { get; set; }

        public RutaDetalle[] Detalle { get; set; }
    }
}