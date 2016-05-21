using System;
using System.Web.Script.Serialization;
using System.Web.Services;
using TransportPro.BC;
using TransportPro.Entities;

namespace TransportPro.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetDate();
        }

        [WebMethod]
        public object GetDate(double locationLatitud, double locationLongitud, double destinationLatitud, double destinationLongitud)
        {
            var posicionCercaA = new Coordenada { Latitud = locationLatitud, Longitud = locationLongitud };
            var posicionCercaD = new Coordenada { Latitud = destinationLatitud, Longitud = destinationLongitud };
            var result = RutaBC.DameRuta(posicionCercaA, posicionCercaD);

            var s = new JavaScriptSerializer();
            var obj = s.Serialize(result);
            return obj;
        }

        private RutaBC RutaBC { get { return _rutaBC ?? (_rutaBC = new RutaBC()); } }
        private RutaBC _rutaBC;

    }
}