using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_project1_83807
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // getallen uit text veld halen
            string getaltext1 = getalveld1.Text;
            string getaltext2 = getalveld2.Text;

            // getal in int veranderen
            double getal1 = double.Parse(getaltext1);
            double getal2 = double.Parse(getaltext2);

            // do the math
            double antwoord = getal1 * getal2;

            // getal terug in string veranderen
            string antwoordtext = antwoord.ToString();

            // getal in veld zetten
            antwoordveld.Text = antwoordtext;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // getallen uit text veld halen
            string getaltext1 = getalveld1.Text;
            string getaltext2 = getalveld2.Text;

            // getal in int veranderen
            double getal1 = double.Parse(getaltext1);
            double getal2 = double.Parse(getaltext2);

            // do the math
            double antwoord = getal1 / getal2;

            // getal terug in string veranderen
            string antwoordtext = antwoord.ToString();

            // getal in veld zetten
            antwoordveld.Text = antwoordtext;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // getallen uit text veld halen
            string getaltext1 = getalveld1.Text;
            string getaltext2 = getalveld2.Text;

            // getal in int veranderen
            double getal1 = double.Parse(getaltext1);
            double getal2 = double.Parse(getaltext2);

            // do the math
            double antwoord = getal1 - getal2;

            // getal terug in string veranderen
            string antwoordtext = antwoord.ToString();

            // getal in veld zetten
            antwoordveld.Text = antwoordtext;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // getallen uit text veld halen
            string getaltext1 = getalveld1.Text;
            string getaltext2 = getalveld2.Text;

            // getal in int veranderen
            double getal1 = double.Parse(getaltext1);
            double getal2 = double.Parse(getaltext2);

            // do the math
            double antwoord = getal1 + getal2;

            // getal terug in string veranderen
            string antwoordtext = antwoord.ToString();

            // getal in veld zetten
            antwoordveld.Text = antwoordtext;
        }
    }
}