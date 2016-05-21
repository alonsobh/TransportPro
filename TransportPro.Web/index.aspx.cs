using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportPro.BC;
using TransportPro.Entities;

namespace TransportPro.Web
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var val = GetDate(-12.02177, -77.10634, -12.05451, -77.10591);
        }

        [WebMethod]
        public static object GetDate(double locationLatitud, double locationLongitud, double destinationLatitud, double destinationLongitud)
        {
            var posicionCercaA = new Coordenada { Latitud = locationLatitud, Longitud = locationLongitud };
            var posicionCercaD = new Coordenada { Latitud = destinationLatitud, Longitud = destinationLongitud };
            RutaBC rutabc = new RutaBC();
            var result = rutabc.DameRuta(posicionCercaA, posicionCercaD);

            var s = new JavaScriptSerializer();
            var obj = s.Serialize(result);
            return obj;
        }

        private RutaBC RutaBC { get { return _rutaBC ?? (_rutaBC = new RutaBC()); } }
        private RutaBC _rutaBC;
    }
}