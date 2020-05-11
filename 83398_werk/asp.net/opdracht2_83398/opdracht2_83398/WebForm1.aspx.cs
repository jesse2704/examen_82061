using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace opdracht2_83398
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime datumtijd = DateTime.Now;
            //Label1.Text = datumtijd.DayOfWeek.ToString();
            Label3.Text = "" + datumtijd.Hour + ":" + datumtijd.Minute;
         }

        protected void Button1_Click(object sender, EventArgs e)
        {

           // string getal1 = TextBox1.Text;
           // string getal2 = TextBox2.Text;

           //try
            //{

           //     double getal1int = double.Parse(getal1);
           //    double getal2int = double.Parse(getal2);

           //     Label1.Text = "" + (getal1int + getal2int);
           // }
           // catch(Exception e2)
           // {
           //     Label1.Text = "Vul getallen in!";
           // }
        }

        protected void plus_Click(object sender, EventArgs e)
        {
            string getal1 = TextBox1.Text;
            string getal2 = TextBox2.Text;

            try
            {

                double getal1int = double.Parse(getal1);
                double getal2int = double.Parse(getal2);

                Label1.Text = "" + (getal1int + getal2int);
            }
            catch (Exception e2)
            {
                Label1.Text = "Vul getallen in!";
            }

        }

        protected void min_Click(object sender, EventArgs e)
        {
            string getal1 = TextBox1.Text;
            string getal2 = TextBox2.Text;

            try
            {

                double getal1int = double.Parse(getal1);
                double getal2int = double.Parse(getal2);

                Label1.Text = "" + (getal1int - getal2int);
            }
            catch (Exception e2)
            {
                Label1.Text = "Vul getallen in!";
            }
        }

        protected void keer_Click(object sender, EventArgs e)
        {
            string getal1 = TextBox1.Text;
            string getal2 = TextBox2.Text;

            try
            {

                double getal1int = double.Parse(getal1);
                double getal2int = double.Parse(getal2);

                Label1.Text = "" + (getal1int * getal2int);
            }
            catch (Exception e2)
            {
                Label1.Text = "Vul getallen in!";
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string getal1 = TextBox1.Text;
            string getal2 = TextBox2.Text;

            try
            {

                double getal1int = double.Parse(getal1);
                double getal2int = double.Parse(getal2);

                Label1.Text = "" + (getal1int / getal2int);
            }
            catch (Exception e2)
            {
                Label1.Text = "Vul getallen in!";
            }
        }
    }
}