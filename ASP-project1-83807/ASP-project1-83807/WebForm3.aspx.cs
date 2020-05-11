using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_project1_83807
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // bepaal date of vandaag
            DateTime vandaag = DateTime.Now;
            // bepaal de date of sint
            DateTime sinterklaas = DateTime.Parse("5/12/2020");
            // bereken het verschil tussen de data
            TimeSpan verschil = sinterklaas.Subtract(vandaag);
            // bepaal het verschil in dagen
            int aantaldagen = verschil.Days;

            // het posten van data op de pagina
            Label1.Text = vandaag.ToString("dd-MM-yyyy");

            Label2.Text = aantaldagen.ToString();
        }

    }
}