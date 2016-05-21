using System.Collections.Specialized;
using System.Linq;
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
        public Linea DameLineas(string code )
        {
            return LineaDA.GetInstance().lineas.First(l=>l.Codigo==code);
        }

        public ObjectoDijkstra[] DameGrafos()
        {
            var list = LineaDA.GetInstance().lineas.SelectMany(l => LineaARutaDetalle.DameDetalle(l.Paraderos.First(), l.Paraderos.Last(), l)).ToList();
            list.AddRange(LineaDA.GetInstance().lineas.SelectMany(l => LineaARutaDetalle.DameDetalle(l.Paraderos.Last(), l.Paraderos.First(), l)).ToList());
            var lista2= list
                .GroupBy(l=> l.ParaderoOrigen.Codigo + "/"+ l.ParaderoDestino.Codigo)
                .Select(k=> k.First())
                .ToArray();

            return lista2
                .GroupBy(l => l.ParaderoOrigen.Codigo)
                .Select(k => new ObjectoDijkstra
                {
                    Origen = k.First().ParaderoOrigen,
                    Destinos =
                        k.Select(d => new Dijkstra {Destino = d.ParaderoDestino, Distancia = d.Distancia}).ToArray()
                }).ToArray();
        }

        public class ObjectoDijkstra
        {
            public Paradero Origen { get; set; }
            public Dijkstra[] Destinos { get; set; }
        }

        public class Dijkstra
        {
            public Paradero Destino { get; set; }
            public double Distancia { get; set; }
        }
    }
}