using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Subgurim.Controles;

namespace MuaRe
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fulladdress = TextBox1.Text;
            string skey = ConfigurationManager.AppSettings["googlemaps.subgurim.net"];
            GeoCode geocode;
            geocode = GMap1.getGeoCodeRequest(fulladdress);
            var glatlng = new Subgurim.Controles.GLatLng(geocode.Placemark.coordinates.lat, geocode.Placemark.coordinates.lng);
            GMap1.setCenter(glatlng, 16, Subgurim.Controles.GMapType.GTypes.Normal);
            var oMarker = new Subgurim.Controles.GMarker(glatlng);
            GMap1.addGMarker(oMarker);  
        }
    }
}
