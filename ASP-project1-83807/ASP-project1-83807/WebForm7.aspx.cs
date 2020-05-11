using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_project1_83807
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string zoekDag = vandaag.Text;
            double overDag = Convert.ToDouble(antwoord.Text);
            int block = Convert.ToInt32(overDag);

            int antwoord = block % 7;
            int over
        }
    }
}