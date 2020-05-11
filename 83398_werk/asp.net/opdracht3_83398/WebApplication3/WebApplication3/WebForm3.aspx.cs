using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime vandaag        = DateTime.Now;

            DateTime sinterklaas    = DateTime.Parse("5/12/2020");

            TimeSpan verschil       = sinterklaas.Subtract(vandaag);

            int aantalDagen         = verschil.Days;


            Label2.Text = aantalDagen.ToString();

            //Label1.Text = vandaag.ToString();
            Label1.Text = DateTime.Now.ToString("M-d-yyyy");

        }
    }
}