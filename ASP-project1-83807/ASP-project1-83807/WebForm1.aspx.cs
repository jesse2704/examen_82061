using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_project1_83807
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_click(object sender, EventArgs e)
        {
            string voorNaam = voornaam.Text;
            string achterNaam = achternaam.Text;
            string klasNaam = klas.Text;
            string woonPlaats = woonplaats.Text;


            string begroeting = "Hallo " + voorNaam + achterNaam + ", <br/> U zit in de klas " + klasNaam + ", <br/> en U woont in " + woonPlaats + ".";
            mijnBegroeting.Text = begroeting;
        }
    }
}