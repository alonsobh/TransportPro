using System;

namespace TransportPro.Entities.Helpers
{
   public static class Distance
    {
        public static double GetDistance(Coordenada point1, Coordenada point2)
        {
            var lat = (point2.Latitud - point1.Latitud) * (Math.PI / 180);
            var lon = (point2.Longitud - point1.Longitud) * (Math.PI / 180);
            var a = Math.Sin(lat / 2) * Math.Sin(lat / 2) + Math.Cos(point1.Latitud * (Math.PI / 180)) * Math.Cos(point2.Latitud * (Math.PI / 180)) * Math.Sin(lon / 2) * Math.Sin(lon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var distance = EarthRadius * c;
            return distance;
        }
        public const double EarthRadius = 6371;
    }
}