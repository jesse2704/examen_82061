using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_project1_83807
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           double getalvoor = Convert.ToDouble(TextBox1.Text);
     
           int teller = 0;

            Label1.Text = "";

            while (teller < 10)
            {
                teller++;
                double result = getalvoor * teller;
                Label1.Text += " " + teller + " * " + getalvoor + " = " + result + "<br/>";
            }

           Label1.Text += "KLAAR!";

        }
    }
}