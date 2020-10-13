using System;

namespace Proyecto2SIPC2
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Jugador: "+(string)Session["usuario"];
            Session["partida"] = false;
            Session["menu"] = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["jugador2"] = false;
            if (CheckBox1.Checked)
            {
                Session["colorficha"] = "Negro";
                Session["colorficha2"] = "Blanco";

            }
            else
            {
                Session["colorficha"] = "Blanco";
                Session["colorficha2"] = "Negro";

            }
            Response.Redirect("~/juego.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["jugador2"] = true;
            Session["j2"] = TextBox1.Text;
            if (CheckBox1.Checked)
            {
                Session["colorficha"] = "Negro";
                Session["colorficha2"] = "Blanco";

            }
            else
            {
                Session["colorficha"] = "Blanco";
                Session["colorficha2"] = "Negro";

            }
            Response.Redirect("~/juego.aspx");
        }
    }
}