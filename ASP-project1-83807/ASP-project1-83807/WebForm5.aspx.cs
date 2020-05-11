using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_project1_83807
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rekenuit_Click1(object sender, EventArgs e)
        {
            double totaal = 3;
            if (Tomatensaus.Checked)
            {
                totaal += 3;
            }
            if (Salami.Checked)
            {
                totaal += 2;
            }
            if (Pepperoni.Checked)
            {
                totaal += 2;
            }
            if (Ham.Checked)
            {
                totaal += 2;
            }
            if (Mozzarella.Checked)
            {
                totaal += 3;
            }
            if (Paprika.Checked)
            {
                totaal += 1.50;
            }
            if (Champignon.Checked)
            {
                totaal += 1.50;
            }
            if (Gorgonzola.Checked)
            {
                totaal += 3;
            }
            if (Knoflook.Checked)
            {
                totaal += 1;
            }
            if (Ananas.Checked)
            {
                totaal += 999;
            }

            Totaal.Text = totaal.ToString();

        }
    }
}
