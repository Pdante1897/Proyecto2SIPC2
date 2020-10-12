using System;

namespace Proyecto2SIPC2
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.BackColor = System.Drawing.Color.Blue;
            Session["partida"] = false;
            Session["menu"] = true;
        }
    }
}