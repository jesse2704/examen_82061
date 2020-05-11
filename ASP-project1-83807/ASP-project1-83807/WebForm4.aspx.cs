using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_project1_83807
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pennenText = pennenVeld.Text;
            double pennen = double.Parse(pennenText);

            if ((pennen > 0) && (pennen <= 10 ))
            {
                double kosten = pennen * 2;
                Label2.Text = "U heeft minder dan 10 pennen gekocht!";
                Label1.Text = kosten.ToString();
            }

            else if ((pennen > 10) && (pennen <= 50))
            {
                double kosten = pennen * 1.50;
                Label2.Text = "U heeft tussen de 10 en 50 pennen gekocht!";
                Label1.Text = kosten.ToString();
            }

            else if ((pennen > 50) && (pennen <= 100))
            {
                double kosten = pennen * 1.25;
                Label2.Text = "U heeft tussen de 50 en 100 pennen gekocht!";
                Label1.Text = kosten.ToString();
            }

            else if ((pennen > 100))
            {
                double kosten = pennen * 1.10;
                Label2.Text = "U heeft meer dan 100 pennen gekocht GEFELICITEERD!";
                Label1.Text = kosten.ToString();
            }

            else
            {
                Label1.Text = "Vul een geldig getal in IDIOOT!";
            }



            // pennen minder dan 10
            // pennen 10 tot 50
            // pennen 50 tot 100
            // pennen meer dan 100
        }
    }
}