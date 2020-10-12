using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Proyecto2SIPC2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }
        protected Boolean IniciarSesion(String usuario, String contrasenia)
        {
            String cadena;
            cadena = ("Select nomUser from usuario  where nomuser = @user AND contrasenia = @pass");

            try
            {
                string connectionString = @"Data Source=DESKTOP-KTTU0OF; Initial Catalog = othello; Integrated Security=True;";

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlParameter paruser = new SqlParameter("@user", usuario);
                    SqlParameter parpass = new SqlParameter("@pass", contrasenia);
                    SqlCommand sqlDa = new SqlCommand(cadena, sqlCon);
                    sqlDa.Parameters.Add(paruser);
                    sqlDa.Parameters.Add(parpass);
                    SqlDataReader lector = sqlDa.ExecuteReader();
                    lector.Read();
                    {
                        Session["usuario"] = lector.GetString(0);
                    }
                    lector.Close();
                    sqlCon.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IniciarSesion(TextBox1.Text, TextBox2.Text))
            {
                Response.Redirect("Menu.aspx");
            }
            else
            {
                TextBox2.Text = null;
                ClientScript.RegisterClientScriptBlock(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + "Usuario o Contrasenia incorrectas!" + "');</script>");

            }
        }
    }
}