using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2SIPC2
{
    public partial class Juego : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Pulsar(String hola) 
        {
            ClientScript.RegisterClientScriptBlock(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Usuario o Contrasenia incorrectas!" + "');</script>");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
        public void Click(object sender, EventArgs args)
        {

            Button button = sender as Button;
            button.Attributes.Add("style", "border-radius: 100%; background-color: Black;");

        }

        
    }
}