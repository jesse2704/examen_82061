using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace opdracht1_83398
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mijnknop_Click(object sender, EventArgs e)
        {
            string voorNaam = voornaamveld.Text;
            string achterNaam = achternaamveld.Text;
            string woonPlaats = woonplaatsveld.Text;
            string Klas = klasveld.Text;

            string namen = "Hallo, " + voorNaam + " " + achterNaam;
            string woont = "Je woont in " + woonPlaats;
            string groep = "Je zit in klas " + Klas;

            string Groet =  namen + "<br>" + woont + "<br>" + groep;

            groet.Text = Groet;


        }
    }
}