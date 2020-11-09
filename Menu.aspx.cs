using System;

namespace Proyecto2SIPC2
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["jugador2"] = false;
            Response.Redirect("~/juegoExt.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["jugador2"] = true;
            Session["j2"] = TextBox2.Text;
            Response.Redirect("~/juegoExt.aspx");
        }
    }
}